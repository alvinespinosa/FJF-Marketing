using FJFApp.Common;
using FJFApp.Model.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FJFApp.Payables
{
    public partial class frmPayable : Form
    {
        public bool IsCancelled { get; private set; }
        private List<Product> Products { get; set; }
        public Payable _Payable { get; private set; }

        public frmPayable(Payable payable)
        {
            InitializeComponent();
            InitializeCustomComponents(payable);
        }

        #region Event(s)
        private void TsBtnSave_Click(object sender, System.EventArgs e)
        {
            if (ChkPaid.Checked && 
                MessageBox.Show("Are you sure to mark this as Paid?", "Confirmation", 
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            this.IsCancelled = false;
            this._Payable = new Payable
            {
                Id = Guid.NewGuid(),
                IsPaid = ChkPaid.Checked,
                Notes = txtNotes.Text.Trim().Replace("'","''"),
                PaymentTerms = CboPayTerms.SelectedIndex + 1,
                PurchaseDate = dtPicker.Value,
                NotificationDays = (int)numNotifyDays.Value,
            };

            for (var row = 0; dataGridView.Rows.Count > row; row++)
            {
                this._Payable.Items.Add(
                new PurchaseItem
                {
                    Item = dataGridView[1, row].Value.ToString(),
                    Price = decimal.Parse(dataGridView[2, row].Value.ToString()),
                    Qty = int.Parse(dataGridView[3, row].Value.ToString())
                });
            };

            this.Close();
        }

        private void TsBtnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            dataGridView.Rows.Add(
                "",
                CboItems.Text,
                LblPrice.Text,
                NumQty.Value,
                LblTotal.Text,
                "remove");

            LblAmount.Text = (decimal.Parse(LblAmount.Text) + decimal.Parse(LblTotal.Text)).ToString("#,##0.00");
        }

        private void DtPicker_ValueChanged(object sender, System.EventArgs e)
        {
            var dueDate = dtPicker.Value.AddMonths(CboPayTerms.SelectedIndex + 1);
            LblDueDate.Text = dueDate.ToShortDateString();
        }
        private void CboItems_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var product = this.Products.SingleOrDefault(_ => _.Item == CboItems.Text);
            if (product != null)
            {
                LblPrice.Text = product.Price.ToString("#,##0.00");
                LblTotal.Text = (product.Price * NumQty.Value).ToString("#,##0.00");
            }
        }

        private void NumQty_ValueChanged(object sender, System.EventArgs e)
        {
            LblTotal.Text = (decimal.Parse(LblPrice.Text) * NumQty.Value).ToString("#,##0.00");
        }
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[5] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var amount = decimal.Parse(LblAmount.Text);
                var total = decimal.Parse(dataGridView[4, e.RowIndex].Value.ToString());
                LblAmount.Text = (amount - total).ToString("#,##0.00");
                dataGridView.Rows.RemoveAt(e.RowIndex);
            }
        }
        private void CboPayTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblDueDate.Text = dtPicker.Value.AddMonths(CboPayTerms.SelectedIndex + 1).ToShortDateString();
        }
        #endregion

        #region Private Method(s)
        private void InitializeCustomComponents(Payable payable)
        {
            this.IsCancelled = true;

            dataGridView.Columns.Add(Utility.DataGridView.Column("Guid", 50, true));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Item", 250));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Unit Price", 50));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Quantity", 50));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Total", 50));
            dataGridView.Columns.Add(Utility.DataGridView.ButtonColumn());

            CboPayTerms.SelectedIndex = 0;

            this.Products = MockData.Products();

            foreach (var product in this.Products)
            {
                CboItems.Items.Add(product.Item);
            }
            CboItems.SelectedIndex = 0;

            // When open details
            if (payable != null)
            {
                foreach (var item in payable.Items)
                {
                    dataGridView.Rows.Add(
                       "",
                       item.Item,
                       item.Price.ToString("#,##0.00"),
                       item.Qty,
                       item.GetTotal().ToString("#,##0.00"),
                       "remove");
                }
                LblAmount.Text = payable.GetAmount().ToString("#,##0.00");
                dtPicker.Value = payable.PurchaseDate;
                LblDueDate.Text = payable.PurchaseDate.AddMonths(payable.PaymentTerms).ToShortDateString();
                CboPayTerms.SelectedIndex = payable.PaymentTerms - 1;
                numNotifyDays.Value = payable.NotificationDays;
                txtNotes.Text = payable.Notes;
                ChkPaid.Checked = payable.IsPaid;
            }
            else
            {
                this._Payable = new Payable();
            }
        }
        #endregion        
    }
}
