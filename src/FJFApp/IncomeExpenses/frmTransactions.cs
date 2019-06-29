using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FJFApp.IncomeExpenses
{
    public partial class frmTransactions : Form
    {
        private readonly List<Transaction> transactions;

        public frmTransactions()
        {
            InitializeComponent();
            this.transactions = new List<Transaction>();
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
            var form = new frmIncomeExpense();
            form.ShowDialog();
            if (!form.isCancelled)
            {

            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (this.transactions.Count == 0)
                this.GetTransactions();

            Filter();
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

            //var month = new DateTime();

            //foreach (var section in sections)
            //{
            //    comboBox.Items.Add(section.ToString().ToUpper());
            //}

            //comboBox.SelectedIndex = 0;

           

        }
        private void Filter()
        {
            dataGridView.Rows.Clear();
            foreach (var transaction in transactions
                .Where(_ => _.Date.Year == 2019 && _.Date.Month == 5)
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
            };
        }
        //private void OpenDetails()
        //{
        //    if (dataGridView.Rows.Count < 1)
        //        return;

        //    var selectedProduct = dataGridView.SelectedRows[0].Cells[0].Value;

        //    var product = this.products
        //        .SingleOrDefault(_ => _.Id == Guid.Parse(selectedProduct.ToString()));

        //    var frmProduct = new frmProduct(product);
        //    frmProduct.ShowDialog();

        //    // ToDo: Update the list
        //}
        #endregion        

        #region Mock

        private void GetTransactions()
        {
            var transactions = new List<Transaction>();

            transactions.Add(new Transaction()
            {
                Id = Guid.NewGuid(),
                Date = new DateTime(2019,5,10),
                BeginningBalance = 2500,
                EndingBalance = 1500,
                Profit = 600,
                Incomes = new List<TransactionEntry>()
                {
                    new TransactionEntry
                    {
                        Amount = 1500,
                        Remarks = "Test1"
                    }
                },
                Expenses = new List<TransactionEntry>()
                {
                    new TransactionEntry
                    {
                        Amount = 1500,
                        Remarks = "Test1"
                    }
                },
                Notes = "test only11111111"
            });

            transactions.Add(new Transaction()
            {
                Id = Guid.NewGuid(),
                Date = new DateTime(2019, 5, 22),
                BeginningBalance = 6500,
                EndingBalance = 100,
                Profit = 100,
                Incomes = new List<TransactionEntry>()
                {
                    new TransactionEntry
                    {
                        Amount = 400,
                        Remarks = "Test2"
                    }
                },
                Expenses = new List<TransactionEntry>()
                {
                    new TransactionEntry
                    {
                        Amount = 300,
                        Remarks = "Test1"
                    }
                },
                Notes = "test only"
            });

            this.transactions.AddRange(transactions);
        }



        #endregion


     
    }
}
