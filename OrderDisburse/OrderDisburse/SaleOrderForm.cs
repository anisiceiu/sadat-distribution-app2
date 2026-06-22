using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OrderDisburse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OrderDisburse
{
    public partial class SaleOrderForm : Form
    {
        public SaleOrderForm()
        {
            InitializeComponent();
            //LoadSOToCombo();
            //LoadProducts();
            //SetupGrid();
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

        private List<Product> _products;

        private void LoadProducts()
        {
            using var db = new AppDbContext();
            _products = db.Products.Where(p => p.CompanyId == Convert.ToInt32((cmbCompany.SelectedItem as Company).Id)).ToList();
            SetupGrid();
        }

        private void LoadSOToCombo()
        {
            using var db = new AppDbContext();

            var sos = db.SOs
                .Where(so => so.CompanyId == Convert.ToInt32((cmbCompany.SelectedItem as Company).Id))
                .Select(p => new
                {
                    p.Id,
                    p.Name
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

        private void SetupGrid()
        {
            dgvSales.AutoGenerateColumns = false;

            dgvSales.Columns.Clear();

            // Product Column (ComboBox with typeahead)
            var productCol = new DataGridViewComboBoxColumn();
            productCol.HeaderText = "Product";
            productCol.Name = "ProductId";
            productCol.DataSource = _products;
            productCol.DisplayMember = "Name";
            productCol.ValueMember = "Id";
            productCol.Width = 200;

            dgvSales.Columns.Add(productCol);

            // Qty Column
            dgvSales.Columns.Add("PackSize", "Pack Size");

            // Total Column
            dgvSales.Columns.Add("TotalPiece", "Total Piece");


            dgvSales.Columns.Add("OrderCarton", "Order Carton");

            dgvSales.Columns.Add("OrderPiece", "Order Piece");
            // Price Column
            dgvSales.Columns.Add("TotalAmount", "Total Amount");

            //// Price Column
            //dgvSales.Columns.Add("ReturnOrderCarton", "Return Order Carton");

            //dgvSales.Columns.Add("ReturnOrderPiece", "Return Order Piece");

            //// Total Column
            //dgvSales.Columns.Add("ReturnTotalPiece", "Return Total Piece");
        }

        private void dgvSales_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvSales.CurrentCell.ColumnIndex == 0) // Product column
            {
                ComboBox cmb = e.Control as ComboBox;

                if (cmb != null)
                {
                    cmb.DropDownStyle = ComboBoxStyle.DropDown;

                    cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cmb.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
            }

            if (dgvSales.CurrentCell.ColumnIndex == 2) // Product column
            {

            }
        }


        private bool _isUpdating = false;
        private void dgvSales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (_isUpdating) return;

            if (e.ColumnIndex == dgvSales.Columns["ProductId"].Index)
            {
                var value = dgvSales.Rows[e.RowIndex].Cells["ProductId"].Value;

                int count = dgvSales.Rows.Cast<DataGridViewRow>()
                    .Count(r => !r.IsNewRow &&
                                Equals(r.Cells["ProductId"].Value, value));

                if (count > 1)
                {
                    MessageBox.Show("Product already selected.");

                    _isUpdating = true;
                    dgvSales.Rows[e.RowIndex].Cells["ProductId"].Value = null;
                    _isUpdating = false;

                    return;
                }
            }

            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var cell = dgvSales.Rows[e.RowIndex].Cells["ProductId"];

                if (cell.Value != null)
                {
                    int productId = Convert.ToInt32(cell.Value);

                    var product = _products.FirstOrDefault(x => x.Id == productId);

                    if (product != null)
                    {
                        AppDbContext db = new AppDbContext();
                        var pkg = db.Packages.Where(c => c.Id == product.PackageId).FirstOrDefault();
                        dgvSales.Rows[e.RowIndex].Cells["PackSize"].Value = pkg.PackageName;

                        //RecalculateRow(e.RowIndex);
                    }
                }
            }

            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                var cellProduct = dgvSales.Rows[e.RowIndex].Cells["ProductId"];
                var cell = dgvSales.Rows[e.RowIndex].Cells["TotalPiece"];

                if (cell.Value != null && cellProduct.Value != null)
                {
                    int productId = Convert.ToInt32(cellProduct.Value);

                    var product = _products.FirstOrDefault(x => x.Id == productId);

                    if (product != null)
                    {
                        var totalPiece = Convert.ToInt32(cell.Value);
                        AppDbContext db = new AppDbContext();
                        var pkg = db.Packages.Where(c => c.Id == product.PackageId).FirstOrDefault();
                        dgvSales.Rows[e.RowIndex].Cells["OrderCarton"].Value = Convert.ToInt32(totalPiece / pkg.TotalPiece);
                        dgvSales.Rows[e.RowIndex].Cells["OrderPiece"].Value = totalPiece % pkg.TotalPiece;
                        dgvSales.Rows[e.RowIndex].Cells["TotalAmount"].Value = product.UnitPrice * totalPiece;
                    }
                }
            }
        }

        private void dgvSales_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                RecalculateRow(e.RowIndex);
            }
        }

        private void RecalculateRow(int rowIndex)
        {
            var row = dgvSales.Rows[rowIndex];

            if (decimal.TryParse(row.Cells["Qty"].Value?.ToString(), out decimal qty) &&
                decimal.TryParse(row.Cells["Price"].Value?.ToString(), out decimal price))
            {
                row.Cells["Total"].Value = qty * price;
            }
        }

        private string GenerateInvoicePDF()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "Invoice_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf");

            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

            doc.Open();

            // 🧾 Title
            var title1 = new Paragraph("Sadat Distribution",
               FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
            title1.Alignment = Element.ALIGN_CENTER;
            doc.Add(title1);
            var title = new Paragraph("INVOICE\n",
                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14));
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

            doc.Add(new Paragraph("SO: " + cmbSO.Text.ToString()));
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("Date: " + dateTimePicker1.Value.ToString("dd-MM-yyyy")));
            doc.Add(new Paragraph("\n"));

            // 📊 Table
            PdfPTable table = new PdfPTable(dgvSales.Columns.Count);
            table.WidthPercentage = 100;

            // Header
            foreach (DataGridViewColumn column in dgvSales.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = BaseColor.YELLOW;

                table.AddCell(cell);
            }

            // Rows
            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex == 0)
                        {
                            var productId = cell.Value;
                            var product = _products.FirstOrDefault(x => x.Id == (int)productId);
                            table.AddCell(product?.Name ?? "");
                        }
                        else
                        {
                            table.AddCell(cell.Value?.ToString() ?? "");
                        }

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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string pdfPath = GenerateInvoicePDF();

            PrintPDF(pdfPath);

            MessageBox.Show("Invoice printed successfully!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int companyId = Convert.ToInt32(cmbCompany.SelectedValue);
            int soId = Convert.ToInt32(cmbSO.SelectedValue);

            if (companyId == 0)
            {
                MessageBox.Show("Please select a company.");
                return;
            }

            if (soId == 0)
            {
                MessageBox.Show("Please select a SO.");
                return;
            }
            // Rows
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ProductId", typeof(int));
            dataTable.Columns.Add("ProductName", typeof(string));
            dataTable.Columns.Add("PackageName", typeof(string));
            dataTable.Columns.Add("TotalPiece", typeof(int));
            dataTable.Columns.Add("OrderCarton", typeof(int));
            dataTable.Columns.Add("OrderPiece", typeof(int));
            dataTable.Columns.Add("TotalAmount", typeof(decimal));

            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                if (row.IsNewRow) continue;

                DataRow dr = dataTable.NewRow();
                int productId = Convert.ToInt32(row.Cells["ProductId"].Value);

                var product = _products.FirstOrDefault(x => x.Id == productId);

                dr["ProductId"] = row.Cells["ProductId"].Value ?? 0;
                dr["ProductName"] = product?.Name ?? "";
                dr["PackageName"] = row.Cells["PackSize"].Value?.ToString() ?? "";

                dr["TotalPiece"] = Convert.ToInt32(row.Cells["TotalPiece"].Value ?? 0);
                dr["OrderCarton"] = Convert.ToInt32(row.Cells["OrderCarton"].Value ?? 0);
                dr["OrderPiece"] = Convert.ToInt32(row.Cells["OrderPiece"].Value ?? 0);
                dr["TotalAmount"] = Convert.ToDecimal(row.Cells["TotalAmount"].Value ?? 0);

                dataTable.Rows.Add(dr);
            }

            using var db = new AppDbContext();

            foreach (DataRow row in dataTable.Rows)
            {
                var item = new SaleOrder
                {
                    ProductId = Convert.ToInt32(row["ProductId"]),
                    ProductName = row["ProductName"].ToString(),
                    PackageName = row["PackageName"].ToString(),
                    TotalPiece = Convert.ToInt32(row["TotalPiece"]),
                    OrderCarton = Convert.ToInt32(row["OrderCarton"]),
                    OrderPiece = Convert.ToInt32(row["OrderPiece"]),
                    SOId = Convert.ToInt32(cmbSO.SelectedValue),
                    OnDate = dateTimePicker1.Value.Date,
                    CompanyId = Convert.ToInt32(cmbCompany.SelectedValue),
                    TotalAmount = Convert.ToDecimal(row["TotalAmount"])
                };

                db.SaleOrders.Add(item);
            }

            db.SaveChanges();

            MessageBox.Show("Saved successfully!");
            btnSave.Enabled = false;
        }

        private void cmbSO_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSales.Rows.Clear();
            btnSave.Enabled = true;
        }

        private void cmbCompany_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadSOToCombo();
            LoadProducts();
        }

        private void dgvSales_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
        }
    }
}
