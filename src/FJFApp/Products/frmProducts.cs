﻿using FJFApp.Common;
using FJFApp.Model.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FJFApp.Products
{
    public partial class frmProducts : Form
    {
        private readonly List<Product> products;
        public frmProducts()
        {
            InitializeComponent();
            InitializeCustomComponents();
            this.products = new List<Product>();
        }

        #region Event(s)
        private void frmProducts_Resize(object sender, EventArgs e)
        {
            groupBox.Height = this.Height - 55;
            dataGridView.Height = this.Height - 60;
            dataGridView.Width = this.Width - 210;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            var frmProduct = new frmProduct(null, comboBox.Text);
            frmProduct.ShowDialog();
            if (!frmProduct.isCancelled)
            {
                this.products.Add(frmProduct.product);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (this.products.Count == 0)
                this.GetProducts();

            Filter();
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Filter();
        }
        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            OpenDetails();
        }
        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            OpenDetails();
        }
        #endregion

        #region Private Method(s)
        private void InitializeCustomComponents()
        {
            dataGridView.Columns.Add(Utility.DataGridView.Column("Guid", 150, true));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Category", 150));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Item", 250));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Unit", 50));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Price", 50));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Fare", 50));
            dataGridView.Columns.Add(Utility.DataGridView.Column("TotalCost", 50));
            dataGridView.Columns.Add(Utility.DataGridView.Column("SRP", 50));
            dataGridView.Columns.Add(Utility.DataGridView.Column("GP", 50));
            dataGridView.Columns.Add(Utility.DataGridView.Column("%", 50));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Active", 50));
            dataGridView.Columns.Add(Utility.DataGridView.Column("Notes", 150));

            var sections = Enum.GetValues(typeof(Enums.Sections));

            foreach (var section in sections)
            {
                comboBox.Items.Add(section.ToString().ToUpper());
            }

            comboBox.SelectedIndex = 0;

        }
        private void Filter()
        {
            dataGridView.Rows.Clear();

            var searchItem = textBox.Text.Trim();
            var products = this.products
                            .Where(_ => _.Section.ToUpper() == comboBox.Text.ToUpper())
                            .ToList(); ;

            if (searchItem != string.Empty)
            {
                products = products
                    .Where(_ => _.Item.ToUpper().Contains(searchItem.ToUpper()))
                    .ToList();
            }

            if (checkBox.Checked)
            {
                products = products
                   .Where(_ => _.Active == checkBox.Checked)
                   .ToList();
            }

            foreach (var product in products)
            {
                dataGridView.Rows.Add(
                    product.Id,
                    product.Category,
                    product.Item,
                    product.Unit,
                    product.Price.ToString("#,##0.00"),
                    product.Fare.ToString("#,##0.00"),
                    product.TotalCost().ToString("#,##0.00"),
                    product.Srp.ToString("#,##0.00"),
                    product.GP(),
                    Math.Truncate(product.Percentage()).ToString("#") + " %",
                    product.Active ? "Yes" : "No",
                    product.Notes);
            };
        }
        private void OpenDetails()
        {
            if (dataGridView.Rows.Count < 1)
                return;

            var selectedProduct = dataGridView.SelectedRows[0].Cells[0].Value;

            var product = this.products
                .SingleOrDefault(_ => _.Id == Guid.Parse(selectedProduct.ToString()));

            var frmProduct = new frmProduct(product);
            frmProduct.ShowDialog();

            // ToDo: Update the list
        }
        private void GetProducts()
        {
            this.products.AddRange(MockData.Products());
        }
        #endregion
    }
}
