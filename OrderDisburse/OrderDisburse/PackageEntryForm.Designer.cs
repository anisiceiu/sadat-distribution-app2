namespace OrderDisburse
{
    partial class PackageEntryForm
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
            dgvPackages = new DataGridView();
            splitContainer1 = new SplitContainer();
            btnSave = new Button();
            txtPiecePerPack = new TextBox();
            txtPackCount = new TextBox();
            txtPacageName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPackages
            // 
            dgvPackages.AllowUserToAddRows = false;
            dgvPackages.AllowUserToDeleteRows = false;
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Dock = DockStyle.Fill;
            dgvPackages.Location = new Point(0, 0);
            dgvPackages.Name = "dgvPackages";
            dgvPackages.ReadOnly = true;
            dgvPackages.RowHeadersWidth = 51;
            dgvPackages.Size = new Size(701, 450);
            dgvPackages.TabIndex = 7;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnSave);
            splitContainer1.Panel1.Controls.Add(txtPiecePerPack);
            splitContainer1.Panel1.Controls.Add(txtPackCount);
            splitContainer1.Panel1.Controls.Add(txtPacageName);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvPackages);
            splitContainer1.Size = new Size(1057, 450);
            splitContainer1.SplitterDistance = 352;
            splitContainer1.TabIndex = 16;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(232, 286);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // txtPiecePerPack
            // 
            txtPiecePerPack.Location = new Point(201, 225);
            txtPiecePerPack.Name = "txtPiecePerPack";
            txtPiecePerPack.Size = new Size(125, 27);
            txtPiecePerPack.TabIndex = 21;
            // 
            // txtPackCount
            // 
            txtPackCount.Location = new Point(201, 178);
            txtPackCount.Name = "txtPackCount";
            txtPackCount.Size = new Size(125, 27);
            txtPackCount.TabIndex = 20;
            // 
            // txtPacageName
            // 
            txtPacageName.Location = new Point(201, 135);
            txtPacageName.Name = "txtPacageName";
            txtPacageName.Size = new Size(125, 27);
            txtPacageName.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 225);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 18;
            label3.Text = "Piece Per Pack";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 178);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 17;
            label2.Text = "Pack Count";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 135);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 16;
            label1.Text = "Package Name";
            // 
            // PackageEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 450);
            Controls.Add(splitContainer1);
            Name = "PackageEntryForm";
            Text = "PackageEntryForm";
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPackages;
        private SplitContainer splitContainer1;
        private Button btnSave;
        private TextBox txtPiecePerPack;
        private TextBox txtPackCount;
        private TextBox txtPacageName;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}