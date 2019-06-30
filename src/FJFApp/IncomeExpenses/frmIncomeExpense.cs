using FJFApp.Common.Forms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FJFApp.IncomeExpenses
{
    public partial class frmIncomeExpense : Form
    {
        public Transaction Transaction { get; private set; }
        public bool isCancelled { get; private set; }

        public frmIncomeExpense(Transaction transaction = null)
        {
            InitializeComponent();
            InitializeCustomComponents(transaction);
            Compute();
        }

        #region Event(s)
        private void BtnIncome_Click(object sender, EventArgs e)
        {
            var form = new frmEntry();
            form.Text = Constants.TransactionType.Income;
            form.ShowDialog();

            if (!form.IsCancelled)
            {
                dgViewIncome.Rows.Add(
                    form.Entry.Amount.ToString("#,##0.00"),
                    form.Entry.Remarks,
                    "remove");
                Compute();
            }
        }

        private void BtnExpense_Click(object sender, EventArgs e)
        {
            var form = new frmEntry();
            form.Text = Constants.TransactionType.Expense;
            form.ShowDialog();

            if (!form.IsCancelled)
            {
                dgViewExpense.Rows.Add(
                  form.Entry.Amount.ToString("#,##0.00"),
                  form.Entry.Remarks,
                  "remove");
                Compute();
            }
        }

        private void TsBtnSave_Click(object sender, EventArgs e)
        {
            isCancelled = false;
            Transaction.BeginningBalance = decimal.Parse(LblBeginning.Text);
            Transaction.EndingBalance = decimal.Parse(LblEnding.Text);
            Transaction.Profit = decimal.Parse(LblProfit.Text);
            Transaction.Notes = TxtNotes.Text.Trim().Replace("'","''");
            Transaction.Incomes.Clear();
            Transaction.Expenses.Clear();

            for (var row = 0; dgViewIncome.Rows.Count > row; row++)
            {
                Transaction.Incomes.Add(
                    new TransactionEntry
                    {
                        Amount = decimal.Parse(this.dgViewIncome[0, row].Value.ToString()),
                        Remarks = this.dgViewIncome[1, row].Value.ToString(),
                        Type = Constants.TransactionType.Income
                    });
            }

            for (var row = 0; dgViewExpense.Rows.Count > row; row++)
            {
                Transaction.Expenses.Add(
                    new TransactionEntry
                    {
                        Amount = decimal.Parse(this.dgViewExpense[0, row].Value.ToString()),
                        Remarks = this.dgViewExpense[1, row].Value.ToString(),
                        Type = Constants.TransactionType.Income
                    });
            }

            this.Close();
        }

        private void TsBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }    

        private void DgViewIncome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[2] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //var item = Transaction.Incomes.SingleOrDefault(_ =>
                //  _.Amount == decimal.Parse(dgViewIncome.Rows[e.RowIndex].Cells[0].Value.ToString()) &&
                //  _.Remarks == dgViewIncome.Rows[e.RowIndex].Cells[1].Value.ToString());
                //Transaction.Incomes.Remove(item);
                //LblTotalIncome.Text = Transaction.GetTotalIncome().ToString("#,##0.00");
                dgViewIncome.Rows.RemoveAt(e.RowIndex);
                Compute();
            }
        }
        private void DgViewExpense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[2] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //var item = Transaction.Expenses.SingleOrDefault(_ =>
                //    _.Amount == decimal.Parse(dgViewExpense.Rows[e.RowIndex].Cells[0].Value.ToString()) &&
                //    _.Remarks == dgViewExpense.Rows[e.RowIndex].Cells[1].Value.ToString());
                dgViewExpense.Rows.RemoveAt(e.RowIndex);
                //Transaction.Expenses.Remove(item);
                //LblTotalExpense.Text = Transaction.GetTotalExpense().ToString("#,##0.00");
                Compute();
            }
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var form = new frmEditAmount(decimal.Parse(LblBeginning.Text));
            form.ShowDialog();
            if (!form.IsCancelled)
            {
                LblBeginning.Text = form.Amount.ToString("#,##0.00");
                Compute();
            }
        }
        #endregion

        #region Private Method(s)
        private void InitializeCustomComponents(Transaction transaction)
        {
            isCancelled = true;
            this.Transaction = transaction ?? new Transaction();

            dgViewIncome.Columns.Add(Utility.DataGridView.Column("Amount", 100));
            dgViewIncome.Columns.Add(Utility.DataGridView.Column("Remarks", 250));
            dgViewIncome.Columns.Add(Utility.DataGridView.ButtonColumn());

            dgViewExpense.Columns.Add(Utility.DataGridView.Column("Amount", 100));
            dgViewExpense.Columns.Add(Utility.DataGridView.Column("Remarks", 250));
            dgViewExpense.Columns.Add(Utility.DataGridView.ButtonColumn());

            if (transaction != null)
            {
                LblBeginning.Text = transaction.BeginningBalance.ToString("#,##0.00");

                foreach (var income in transaction.Incomes)
                {
                    dgViewIncome.Rows.Add(
                       income.Amount.ToString("#,##0.00"),
                       income.Remarks,
                       "remove");
                }
                LblTotalIncome.Text = Transaction.GetTotalIncome().ToString("#,##0.00");

                foreach (var expense in transaction.Expenses)
                {
                    dgViewExpense.Rows.Add(
                       expense.Amount.ToString("#,##0.00"),
                       expense.Remarks,
                       "remove");
                }
                LblTotalExpense.Text = Transaction.GetTotalExpense().ToString("#,##0.00");
                Compute();
                TxtNotes.Text = transaction.Notes;
                this.Text = this.Text + " : " + transaction.Date.ToString("MMMM d, yyyy");
            }
        }
        private void Compute()
        {
            decimal income = 0;
            decimal expenses = 0;

            for (var row = 0; dgViewIncome.Rows.Count > row; row++)
            {
                income = income + decimal.Parse(this.dgViewIncome[0, row].Value.ToString());
            }

            for (var row = 0; dgViewExpense.Rows.Count > row; row++)
            {
                expenses = expenses + decimal.Parse(this.dgViewExpense[0, row].Value.ToString());
            }

            var profit = income - expenses;
            var ending = profit + decimal.Parse(LblBeginning.Text);

            LblTotalIncome.Text = income.ToString("#,##0.00");
            LblTotalExpense.Text = expenses.ToString("#,##0.00");

            LblProfit.ForeColor = profit < 0 ? Color.Red : Color.OliveDrab;
            LblProfit.Text = profit.ToString("#,##0.00");

            LblEnding.ForeColor = ending < 0 ? Color.Red : Color.OliveDrab;
            LblEnding.Text = ending.ToString("#,##0.00");
        }
        #endregion
    }
}
