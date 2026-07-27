using Microsoft.EntityFrameworkCore;
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
    public partial class EditProductForm : Form
    {
        public EditProductForm()
        {
            InitializeComponent();
        }

        private List<Product> products;

        private void LoadProducts()
        {
            using var db = new AppDbContext();
            int companyId = Convert.ToInt32(cmbCompany.SelectedValue);


            products = db.Products.Where(p => p.CompanyId == companyId).ToList();

            dgvProducts.DataSource = products;


            dgvProducts.Columns["Id"].ReadOnly = true;
            dgvProducts.Columns["PackageId"].Visible = false;
            dgvProducts.Columns["CompanyId"].Visible = false;
            dgvProducts.Columns["Name"].ReadOnly = true;
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            LoadCompanyCombo();
            LoadProducts();
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

        private void cmbCompany_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            foreach (var product in products)
            {
                db.Products.Update(product);
            }

            db.SaveChanges();

            MessageBox.Show("Saved Successfully.");
        }
    }
}
