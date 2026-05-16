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
            cartonSizeUnitEntryToolStripMenuItem = new ToolStripMenuItem();
            productEntryToolStripMenuItem = new ToolStripMenuItem();
            sOEntryToolStripMenuItem = new ToolStripMenuItem();
            orderEntryToolStripMenuItem = new ToolStripMenuItem();
            listsToolStripMenuItem = new ToolStripMenuItem();
            productListToolStripMenuItem = new ToolStripMenuItem();
            sOListToolStripMenuItem = new ToolStripMenuItem();
            cartonSizeUnitListToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, entryFormsToolStripMenuItem, listsToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // entryFormsToolStripMenuItem
            // 
            entryFormsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cartonSizeUnitEntryToolStripMenuItem, productEntryToolStripMenuItem, sOEntryToolStripMenuItem, orderEntryToolStripMenuItem });
            entryFormsToolStripMenuItem.Name = "entryFormsToolStripMenuItem";
            entryFormsToolStripMenuItem.Size = new Size(100, 24);
            entryFormsToolStripMenuItem.Text = "&Entry Forms";
            // 
            // cartonSizeUnitEntryToolStripMenuItem
            // 
            cartonSizeUnitEntryToolStripMenuItem.Name = "cartonSizeUnitEntryToolStripMenuItem";
            cartonSizeUnitEntryToolStripMenuItem.Size = new Size(224, 26);
            cartonSizeUnitEntryToolStripMenuItem.Text = "Package Size Entry ";
            cartonSizeUnitEntryToolStripMenuItem.Click += cartonSizeUnitEntryToolStripMenuItem_Click;
            // 
            // productEntryToolStripMenuItem
            // 
            productEntryToolStripMenuItem.Name = "productEntryToolStripMenuItem";
            productEntryToolStripMenuItem.Size = new Size(224, 26);
            productEntryToolStripMenuItem.Text = "Product Entry";
            productEntryToolStripMenuItem.Click += productEntryToolStripMenuItem_Click;
            // 
            // sOEntryToolStripMenuItem
            // 
            sOEntryToolStripMenuItem.Name = "sOEntryToolStripMenuItem";
            sOEntryToolStripMenuItem.Size = new Size(224, 26);
            sOEntryToolStripMenuItem.Text = "SO Entry";
            sOEntryToolStripMenuItem.Click += sOEntryToolStripMenuItem_Click;
            // 
            // orderEntryToolStripMenuItem
            // 
            orderEntryToolStripMenuItem.Name = "orderEntryToolStripMenuItem";
            orderEntryToolStripMenuItem.Size = new Size(224, 26);
            orderEntryToolStripMenuItem.Text = "Order Entry";
            orderEntryToolStripMenuItem.Click += orderEntryToolStripMenuItem_Click;
            // 
            // listsToolStripMenuItem
            // 
            listsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productListToolStripMenuItem, sOListToolStripMenuItem, cartonSizeUnitListToolStripMenuItem });
            listsToolStripMenuItem.Name = "listsToolStripMenuItem";
            listsToolStripMenuItem.Size = new Size(51, 24);
            listsToolStripMenuItem.Text = "Lists";
            // 
            // productListToolStripMenuItem
            // 
            productListToolStripMenuItem.Name = "productListToolStripMenuItem";
            productListToolStripMenuItem.Size = new Size(226, 26);
            productListToolStripMenuItem.Text = "Product List";
            // 
            // sOListToolStripMenuItem
            // 
            sOListToolStripMenuItem.Name = "sOListToolStripMenuItem";
            sOListToolStripMenuItem.Size = new Size(226, 26);
            sOListToolStripMenuItem.Text = "SO List";
            // 
            // cartonSizeUnitListToolStripMenuItem
            // 
            cartonSizeUnitListToolStripMenuItem.Name = "cartonSizeUnitListToolStripMenuItem";
            cartonSizeUnitListToolStripMenuItem.Size = new Size(226, 26);
            cartonSizeUnitListToolStripMenuItem.Text = "Carton Size/Unit List";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private ToolStripMenuItem listsToolStripMenuItem;
        private ToolStripMenuItem productListToolStripMenuItem;
        private ToolStripMenuItem sOListToolStripMenuItem;
        private ToolStripMenuItem cartonSizeUnitEntryToolStripMenuItem;
        private ToolStripMenuItem cartonSizeUnitListToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
