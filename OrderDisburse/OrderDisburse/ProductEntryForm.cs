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

namespace OrderDisburse
{
    public partial class ProductEntryForm : Form
    {
        public ProductEntryForm()
        {
            InitializeComponent();
            LoadPackagesToCombo();
            LoadProducts();
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
        private void LoadPackagesToCombo()
        {
            using var db = new AppDbContext();

            var packages = db.Packages
                .Select(p => new
                {
                    p.Id,
                    p.PackageName
                })
                .ToList();

            cmbPackage.DataSource = packages;
            cmbPackage.DisplayMember = "PackageName";
            cmbPackage.ValueMember = "Id";


            // Enable typeahead
            cmbPackage.DropDownStyle = ComboBoxStyle.DropDown;
            cmbPackage.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPackage.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            string productName = txtProductName.Text.Trim();

            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Product name is required");
                return;
            }


            var company = cmbCompany.SelectedItem as Company;

            if (string.IsNullOrWhiteSpace(company?.CompanyName))
            {
                MessageBox.Show("Company name is required");
                return;
            }


            if (Convert.ToInt32(cmbPackage.SelectedValue) == 0)
            {
                MessageBox.Show("Package name is required");
                return;
            }


            bool exists = db.Products
                .Any(x => x.Name.ToLower() == productName.ToLower());

            if (exists)
            {
                MessageBox.Show("Product already exists");
                return;
            }

            var product = new Product
            {
                Name = productName,
                PackageId = Convert.ToInt32(cmbPackage.SelectedValue),
                CompanyId = Convert.ToInt32(cmbCompany.SelectedValue) 

            };



            db.Products.Add(product);

            db.SaveChanges();

            LoadProducts();

            ClearForm();

            MessageBox.Show("Saved Successfully");

        }

        private void ClearForm()
        {
            txtProductName.Clear();
        }

        public void LoadProducts()
        {
            using var db = new AppDbContext();

            dgvProducts.DataSource = db.Products.ToList();

            if (!dgvProducts.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Delete";
                btnDelete.HeaderText = "Action";
                btnDelete.Text = "Delete";
                btnDelete.UseColumnTextForButtonValue = true;

                dgvProducts.Columns.Add(btnDelete);
                dgvProducts.CellClick += DgvProducts_CellClick;
            }
        }

        private void DgvProducts_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProducts.Columns[e.ColumnIndex].Name == "Delete")
            {

                DialogResult result = MessageBox.Show(
                 "Are you sure want to delete the product?",
                 "Delete",
                 MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    
                    var item = (Product)dgvProducts.Rows[e.RowIndex].DataBoundItem;

                    AppDbContext context = new AppDbContext();
                    context.Products.Remove(item);
                    context.SaveChanges();

                    LoadProducts();

                    MessageBox.Show("Product Deleted successfully");
                }
            }
        }
    }
}
