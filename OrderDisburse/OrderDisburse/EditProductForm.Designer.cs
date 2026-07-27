namespace OrderDisburse
{
    partial class EditProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProducts = new DataGridView();
            splitContainer1 = new SplitContainer();
            btnSaveAll = new Button();
            cmbCompany = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 0);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(824, 750);
            dgvProducts.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnSaveAll);
            splitContainer1.Panel1.Controls.Add(cmbCompany);
            splitContainer1.Panel1.Controls.Add(label3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvProducts);
            splitContainer1.Size = new Size(1239, 750);
            splitContainer1.SplitterDistance = 411;
            splitContainer1.TabIndex = 1;
            // 
            // btnSaveAll
            // 
            btnSaveAll.Location = new Point(12, 114);
            btnSaveAll.Name = "btnSaveAll";
            btnSaveAll.Size = new Size(384, 59);
            btnSaveAll.TabIndex = 28;
            btnSaveAll.Text = "Save All";
            btnSaveAll.UseVisualStyleBackColor = true;
            btnSaveAll.Click += btnSaveAll_Click;
            // 
            // cmbCompany
            // 
            cmbCompany.DisplayMember = "Id";
            cmbCompany.FormattingEnabled = true;
            cmbCompany.Location = new Point(130, 40);
            cmbCompany.Name = "cmbCompany";
            cmbCompany.Size = new Size(266, 28);
            cmbCompany.TabIndex = 27;
            cmbCompany.ValueMember = "Id";
            cmbCompany.SelectedValueChanged += cmbCompany_SelectedValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 40);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 26;
            label3.Text = "Company Name";
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 750);
            Controls.Add(splitContainer1);
            Name = "EditProductForm";
            Text = "EditProductForm";
            Load += EditProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducts;
        private SplitContainer splitContainer1;
        private ComboBox cmbCompany;
        private Label label3;
        private Button btnSaveAll;
    }
}