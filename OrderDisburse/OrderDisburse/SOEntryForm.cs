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
    public partial class SOEntryForm : Form
    {
        public SOEntryForm()
        {
            InitializeComponent();
            LoadSOs();
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void ClearForm()
        {
            txtSOName.Clear();
            txtSOContactNo.Clear();
        }

        public void LoadSOs()
        {
            using var db = new AppDbContext();

            dgvSOs.DataSource = db.SOs.ToList();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            string soname = txtSOName.Text.Trim();

            if (string.IsNullOrWhiteSpace(soname))
            {
                MessageBox.Show("SO name is required");
                return;
            }

            if (Convert.ToInt32(cmbCompany.SelectedValue) == 0)
            {
                MessageBox.Show("Company name is required");
                return;
            }

            bool exists = db.SOs
                .Any(x => x.Name.ToLower() == soname.ToLower());

            if (exists)
            {
                MessageBox.Show("SO already exists");
                return;
            }

            var so = new SO
            {
                Name = soname,
                ContactNo = txtSOContactNo.Text.Trim(),
                CompanyId = Convert.ToInt32(cmbCompany.SelectedValue)
            };

            db.SOs.Add(so);

            db.SaveChanges();

            LoadSOs();

            ClearForm();

            MessageBox.Show("Saved Successfully");

        }
    }
}
