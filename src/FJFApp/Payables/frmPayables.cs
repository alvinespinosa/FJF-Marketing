using FJFApp.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FJFApp.Payables
{
    public partial class frmPayables : Form
    {
        private readonly List<Payable> _payables;

        public frmPayables()
        {
            InitializeComponent();
            this._payables = new List<Payable>();
            InitializeCustomComponents();
        }

        #region Event(s)
        private void FrmPayables_Resize(object sender, EventArgs e)
        {
            groupBox.Height = this.Height - 55;
            dataGridView.Height = this.Height - 80;
            dataGridView.Width = this.Width - 210;
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            var form = new frmPayable(null);
            form.ShowDialog();
            if (!form.IsCancelled)
            {
                this._payables.Add(form._Payable);
                Filter();
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (this._payables.Count == 0)
                this.GetPayables();

            Filter();
        }
        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            OpenDetails();
        }
        #endregion

        #region Private Method(s)
        private void InitializeCustomComponents()
        {
            dataGridView.Columns.Add(Utility.DataGridView.Column("Guid", 50, true));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Purchase Date", 150));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Payment Terms", 150));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Amount", 150));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Due Date", 150));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Notes", 250));
        }
        private void GetPayables()
        {
            this._payables.AddRange(MockData.Payables());
        }
        private void Filter()
        {
            dataGridView.Rows.Clear();
            var payables = new List<Payable>();

            if (Chk30.Checked && Chk60.Checked)
            {
                payables = this._payables.Where(_ => _.IsPaid == false).ToList();
            }
            else if (Chk30.Checked)
            {
                payables = this._payables.Where(_ => _.IsPaid == false && _.PaymentTerms == 1).ToList();
            }
            else if (Chk60.Checked)
            {
                payables = this._payables.Where(_ => _.IsPaid == false && _.PaymentTerms == 2).ToList();
            }

            foreach (var payable in payables)
            {
                dataGridView.Rows.Add(
                    payable.Id,
                    payable.PurchaseDate.ToShortDateString(),
                    payable.PaymentTerms == 1 ? "30 Days": "60 Days",
                    payable.GetAmount().ToString("#,##0.00"),
                    payable.PurchaseDate.AddMonths(payable.PaymentTerms == 1 ? 1 : 2).ToString("MMM dd, yyyy"),
                    payable.Notes);

                if(DateTime.Now.Date >= payable.PurchaseDate.AddMonths(payable.PaymentTerms).AddDays( 0 - payable.NotificationDays))
                for (var col = 0; 5 >= col; col++)
                {
                        dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[col].Style.ForeColor = Color.Red;
                }
            }
        }
        private void OpenDetails()
        {
            if (dataGridView.Rows.Count < 1)
                return;

            var selectedTransaction = dataGridView.SelectedRows[0].Cells[0].Value;

            var payable = this._payables
                .SingleOrDefault(_ => _.Id == Guid.Parse(selectedTransaction.ToString()));

            var form = new frmPayable(payable);
            form.ShowDialog();
            if (!form.IsCancelled)
            {
                dataGridView.SelectedRows[0].Cells[1].Value = form._Payable.PurchaseDate.ToShortDateString();
                dataGridView.SelectedRows[0].Cells[2].Value = form._Payable.PaymentTerms == 1 ? "30 Days" : "60 Days";
                dataGridView.SelectedRows[0].Cells[3].Value = form._Payable.GetAmount().ToString("#,##0.00");
                dataGridView.SelectedRows[0].Cells[4].Value = form._Payable.PurchaseDate.AddMonths(form._Payable.PaymentTerms).ToShortDateString();
                dataGridView.SelectedRows[0].Cells[5].Value = form._Payable.Notes;

                this._payables.Remove(payable);
                this._payables.Add(form._Payable);
                Filter();
            }
        }
        #endregion
    }
}
