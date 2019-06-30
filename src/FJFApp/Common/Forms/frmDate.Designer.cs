namespace FJFApp.Common.Forms
{
    partial class frmDate
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
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.BtnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtPicker
            // 
            this.dtPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Location = new System.Drawing.Point(12, 12);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(510, 39);
            this.dtPicker.TabIndex = 0;
            // 
            // BtnOk
            // 
            this.BtnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.Location = new System.Drawing.Point(390, 57);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(132, 48);
            this.BtnOk.TabIndex = 7;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // frmDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 117);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.dtPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Date";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Button BtnOk;
    }
}