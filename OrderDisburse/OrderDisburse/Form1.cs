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

        private void LoadReport()
        {
            DateTime fromDate = dateTimePicker1.Value.Date;
            DateTime toDate = dateTimePicker2.Value.Date;

            using var db = new AppDbContext();

            var report = db.SaleOrders
                .Where(x => x.OnDate.Date >= fromDate &&
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

                    TotalPiece = g.Sum(x => x.o.TotalPiece),

                    OrderCarton =
                        g.Sum(x => x.o.TotalPiece) / g.Key.TotalPiece,

                    OrderPiece =
                        g.Sum(x => x.o.TotalPiece) % g.Key.TotalPiece
                })
                .ToList();

            dataGridView1.DataSource = report;
        }


        private string GenerateInvoicePDF()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Summary_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf");

            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

            doc.Open();

            // 🧾 Title
            var title = new Paragraph("Summary\n\n",
                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);

            
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
    }


}

