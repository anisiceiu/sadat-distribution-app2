using iTextSharp.text;
using iTextSharp.text.pdf;
using OrderDisburse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace OrderDisburse
{
    public partial class SaleOrderList : Form
    {
        public SaleOrderList()
        {
            InitializeComponent();
            LoadCompanyCombo();
        }

        private void LoadCompanyCombo()
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

        private void LoadSOToCombo()
        {
            using var db = new AppDbContext();

            var sos = db.SOs
                .Where(so => so.CompanyId == Convert.ToInt32((cmbCompany.SelectedItem as Company).Id))
                .Select(p => new SO
                {
                    Id = p.Id,
                    Name = p.Name
                })
                .ToList();

            cmbSO.DataSource = sos;
            cmbSO.DisplayMember = "Name";
            cmbSO.ValueMember = "Id";


            // Enable typeahead
            cmbSO.DropDownStyle = ComboBoxStyle.DropDown;
            cmbSO.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSO.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSOToCombo();
        }

        private void LoadReport()
        {
            DateTime fromDate = dateTimePicker1.Value.Date;

            int companyId = Convert.ToInt32(cmbCompany.SelectedValue);

            using var db = new AppDbContext();

            var report = db.SaleOrders
    .Where(x => x.CompanyId == companyId && x.OnDate.Date >= fromDate)
    .Join(db.Packages,
        o => o.PackageName,
        p => p.PackageName,
        (o, p) => new { o, p })
    .Join(db.Products,
        op => op.o.ProductId,
        pr => pr.Id,
        (op, pr) => new SalesOrderReportVM
        {
            ProductId = op.o.ProductId,
            ProductName = op.o.ProductName,
            PackageName = op.p.PackageName,
            OrderCarton = op.o.OrderCarton,
            OrderPiece = op.o.OrderPiece,
            TotalPiece = op.o.TotalPiece,
            TotalAmount = op.o.TotalAmount,
            UnitPrice = pr.UnitPrice
        })
    .ToList();

            dataGridView1.DataSource = report;

            // Change header names
            dataGridView1.Columns["ProductId"].HeaderText = "Id";
            dataGridView1.Columns["ProductName"].HeaderText = "Product Name";
            dataGridView1.Columns["PackageName"].HeaderText = "Pkg. Name";

            dataGridView1.Columns["OrderCarton"].HeaderText = "Order Carton";
            dataGridView1.Columns["OrderPiece"].HeaderText = "Order Piece";
            dataGridView1.Columns["TotalPiece"].HeaderText = "Total Piece";
            dataGridView1.Columns["TotalAmount"].HeaderText = "Total Amount";
            dataGridView1.Columns["UnitPrice"].HeaderText = "Unit Price";

            dataGridView1.Columns["ReturnCarton"].HeaderText = "Ret. Carton";
            dataGridView1.Columns["ReturnOrderPiece"].HeaderText = "Ret. Order Piece";
            dataGridView1.Columns["ReturnTotalPiece"].HeaderText = "Ret. Total Piece";
            dataGridView1.Columns["ReturnTotalAmount"].HeaderText = "Ret. Total Amount";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private string GenerateInvoicePDF()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "Sale Order_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf");

            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

            doc.Open();

            // 🧾 Title
            var title = new Paragraph("Sale Order\n",
                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);

            if (cmbCompany.SelectedItem != null)
            {
                Company cname = (Company)cmbCompany.SelectedItem;
                var companyName = new Paragraph($"{cname.CompanyName}\n",
                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14));
                companyName.Alignment = Element.ALIGN_CENTER;
                doc.Add(companyName);
            }

            if (cmbSO.SelectedItem != null)
            {
                SO so = (SO)cmbSO.SelectedItem;
                var saleOrderInfo = new Paragraph($"SO Name: {so.Name}\n",
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14));
                saleOrderInfo.Alignment = Element.ALIGN_CENTER;
                doc.Add(saleOrderInfo);
            }


            doc.Add(new Paragraph("Date: " + dateTimePicker1.Value.ToString("dd-MM-yyyy")));
            doc.Add(new Paragraph("\n"));

            // 📊 Table
            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
            table.WidthPercentage = 100;

            // Header
            iTextSharp.text.Font boldheaderFont = FontFactory.GetFont(
                    FontFactory.TIMES_ROMAN,
                    9,
                    BaseColor.BLACK
                );
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = BaseColor.GREEN;
                cell.Phrase.Font = boldheaderFont;
                table.AddCell(cell);
            }

            iTextSharp.text.Font boldRedFont = FontFactory.GetFont(
                    FontFactory.HELVETICA_BOLD,
                    9,
                    BaseColor.RED
                );

            iTextSharp.text.Font regularFont = FontFactory.GetFont(
                   FontFactory.TIMES_ROMAN,
                   9,
                   BaseColor.BLACK
               );
            // Rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {


                        if (cell.ColumnIndex == 3)
                        {
                            PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? "", boldRedFont));
                            //pdfCell.HorizontalAlignment = Element.ALIGN_RIGHT;

                            table.AddCell(pdfCell);
                        }
                        else
                        {
                            PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? "", regularFont));
                            table.AddCell(pdfCell);
                        }

                    }
                }
            }

            doc.Add(table);

            // -------------------- SUMMARY TABLE (RIGHT ALIGNED) --------------------
            iTextSharp.text.Font font = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10);
            PdfPTable summaryTable = new PdfPTable(2);
            summaryTable.SetTotalWidth(new float[] { 100f, 80f }); // control width
            summaryTable.LockedWidth = true;
            summaryTable.HorizontalAlignment = Element.ALIGN_RIGHT;

            summaryTable.AddCell(new PdfPCell(new Phrase("Total received (TK)", font)));
            summaryTable.AddCell(new PdfPCell(new Phrase("", font)));

            summaryTable.AddCell(new PdfPCell(new Phrase("Total return (TK)", font)));
            summaryTable.AddCell(new PdfPCell(new Phrase("", font)));

            summaryTable.AddCell(new PdfPCell(new Phrase("Total sales", font)));
            summaryTable.AddCell(new PdfPCell(new Phrase("", font)));

            summaryTable.AddCell(new PdfPCell(new Phrase("Damage", font)));
            summaryTable.AddCell(new PdfPCell(new Phrase("", font)));

            summaryTable.AddCell(new PdfPCell(new Phrase("Disbursed money", font)));
            summaryTable.AddCell(new PdfPCell(new Phrase("", font)));

            summaryTable.AddCell(new PdfPCell(new Phrase("Deposit/collected", font)));
            summaryTable.AddCell(new PdfPCell(new Phrase("", font)));

            summaryTable.AddCell(new PdfPCell(new Phrase("Due", font)));
            summaryTable.AddCell(new PdfPCell(new Phrase("", font)));
            // add summary table
            doc.Add(summaryTable);


            var prg21 = new Paragraph("\nManager\n");
            prg21.Alignment = Element.ALIGN_LEFT;
            doc.Add(prg21);

            var prg11 = new Paragraph("__________________________");
            prg11.Alignment = Element.ALIGN_LEFT;
            doc.Add(prg11);

            var prg2 = new Paragraph("DOR\n");
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
    }
}
