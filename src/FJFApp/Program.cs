﻿using FJFApp.IncomeExpenses;
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
            //Application.Run(new frmIncomeExpense());
            Application.Run(new frmTransactions());
        }
    }
}
