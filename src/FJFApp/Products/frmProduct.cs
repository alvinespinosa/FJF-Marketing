using FJFApp.Model.Products;
using System;
using System.Windows.Forms;

namespace FJFApp.Products
{
    public partial class frmProduct : Form
    {
        public Product product { get; set; }
        public bool isCancelled { get; set; }

        public frmProduct(Product product, string section = null)
        {
            InitializeComponent();

            if (product != null)
            {
                this.Text = product.Id.ToString().ToUpper();
                this.product = product;
                LoadProductDetails();
            }
            else
            {
                this.Text = "New Product";
                chkActive.Enabled = false;
                txtSection.Text = section;
            }
        }

        #region Event(s)
        private void tsBtnCancel_Click(object sender, System.EventArgs e)
        {
            var selected = MessageBox.Show("Are you sure to cancel?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (selected == DialogResult.Yes)
            {
                this.isCancelled = true;
                this.Close();
            }
        }
        private void tsBtnSave_Click(object sender, System.EventArgs e)
        {
            var selected = MessageBox.Show("Are you sure to save?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (selected == DialogResult.Yes)
            {
                this.product = new Product();
                this.product.Id = this.Text == "New Product" ? Guid.NewGuid() : this.product.Id;
                this.product.Section = txtSection.Text;
                this.product.Category = cboCategory.Text;
                this.product.Item = txtItem.Text.Trim().Replace("'","''");
                this.product.Unit = txtUnit.Text;
                this.product.Price = numCost.Value;
                this.product.Fare = numFare.Value;
                this.product.Srp = numSRP.Value;
                this.product.Notes = txtNotes.Text.Trim().Replace("'","''");
                this.product.Active = chkActive.Checked;
                this.isCancelled = false;
                this.Close();
            }
        }
        #endregion

        #region Private Method(s)

        private void LoadProductDetails()
        {
            txtSection.Text = this.product.Section;
            cboCategory.Text = this.product.Category;
            txtItem.Text = this.product.Item;
            txtUnit.Text = this.product.Unit;
            numCost.Value = this.product.Price;
            numFare.Value = this.product.Fare;
            numSRP.Value = this.product.Srp;
            txtTotalCost.Text = this.product.TotalCost().ToString("#,##0.00");
            txtNotes.Text = this.product.Notes;
            chkActive.Checked = this.product.Active;
        }

        #endregion

       
    }
}
