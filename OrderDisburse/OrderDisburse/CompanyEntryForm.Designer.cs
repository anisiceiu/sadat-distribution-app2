namespace OrderDisburse
{
    partial class CompanyEntryForm
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
            splitContainer1 = new SplitContainer();
            btnSave = new Button();
            txtCompany = new TextBox();
            label1 = new Label();
            dgvCompany = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompany).BeginInit();
            SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(btnSave);
            splitContainer1.Panel1.Controls.Add(txtCompany);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvCompany);
            splitContainer1.Size = new Size(590, 381);
            splitContainer1.SplitterDistance = 103;
            splitContainer1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(466, 33);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(144, 33);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(292, 27);
            txtCompany.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Company Name";
            // 
            // dgvCompany
            // 
            dgvCompany.AllowUserToAddRows = false;
            dgvCompany.AllowUserToDeleteRows = false;
            dgvCompany.BackgroundColor = SystemColors.ControlLightLight;
            dgvCompany.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompany.Dock = DockStyle.Fill;
            dgvCompany.Location = new Point(0, 0);
            dgvCompany.Name = "dgvCompany";
            dgvCompany.ReadOnly = true;
            dgvCompany.RowHeadersWidth = 51;
            dgvCompany.Size = new Size(590, 274);
            dgvCompany.TabIndex = 0;
            // 
            // CompanyEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 381);
            Controls.Add(splitContainer1);
            Name = "CompanyEntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company Entry Form";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCompany).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private TextBox txtCompany;
        private DataGridView dgvCompany;
        private Button btnSave;
    }
}