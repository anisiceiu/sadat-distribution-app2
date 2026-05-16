namespace OrderDisburse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cartonSizeUnitEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PackageEntryForm packageEntryForm = new PackageEntryForm();
            packageEntryForm.ShowDialog();
        }

        private void productEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductEntryForm productEntryForm = new ProductEntryForm();
            productEntryForm.ShowDialog();
        }

        private void sOEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SOEntryForm SOEntryForm = new SOEntryForm();
            SOEntryForm.ShowDialog();
        }

        private void orderEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleOrderForm saleOrder = new SaleOrderForm();
            saleOrder.ShowDialog();


        }
    }
}
