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
    public partial class PackageEntryForm : Form
    {
        public PackageEntryForm()
        {

            InitializeComponent();
            LoadPackages();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
        }

        private void ClearForm()
        {
            txtPacageName.Clear();
            txtPackCount.Clear();
            txtPiecePerPack.Clear();
        }

        public void LoadPackages()
        {
            using var db = new AppDbContext();

            dgvPackages.DataSource = db.Packages.ToList();
            // Prevent duplicate columns
            //if (!dgvPackages.Columns.Contains("Delete"))
            //{
            //    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

            //    btn.Name = "Delete";
            //    btn.HeaderText = "Action";
            //    btn.Text = "Delete";
            //    btn.DefaultCellStyle.ForeColor = Color.Red;
            //    btn.UseColumnTextForButtonValue = true;

            //    dgvPackages.Columns.Add(btn);
            //}
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            string packageName = txtPacageName.Text.Trim();

            if (string.IsNullOrWhiteSpace(packageName))
            {
                MessageBox.Show("Package name is required");
                return;
            }

            if (!int.TryParse(txtPackCount.Text, out int packCount))
            {
                MessageBox.Show("Invalid pack count");
                return;
            }

            if (!int.TryParse(txtPiecePerPack.Text, out int piecePerPack))
            {
                MessageBox.Show("Invalid piece per pack");
                return;
            }

            bool exists = db.Packages
                .Any(x => x.PackageName.ToLower() == packageName.ToLower());

            if (exists)
            {
                MessageBox.Show("Package already exists");
                return;
            }

            var package = new Package
            {
                PackageName = packageName,
                PackCount = packCount,
                PiecePerPack = piecePerPack,
                TotalPiece = packCount * piecePerPack
            };

            db.Packages.Add(package);

            db.SaveChanges();

            LoadPackages();

            ClearForm();

            MessageBox.Show("Saved Successfully");

        }
    }
}
