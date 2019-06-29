using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FJFApp.Utility
{
    public class DataGridView
    {
        public static DataGridViewColumn Column(string headerText, int width,
            bool hidden = false)
        {
            var gridColumn = new DataGridViewColumn();

            gridColumn.HeaderText = headerText;
            gridColumn.Width = width;
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            
            gridColumn.CellTemplate = cell;
            gridColumn.Visible = !hidden;
            //gridColumn.ReadOnly = true;


            return gridColumn;
        }

        public static DataGridViewCheckBoxColumn CheckboxColumn(string headerText = "")
        {
            var checkBox = new DataGridViewCheckBoxColumn();
            checkBox.HeaderText = headerText;
            checkBox.Width = 25;
            //checkBox.ReadOnly = false;

            return checkBox;
        }

        public static DataGridViewButtonColumn ButtonColumn(string headerText = "")
        {
            var buttonColumn = new DataGridViewButtonColumn();           

            buttonColumn.HeaderText = headerText;
            buttonColumn.Width = 50;
            //buttonColumn.ReadOnly = false;

            return buttonColumn;
        }
    }
}
