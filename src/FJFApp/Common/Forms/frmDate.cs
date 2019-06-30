using System;
using System.Windows.Forms;

namespace FJFApp.Common.Forms
{
    public partial class frmDate : Form
    {
        public bool IsCancelled { get; private set; }
        public DateTime Date { get; private set; }
        public frmDate()
        {
            InitializeComponent();
            this.IsCancelled = true;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.IsCancelled = false;
            this.Date = dtPicker.Value;
            this.Close();
        }
    }
}
