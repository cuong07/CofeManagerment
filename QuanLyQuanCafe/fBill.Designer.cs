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
            this.btnCloseFormBill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCloseFormBill
            // 
            this.btnCloseFormBill.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseFormBill.Image = global::QuanLyQuanCafe.Properties.Resources.close_25;
            this.btnCloseFormBill.Location = new System.Drawing.Point(1253, 2);
            this.btnCloseFormBill.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseFormBill.Name = "btnCloseFormBill";
            this.btnCloseFormBill.Size = new System.Drawing.Size(52, 41);
            this.btnCloseFormBill.TabIndex = 2;
            this.btnCloseFormBill.UseVisualStyleBackColor = false;
            this.btnCloseFormBill.Click += new System.EventHandler(this.btnCloseFormBill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "Hóa đơn đã thanh toán";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 745);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseFormBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fBill";
            this.Text = "fBill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCloseFormBill;
        private System.Windows.Forms.Label label1;
    }
}