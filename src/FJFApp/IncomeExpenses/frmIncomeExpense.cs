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

        public frmIncomeExpense()
        {
            InitializeComponent();
            InitializeCustomComponents();
            isCancelled = true;
            this.Transaction = new Transaction();
            LblTotalIncome.Text = Transaction.GetTotalIncome().ToString("#,##0.00");
            LblTotalExpense.Text = Transaction.GetTotalExpense().ToString("#,##0.00");
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
                Transaction.Incomes.Add(form.Entry);
                LblTotalIncome.Text = Transaction.GetTotalIncome().ToString("#,##0.00");
                Compute();

                dgViewIncome.Rows.Add(
                    form.Entry.Amount.ToString("#,##0.00"),
                    form.Entry.Remarks,
                    "remove");
            }
        }

        private void BtnExpense_Click(object sender, EventArgs e)
        {
            var form = new frmEntry();
            form.Text = Constants.TransactionType.Expense;
            form.ShowDialog();

            if (!form.IsCancelled)
            {
                Transaction.Expenses.Add(form.Entry);
                LblTotalExpense.Text = Transaction.GetTotalExpense().ToString("#,##0.00");
                Compute();

                dgViewExpense.Rows.Add(
                  form.Entry.Amount.ToString("#,##0.00"),
                  form.Entry.Remarks,
                  "remove");
            }
        }

        private void TsBtnSave_Click(object sender, EventArgs e)
        {
            isCancelled = false;
            Transaction.BeginningBalance = decimal.Parse(LblBeginning.Text);
            Transaction.EndingBalance = decimal.Parse(LblEnding.Text);
            Transaction.Profit = decimal.Parse(LblProfit.Text);
            Transaction.Notes = TxtNotes.Text.Trim().Replace("'","''");
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
                var item = Transaction.Incomes.SingleOrDefault(_ =>
                  _.Amount == decimal.Parse(dgViewIncome.Rows[e.RowIndex].Cells[0].Value.ToString()) &&
                  _.Remarks == dgViewIncome.Rows[e.RowIndex].Cells[1].Value.ToString());
                Transaction.Incomes.Remove(item);
                LblTotalIncome.Text = Transaction.GetTotalIncome().ToString("#,##0.00");
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
                var item = Transaction.Expenses.SingleOrDefault(_ =>
                    _.Amount == decimal.Parse(dgViewExpense.Rows[e.RowIndex].Cells[0].Value.ToString()) &&
                    _.Remarks == dgViewExpense.Rows[e.RowIndex].Cells[1].Value.ToString());
                dgViewExpense.Rows.RemoveAt(e.RowIndex);
                Transaction.Expenses.Remove(item);
                LblTotalExpense.Text = Transaction.GetTotalExpense().ToString("#,##0.00");
                Compute();
            }
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var form = new frmEditAmount(decimal.Parse(LblBeginning.Text));
            form.ShowDialog();
            if (!form.IsCancelled)
            {
                Transaction.BeginningBalance = form.Amount;
                LblBeginning.Text = form.Amount.ToString("#,##0.00");
                Compute();
            }
        }
        #endregion

        #region Private Method(s)
        private void InitializeCustomComponents()
        {
            dgViewIncome.Columns.Add(Utility.DataGridView.Column("Amount", 100));
            dgViewIncome.Columns.Add(Utility.DataGridView.Column("Remarks", 250));
            dgViewIncome.Columns.Add(Utility.DataGridView.ButtonColumn());

            dgViewExpense.Columns.Add(Utility.DataGridView.Column("Amount", 100));
            dgViewExpense.Columns.Add(Utility.DataGridView.Column("Remarks", 250));
            dgViewExpense.Columns.Add(Utility.DataGridView.ButtonColumn());
        }
        private void Compute()
        {
            var profit = decimal.Parse(LblTotalIncome.Text) - decimal.Parse(LblTotalExpense.Text);
            var ending = profit + decimal.Parse(LblBeginning.Text);

            LblProfit.ForeColor = profit < 0 ? Color.Red : Color.OliveDrab;
            LblProfit.Text = profit.ToString("#,##0.00");

            LblEnding.ForeColor = ending < 0 ? Color.Red : Color.OliveDrab;
            LblEnding.Text = ending.ToString("#,##0.00");
        }
        #endregion
    }
}
