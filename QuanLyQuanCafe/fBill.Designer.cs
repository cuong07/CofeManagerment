namespace QuanLyQuanCafe
{
    partial class fBill
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseFormBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "bill";
            // 
            // btnCloseFormBill
            // 
            this.btnCloseFormBill.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseFormBill.Image = global::QuanLyQuanCafe.Properties.Resources.close_25;
            this.btnCloseFormBill.Location = new System.Drawing.Point(940, 2);
            this.btnCloseFormBill.Name = "btnCloseFormBill";
            this.btnCloseFormBill.Size = new System.Drawing.Size(39, 33);
            this.btnCloseFormBill.TabIndex = 2;
            this.btnCloseFormBill.UseVisualStyleBackColor = false;
            this.btnCloseFormBill.Click += new System.EventHandler(this.btnCloseFormBill_Click);
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseFormBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fBill";
            this.Text = "fBill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseFormBill;
    }
}