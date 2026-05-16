namespace OrderDisburse
{
    partial class SOEntryForm
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
            txtSOContactNo = new TextBox();
            btnSave = new Button();
            txtSOName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvSOs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSOs).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(txtSOContactNo);
            splitContainer1.Panel1.Controls.Add(btnSave);
            splitContainer1.Panel1.Controls.Add(txtSOName);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvSOs);
            splitContainer1.Size = new Size(1047, 450);
            splitContainer1.SplitterDistance = 349;
            splitContainer1.TabIndex = 17;
            // 
            // txtSOContactNo
            // 
            txtSOContactNo.Location = new Point(142, 73);
            txtSOContactNo.Name = "txtSOContactNo";
            txtSOContactNo.Size = new Size(173, 27);
            txtSOContactNo.TabIndex = 23;
            txtSOContactNo.TextChanged += textBox1_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(221, 127);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // txtSOName
            // 
            txtSOName.Location = new Point(142, 30);
            txtSOName.Name = "txtSOName";
            txtSOName.Size = new Size(173, 27);
            txtSOName.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 73);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 17;
            label2.Text = "Contact No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 16;
            label1.Text = "SO Name";
            // 
            // dgvSOs
            // 
            dgvSOs.AllowUserToAddRows = false;
            dgvSOs.AllowUserToDeleteRows = false;
            dgvSOs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSOs.Dock = DockStyle.Fill;
            dgvSOs.Location = new Point(0, 0);
            dgvSOs.Name = "dgvSOs";
            dgvSOs.ReadOnly = true;
            dgvSOs.RowHeadersWidth = 51;
            dgvSOs.Size = new Size(694, 450);
            dgvSOs.TabIndex = 7;
            // 
            // SOEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 450);
            Controls.Add(splitContainer1);
            Name = "SOEntryForm";
            Text = "SO Entry Form";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSOs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnSave;

        public TextBox txtContactNo { get; private set; }

        private TextBox txtPiecePerPack;
        private TextBox txtPackCount;
        private TextBox txtSOName;
        private Label label2;
        private Label label1;
        private DataGridView dgvSOs;
        private TextBox txtSOContactNo;
    }
}