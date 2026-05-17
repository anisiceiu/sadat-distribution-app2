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
    public partial class CompanyEntryForm : Form
    {
        public CompanyEntryForm()
        {
            InitializeComponent();
            LoadCompanies();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppDbContext dbContext = new AppDbContext();
            Company company = new Company();
            company.CompanyName = txtCompany.Text;
            bool exists = dbContext.Companies
                .Any(x => x.CompanyName.ToLower() == company.CompanyName.ToLower());

            if (exists)
            {
                MessageBox.Show("Company already exists");
                return;
            }

            dbContext.Add(company);
            dbContext.SaveChanges();
            LoadCompanies();
        }

        public void LoadCompanies()
        {
            using var db = new AppDbContext();

            dgvCompany.DataSource = db.Companies.ToList();
            
        }
    }
}
