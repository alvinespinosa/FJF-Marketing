using FJFApp.IncomeExpenses;
using FJFApp.Payables;
using FJFApp.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FJFApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmProducts());
            //Application.Run(new frmTransactions());
            //Application.Run(new frmPayables());
            Application.Run(new Main());
        }
    }
}
