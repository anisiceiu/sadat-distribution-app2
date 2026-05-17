namespace OrderDisburse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            entryFormsToolStripMenuItem = new ToolStripMenuItem();
            companyEntryToolStripMenuItem = new ToolStripMenuItem();
            cartonSizeUnitEntryToolStripMenuItem = new ToolStripMenuItem();
            productEntryToolStripMenuItem = new ToolStripMenuItem();
            sOEntryToolStripMenuItem = new ToolStripMenuItem();
            orderEntryToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            lblCompany = new Label();
            cmbCompany = new ComboBox();
            button1 = new Button();
            btnGo = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, entryFormsToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1191, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // entryFormsToolStripMenuItem
            // 
            entryFormsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { companyEntryToolStripMenuItem, cartonSizeUnitEntryToolStripMenuItem, productEntryToolStripMenuItem, sOEntryToolStripMenuItem, orderEntryToolStripMenuItem });
            entryFormsToolStripMenuItem.Name = "entryFormsToolStripMenuItem";
            entryFormsToolStripMenuItem.Size = new Size(100, 24);
            entryFormsToolStripMenuItem.Text = "&Entry Forms";
            // 
            // companyEntryToolStripMenuItem
            // 
            companyEntryToolStripMenuItem.Name = "companyEntryToolStripMenuItem";
            companyEntryToolStripMenuItem.Size = new Size(218, 26);
            companyEntryToolStripMenuItem.Text = "Company Entry";
            companyEntryToolStripMenuItem.Click += companyEntryToolStripMenuItem_Click;
            // 
            // cartonSizeUnitEntryToolStripMenuItem
            // 
            cartonSizeUnitEntryToolStripMenuItem.Name = "cartonSizeUnitEntryToolStripMenuItem";
            cartonSizeUnitEntryToolStripMenuItem.Size = new Size(218, 26);
            cartonSizeUnitEntryToolStripMenuItem.Text = "Package Size Entry ";
            cartonSizeUnitEntryToolStripMenuItem.Click += cartonSizeUnitEntryToolStripMenuItem_Click;
            // 
            // productEntryToolStripMenuItem
            // 
            productEntryToolStripMenuItem.Name = "productEntryToolStripMenuItem";
            productEntryToolStripMenuItem.Size = new Size(218, 26);
            productEntryToolStripMenuItem.Text = "Product Entry";
            productEntryToolStripMenuItem.Click += productEntryToolStripMenuItem_Click;
            // 
            // sOEntryToolStripMenuItem
            // 
            sOEntryToolStripMenuItem.Name = "sOEntryToolStripMenuItem";
            sOEntryToolStripMenuItem.Size = new Size(218, 26);
            sOEntryToolStripMenuItem.Text = "SO Entry";
            sOEntryToolStripMenuItem.Click += sOEntryToolStripMenuItem_Click;
            // 
            // orderEntryToolStripMenuItem
            // 
            orderEntryToolStripMenuItem.Name = "orderEntryToolStripMenuItem";
            orderEntryToolStripMenuItem.Size = new Size(218, 26);
            orderEntryToolStripMenuItem.Text = "Order Entry";
            orderEntryToolStripMenuItem.Click += orderEntryToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 28);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lblCompany);
            splitContainer1.Panel1.Controls.Add(cmbCompany);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(btnGo);
            splitContainer1.Panel1.Controls.Add(dateTimePicker2);
            splitContainer1.Panel1.Controls.Add(dateTimePicker1);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(1191, 647);
            splitContainer1.SplitterDistance = 117;
            splitContainer1.TabIndex = 1;
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Location = new Point(21, 34);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(72, 20);
            lblCompany.TabIndex = 6;
            lblCompany.Text = "Company";
            // 
            // cmbCompany
            // 
            cmbCompany.FormattingEnabled = true;
            cmbCompany.Location = new Point(99, 34);
            cmbCompany.Name = "cmbCompany";
            cmbCompany.Size = new Size(227, 28);
            cmbCompany.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(991, 31);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(855, 30);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(94, 29);
            btnGo.TabIndex = 4;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(655, 32);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(151, 27);
            dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(417, 34);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(133, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(597, 35);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 35);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1191, 526);
            dataGridView1.TabIndex = 0;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 675);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Sadat Distribution";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem entryFormsToolStripMenuItem;
        private ToolStripMenuItem productEntryToolStripMenuItem;
        private ToolStripMenuItem sOEntryToolStripMenuItem;
        private ToolStripMenuItem orderEntryToolStripMenuItem;
        private ToolStripMenuItem cartonSizeUnitEntryToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private SplitContainer splitContainer1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private Button btnGo;
        private DataGridView dataGridView1;
        private Button button1;
        private Label lblCompany;
        private ComboBox cmbCompany;
        private ToolStripMenuItem companyEntryToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
