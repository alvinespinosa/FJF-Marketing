using FJFApp.Common;
using FJFApp.Common.Forms;
using FJFApp.Constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FJFApp.IncomeExpenses
{
    public partial class frmTransactions : Form
    {
        private readonly List<Transaction> _transactions;

        public frmTransactions()
        {
            InitializeComponent();
            this._transactions = new List<Transaction>();
            InitializeCustomComponents();
        }

        #region Event(s)   
        private void FrmTransactions_Resize(object sender, EventArgs e)
        {
            groupBox.Height = this.Height - 55;
            dataGridView.Height = this.Height - 80;
            dataGridView.Width = this.Width - 210;
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            var formDate = new frmDate();
            formDate.ShowDialog();

            if (!formDate.IsCancelled)
            {
                var transaction = new Transaction
                {
                    Id= Guid.NewGuid(),
                    Date = formDate.Date
                };

                var form = new frmIncomeExpense(transaction);
                form.ShowDialog();
                if (!form.isCancelled)
                {
                    //Check if date is exists
                    var data = this._transactions.SingleOrDefault(_ =>
                        _.Date.Year == form.Transaction.Date.Year &&
                        _.Date.Month == form.Transaction.Date.Month &&
                        _.Date.Day == form.Transaction.Date.Day);

                    if (data == null)
                    {
                        this._transactions.Add(form.Transaction);
                        Filter();
                    }
                    else
                    {
                        MessageBox.Show(ErrorMessages.DateIsAlreadyExists);
                    }
                }
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (this._transactions.Count == 0)
                this.GetTransactions();

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
            dataGridView.Columns.Add(Utility.DataGridView.Column("Date", 100));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Beginning Bal.", 100));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Ending Bal.", 100));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Income", 100));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Expenses", 100));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Profit", 100));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Notes", 250));

            for (var y = 2019; y <= DateTime.Now.Year; y++)
            {
                CboYear.Items.Add(y);
            }
            CboYear.SelectedIndex = 0;
            CboMonth.SelectedIndex = DateTime.Now.Month - 1;
        }
        private void Filter()
        {
            try
            {
                dataGridView.Rows.Clear();
                foreach (var transaction in this._transactions
                    .Where(_ => _.Date.Year == int.Parse(CboYear.Text) && _.Date.Month == CboMonth.SelectedIndex + 1)
                    .OrderBy(_ => _.Date).ToList())
                {
                    dataGridView.Rows.Add(
                        transaction.Id,
                        transaction.Date.ToShortDateString(),
                        transaction.BeginningBalance.ToString("#,##0.00"),
                        transaction.EndingBalance.ToString("#,##0.00"),
                        transaction.GetTotalIncome().ToString("#,##0.00"),
                        transaction.GetTotalExpense().ToString("#,##0.00"),
                        transaction.Profit.ToString("#,##0.00"),
                        transaction.Notes);

                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[6].Style.ForeColor = 
                        transaction.Profit < 0 ? Color.Red : Color.Black;

                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[3].Style.ForeColor =
                        transaction.EndingBalance < 0 ? Color.Red : Color.Black;
                };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void OpenDetails()
        {
            if (dataGridView.Rows.Count < 1)
                return;

            var selectedTransaction = dataGridView.SelectedRows[0].Cells[0].Value;

            var transactions = this._transactions
                .SingleOrDefault(_ => _.Id == Guid.Parse(selectedTransaction.ToString()));

            var form = new frmIncomeExpense(transactions);
            form.ShowDialog();
            if (!form.isCancelled)
            {
                dataGridView.SelectedRows[0].Cells[2].Value = form.Transaction.BeginningBalance.ToString("#,##0.00");
                dataGridView.SelectedRows[0].Cells[3].Value = form.Transaction.EndingBalance.ToString("#,##0.00");
                dataGridView.SelectedRows[0].Cells[4].Value = form.Transaction.GetTotalIncome().ToString("#,##0.00");
                dataGridView.SelectedRows[0].Cells[5].Value = form.Transaction.GetTotalExpense().ToString("#,##0.00");
                dataGridView.SelectedRows[0].Cells[6].Value = form.Transaction.Profit.ToString("#,##0.00");
                dataGridView.SelectedRows[0].Cells[7].Value = form.Transaction.Notes;

                this._transactions.Remove(transactions);
                this._transactions.Add(form.Transaction);
                Filter();
            }
        }
        private void GetTransactions()
        {
            this._transactions.AddRange(MockData.Transactions());
        }
        #endregion
    }
}
