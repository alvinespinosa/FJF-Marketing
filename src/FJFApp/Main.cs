using FJFApp.IncomeExpenses;
using FJFApp.Payables;
using FJFApp.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FJFApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var form = new frmProducts();
            form.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var form = new frmTransactions();
            form.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var form = new frmPayables();
            form.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
