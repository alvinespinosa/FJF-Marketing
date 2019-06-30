namespace FJFApp.IncomeExpenses
{
    partial class frmTransactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.CboYear = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CboMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.CboYear);
            this.groupBox.Controls.Add(this.BtnSearch);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.CboMonth);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(264, 583);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            // 
            // CboYear
            // 
            this.CboYear.FormattingEnabled = true;
            this.CboYear.Location = new System.Drawing.Point(6, 62);
            this.CboYear.Name = "CboYear";
            this.CboYear.Size = new System.Drawing.Size(252, 28);
            this.CboYear.TabIndex = 6;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(6, 185);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(104, 33);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "MONTH";
            // 
            // CboMonth
            // 
            this.CboMonth.FormattingEnabled = true;
            this.CboMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.CboMonth.Location = new System.Drawing.Point(6, 135);
            this.CboMonth.Name = "CboMonth";
            this.CboMonth.Size = new System.Drawing.Size(252, 28);
            this.CboMonth.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "YEAR";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(282, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(104, 33);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "New...";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(282, 51);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(940, 544);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.DoubleClick += new System.EventHandler(this.DataGridView_DoubleClick);
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 637);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView);
            this.Name = "frmTransactions";
            this.Text = "Transactions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.FrmTransactions_Resize);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox CboYear;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}