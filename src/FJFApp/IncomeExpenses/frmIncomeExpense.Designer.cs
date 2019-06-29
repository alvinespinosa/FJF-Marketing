namespace FJFApp.IncomeExpenses
{
    partial class frmIncomeExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncomeExpense));
            this.dgViewIncome = new System.Windows.Forms.DataGridView();
            this.btnIncome = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblTotalIncome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnExpense = new System.Windows.Forms.Button();
            this.dgViewExpense = new System.Windows.Forms.DataGridView();
            this.LblTotalExpense = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.LblProfit = new System.Windows.Forms.Label();
            this.LblBeginning = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblEnding = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewIncome)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewExpense)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgViewIncome
            // 
            this.dgViewIncome.AllowUserToAddRows = false;
            this.dgViewIncome.AllowUserToDeleteRows = false;
            this.dgViewIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewIncome.Location = new System.Drawing.Point(31, 93);
            this.dgViewIncome.Name = "dgViewIncome";
            this.dgViewIncome.ReadOnly = true;
            this.dgViewIncome.RowHeadersWidth = 62;
            this.dgViewIncome.RowTemplate.Height = 28;
            this.dgViewIncome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgViewIncome.Size = new System.Drawing.Size(1361, 199);
            this.dgViewIncome.TabIndex = 0;
            this.dgViewIncome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgViewIncome_CellContentClick);
            // 
            // btnIncome
            // 
            this.btnIncome.Location = new System.Drawing.Point(31, 54);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(104, 33);
            this.btnIncome.TabIndex = 7;
            this.btnIncome.Text = "New...";
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.BtnIncome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIncome);
            this.groupBox1.Controls.Add(this.dgViewIncome);
            this.groupBox1.Location = new System.Drawing.Point(43, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1416, 306);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Income";
            // 
            // LblTotalIncome
            // 
            this.LblTotalIncome.AutoEllipsis = true;
            this.LblTotalIncome.BackColor = System.Drawing.SystemColors.Info;
            this.LblTotalIncome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotalIncome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalIncome.ForeColor = System.Drawing.Color.OliveDrab;
            this.LblTotalIncome.Location = new System.Drawing.Point(578, 96);
            this.LblTotalIncome.Name = "LblTotalIncome";
            this.LblTotalIncome.Size = new System.Drawing.Size(238, 39);
            this.LblTotalIncome.TabIndex = 18;
            this.LblTotalIncome.Text = "1,509,990.00";
            this.LblTotalIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(573, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "INCOME";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Location = new System.Drawing.Point(31, 39);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(1361, 102);
            this.TxtNotes.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnExpense);
            this.groupBox2.Controls.Add(this.dgViewExpense);
            this.groupBox2.Location = new System.Drawing.Point(43, 478);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1416, 306);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Expense";
            // 
            // BtnExpense
            // 
            this.BtnExpense.Location = new System.Drawing.Point(31, 54);
            this.BtnExpense.Name = "BtnExpense";
            this.BtnExpense.Size = new System.Drawing.Size(104, 33);
            this.BtnExpense.TabIndex = 7;
            this.BtnExpense.Text = "New...";
            this.BtnExpense.UseVisualStyleBackColor = true;
            this.BtnExpense.Click += new System.EventHandler(this.BtnExpense_Click);
            // 
            // dgViewExpense
            // 
            this.dgViewExpense.AllowUserToAddRows = false;
            this.dgViewExpense.AllowUserToDeleteRows = false;
            this.dgViewExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewExpense.Location = new System.Drawing.Point(31, 93);
            this.dgViewExpense.Name = "dgViewExpense";
            this.dgViewExpense.ReadOnly = true;
            this.dgViewExpense.RowHeadersWidth = 62;
            this.dgViewExpense.RowTemplate.Height = 28;
            this.dgViewExpense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgViewExpense.Size = new System.Drawing.Size(1361, 199);
            this.dgViewExpense.TabIndex = 0;
            this.dgViewExpense.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgViewExpense_CellContentClick);
            // 
            // LblTotalExpense
            // 
            this.LblTotalExpense.AutoEllipsis = true;
            this.LblTotalExpense.BackColor = System.Drawing.SystemColors.Info;
            this.LblTotalExpense.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotalExpense.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblTotalExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalExpense.ForeColor = System.Drawing.Color.OliveDrab;
            this.LblTotalExpense.Location = new System.Drawing.Point(846, 96);
            this.LblTotalExpense.Name = "LblTotalExpense";
            this.LblTotalExpense.Size = new System.Drawing.Size(238, 39);
            this.LblTotalExpense.TabIndex = 20;
            this.LblTotalExpense.Text = "1,509,990.00";
            this.LblTotalExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(841, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "EXPENSES";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnSave,
            this.toolStripSeparator1,
            this.tsBtnCancel});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1550, 34);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnSave
            // 
            this.tsBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSave.Image")));
            this.tsBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSave.Name = "tsBtnSave";
            this.tsBtnSave.Size = new System.Drawing.Size(77, 29);
            this.tsBtnSave.Text = "Save";
            this.tsBtnSave.Click += new System.EventHandler(this.TsBtnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // tsBtnCancel
            // 
            this.tsBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCancel.Image")));
            this.tsBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCancel.Name = "tsBtnCancel";
            this.tsBtnCancel.Size = new System.Drawing.Size(91, 29);
            this.tsBtnCancel.Text = "Cancel";
            this.tsBtnCancel.Click += new System.EventHandler(this.TsBtnCancel_Click);
            // 
            // LblProfit
            // 
            this.LblProfit.AutoEllipsis = true;
            this.LblProfit.BackColor = System.Drawing.SystemColors.Info;
            this.LblProfit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblProfit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfit.ForeColor = System.Drawing.Color.OliveDrab;
            this.LblProfit.Location = new System.Drawing.Point(1166, 96);
            this.LblProfit.Name = "LblProfit";
            this.LblProfit.Size = new System.Drawing.Size(238, 39);
            this.LblProfit.TabIndex = 19;
            this.LblProfit.Text = "1,509,990.00";
            this.LblProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblBeginning
            // 
            this.LblBeginning.AutoEllipsis = true;
            this.LblBeginning.BackColor = System.Drawing.SystemColors.Info;
            this.LblBeginning.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblBeginning.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblBeginning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBeginning.ForeColor = System.Drawing.Color.OliveDrab;
            this.LblBeginning.Location = new System.Drawing.Point(43, 96);
            this.LblBeginning.Name = "LblBeginning";
            this.LblBeginning.Size = new System.Drawing.Size(238, 39);
            this.LblBeginning.TabIndex = 20;
            this.LblBeginning.Text = "2,500.00";
            this.LblBeginning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1161, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 26);
            this.label7.TabIndex = 21;
            this.label7.Text = "PROFIT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 26);
            this.label8.TabIndex = 22;
            this.label8.Text = "BEGINNING BAL.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(307, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "ENDING BAL.";
            // 
            // LblEnding
            // 
            this.LblEnding.AutoEllipsis = true;
            this.LblEnding.BackColor = System.Drawing.SystemColors.Info;
            this.LblEnding.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblEnding.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblEnding.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnding.ForeColor = System.Drawing.Color.OliveDrab;
            this.LblEnding.Location = new System.Drawing.Point(312, 96);
            this.LblEnding.Name = "LblEnding";
            this.LblEnding.Size = new System.Drawing.Size(238, 39);
            this.LblEnding.TabIndex = 23;
            this.LblEnding.Text = "1,509,990.00";
            this.LblEnding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtNotes);
            this.groupBox3.Location = new System.Drawing.Point(43, 804);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1416, 160);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notes";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(250, 60);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(31, 33);
            this.BtnEdit.TabIndex = 27;
            this.BtnEdit.Text = "...";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // frmIncomeExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 1000);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.LblTotalExpense);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblTotalIncome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblEnding);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblBeginning);
            this.Controls.Add(this.LblProfit);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIncomeExpense";
            this.Text = "Income and Expense";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgViewIncome)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewExpense)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewIncome;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnExpense;
        private System.Windows.Forms.DataGridView dgViewExpense;
        private System.Windows.Forms.Label LblTotalIncome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTotalExpense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnCancel;
        private System.Windows.Forms.Label LblProfit;
        private System.Windows.Forms.Label LblBeginning;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblEnding;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnEdit;
    }
}