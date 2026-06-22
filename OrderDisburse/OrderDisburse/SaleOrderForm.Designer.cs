namespace OrderDisburse
{
    partial class SaleOrderForm
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
            dgvSales = new DataGridView();
            splitContainer1 = new SplitContainer();
            cmbCompany = new ComboBox();
            label3 = new Label();
            btnSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            btnPrint = new Button();
            label2 = new Label();
            label1 = new Label();
            cmbSO = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSales
            // 
            dgvSales.BackgroundColor = SystemColors.ControlLightLight;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Dock = DockStyle.Fill;
            dgvSales.Location = new Point(0, 0);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersWidth = 51;
            dgvSales.Size = new Size(1138, 381);
            dgvSales.TabIndex = 0;
            dgvSales.CellValidating += dgvSales_CellValidating;
            dgvSales.CellValueChanged += dgvSales_CellValueChanged;
            dgvSales.EditingControlShowing += dgvSales_EditingControlShowing;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(cmbCompany);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(btnSave);
            splitContainer1.Panel1.Controls.Add(dateTimePicker1);
            splitContainer1.Panel1.Controls.Add(btnPrint);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(cmbSO);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvSales);
            splitContainer1.Size = new Size(1138, 507);
            splitContainer1.SplitterDistance = 122;
            splitContainer1.TabIndex = 1;
            // 
            // cmbCompany
            // 
            cmbCompany.FormattingEnabled = true;
            cmbCompany.Location = new Point(111, 40);
            cmbCompany.Name = "cmbCompany";
            cmbCompany.Size = new Size(224, 28);
            cmbCompany.TabIndex = 8;
            cmbCompany.SelectedValueChanged += cmbCompany_SelectedValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 43);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 7;
            label3.Text = "Company";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(917, 43);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(694, 41);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(136, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(1032, 42);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "Print Pdf";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(633, 44);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 2;
            label2.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(354, 44);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "SO Name";
            // 
            // cmbSO
            // 
            cmbSO.FormattingEnabled = true;
            cmbSO.Location = new Point(451, 40);
            cmbSO.Name = "cmbSO";
            cmbSO.Size = new Size(151, 28);
            cmbSO.TabIndex = 0;
            cmbSO.SelectedIndexChanged += cmbSO_SelectedIndexChanged;
            // 
            // SaleOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 507);
            Controls.Add(splitContainer1);
            Name = "SaleOrderForm";
            Text = "Sale Order Form";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSales;
        private SplitContainer splitContainer1;
        private Label label2;
        private Label label1;
        private ComboBox cmbSO;
        private Button btnPrint;
        private DateTimePicker dateTimePicker1;
        private Button btnSave;
        private ComboBox cmbCompany;
        private Label label3;
    }
}