using iTextSharp.text;
using iTextSharp.text.pdf;
using OrderDisburse.Models;

namespace OrderDisburse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCompany();
        }

        private void cartonSizeUnitEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PackageEntryForm packageEntryForm = new PackageEntryForm();
            packageEntryForm.ShowDialog();
        }

        private void productEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductEntryForm productEntryForm = new ProductEntryForm();
            productEntryForm.ShowDialog();
        }

        private void sOEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SOEntryForm SOEntryForm = new SOEntryForm();
            SOEntryForm.ShowDialog();
        }

        private void orderEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleOrderForm saleOrder = new SaleOrderForm();
            saleOrder.ShowDialog();


        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadCompany()
        {
            using var db = new AppDbContext();

            var companies = db.Companies
                .Select(p => new Company
                {
                   Id = p.Id,
                   CompanyName = p.CompanyName
                })
                .ToList();

            cmbCompany.DataSource = companies;
            cmbCompany.DisplayMember = "CompanyName";
            cmbCompany.ValueMember = "Id";


            // Enable typeahead
            cmbCompany.DropDownStyle = ComboBoxStyle.DropDown;
            cmbCompany.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCompany.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void LoadReport()
        {
            DateTime fromDate = dateTimePicker1.Value.Date;
            DateTime toDate = dateTimePicker2.Value.Date;
            int companyId = Convert.ToInt32(cmbCompany.SelectedValue);

            using var db = new AppDbContext();

            var report = db.SaleOrders
                .Where(x => x.CompanyId == companyId && x.OnDate.Date >= fromDate &&
                            x.OnDate.Date <= toDate)
                .Join(db.Packages,
                    o => o.PackageName,
                    p => p.PackageName,
                    (o, p) => new { o, p })
                .GroupBy(x => new
                {
                    x.o.ProductId,
                    x.o.ProductName,
                    x.p.PackageName,
                    x.p.TotalPiece
                })
                .Select(g => new SalesReportVM
                {
                    ProductId = g.Key.ProductId,
                    ProductName = g.Key.ProductName,
                    PackageName = g.Key.PackageName,
                    OrderCarton =
                        g.Sum(x => x.o.TotalPiece) / g.Key.TotalPiece,

                    OrderPiece =
                        g.Sum(x => x.o.TotalPiece) % g.Key.TotalPiece,
                    TotalPiece = g.Sum(x => x.o.TotalPiece)
                })
                .ToList();

            dataGridView1.DataSource = report;

            // Change header names
            dataGridView1.Columns["ProductId"].HeaderText = "Product Id";
            dataGridView1.Columns["ProductName"].HeaderText = "Product Name";
            dataGridView1.Columns["PackageName"].HeaderText = "Package Name";

            dataGridView1.Columns["OrderCarton"].HeaderText = "Order Carton";
            dataGridView1.Columns["OrderPiece"].HeaderText = "Order Piece";
            dataGridView1.Columns["TotalPiece"].HeaderText = "Total Piece";

            dataGridView1.Columns["ReturnCarton"].HeaderText = "Ret. Carton";
            dataGridView1.Columns["ReturnOrderPiece"].HeaderText = "Ret. Order Piece";
            dataGridView1.Columns["ReturnTotalPiece"].HeaderText = "Ret. Total Piece";
        }


        private string GenerateInvoicePDF()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "Summary_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf");

            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

            doc.Open();

            // 🧾 Title
            var title = new Paragraph("Summary\n",
                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);

            if (cmbCompany.SelectedItem != null)
            {
                Company cname = (Company)cmbCompany.SelectedItem;
                var companyName = new Paragraph($"{cname.CompanyName}\n\n",
                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14));
                companyName.Alignment = Element.ALIGN_CENTER;
                doc.Add(companyName);
            }

            

            doc.Add(new Paragraph("Date: " + dateTimePicker1.Value.ToString("dd-MM-yyyy") + " - " +
                                dateTimePicker2.Value.ToString("dd-MM-yyyy")));
            doc.Add(new Paragraph("\n"));

            // 📊 Table
            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
            table.WidthPercentage = 100;

            // Header
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = BaseColor.GREEN;

                table.AddCell(cell);
            }

            // Rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {

                        table.AddCell(cell.Value?.ToString() ?? "");


                    }
                }
            }

            doc.Add(table);

            
            var prg2 = new Paragraph("\nReceived By\n");
            prg2.Alignment = Element.ALIGN_RIGHT;
            doc.Add(prg2);

            var prg1 = new Paragraph("__________________________");
            prg1.Alignment = Element.ALIGN_RIGHT;
            doc.Add(prg1);

            doc.Close();

            return filePath;
        }

        private void PrintPDF(string filePath)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true   // 🔥 THIS IS REQUIRED
            };

            System.Diagnostics.Process.Start(psi);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string pdfPath = GenerateInvoicePDF();

            PrintPDF(pdfPath);
        }

        private void companyEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyEntryForm companyEntryForm = new CompanyEntryForm();
            companyEntryForm.ShowDialog();
        }
    }


}

