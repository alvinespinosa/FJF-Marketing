using System;
using System.Windows.Forms;

namespace FJFApp.IncomeExpenses
{
    public partial class frmEntry : Form
    {
        public bool IsCancelled { get; private set; }
        public TransactionEntry Entry { get; private set; }

        public frmEntry()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.Entry = new TransactionEntry
            {
                Amount = numFare.Value,
                Remarks = textBox1.Text.Trim().Replace("'","''"),
                Type = Constants.TransactionType.Income
            };

            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            IsCancelled = true;
            this.Close();
        }
    }
}
