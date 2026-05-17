namespace OrderDisburse
{
    partial class ProductEntryForm
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            cmbPackage = new ComboBox();
            btnSave = new Button();
            txtProductName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvProducts = new DataGridView();
            packageBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)packageBindingSource).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(cmbPackage);
            splitContainer1.Panel1.Controls.Add(btnSave);
            splitContainer1.Panel1.Controls.Add(txtProductName);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvProducts);
            splitContainer1.Size = new Size(1035, 604);
            splitContainer1.SplitterDistance = 436;
            splitContainer1.TabIndex = 17;
            // 
            // cmbPackage
            // 
            cmbPackage.DisplayMember = "Id";
            cmbPackage.FormattingEnabled = true;
            cmbPackage.Location = new Point(134, 72);
            cmbPackage.Name = "cmbPackage";
            cmbPackage.Size = new Size(151, 28);
            cmbPackage.TabIndex = 23;
            cmbPackage.ValueMember = "Id";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(306, 123);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(134, 32);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(266, 27);
            txtProductName.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 75);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 17;
            label2.Text = "Package";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 16;
            label1.Text = "Product Name";
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.BackgroundColor = SystemColors.ControlLightLight;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 0);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(595, 604);
            dgvProducts.TabIndex = 7;
            // 
            // packageBindingSource
            // 
            packageBindingSource.DataSource = typeof(Models.Package);
            // 
            // ProductEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 604);
            Controls.Add(splitContainer1);
            Name = "ProductEntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Entry Form";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)packageBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnSave;
        private TextBox txtProductName;
        private Label label2;
        private Label label1;
        private DataGridView dgvProducts;
        private ComboBox cmbPackage;
        private BindingSource packageBindingSource;
    }
}