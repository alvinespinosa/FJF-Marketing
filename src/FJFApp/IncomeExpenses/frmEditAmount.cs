using System;
using System.Windows.Forms;

namespace FJFApp.IncomeExpenses
{
    public partial class frmEditAmount : Form
    {
        public bool IsCancelled { get; private set; }
        public decimal Amount { get; private set; }
        public frmEditAmount(decimal amount)
        {
            InitializeComponent();
            this.IsCancelled = true;
            numericUpDown1.Value = amount;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            this.IsCancelled = false;
            this.Amount = numericUpDown1.Value;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
    }
}
