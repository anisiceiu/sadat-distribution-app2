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

            

            bool exists = db.Products
                .Any(x => x.Name.ToLower() == productName.ToLower());

            if (exists)
            {
                MessageBox.Show("Package already exists");
                return;
            }

            var product = new Product
            {
                Name = productName,
                PackageId = Convert.ToInt32(cmbPackage.SelectedValue)
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
        }
    }
}
