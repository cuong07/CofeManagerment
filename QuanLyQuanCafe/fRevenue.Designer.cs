namespace QuanLyQuanCafe
{
    partial class fRevenue
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
            this.btnCloseFormRevenue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCloseFormRevenue
            // 
            this.btnCloseFormRevenue.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseFormRevenue.Image = global::QuanLyQuanCafe.Properties.Resources.close_25;
            this.btnCloseFormRevenue.Location = new System.Drawing.Point(1253, 2);
            this.btnCloseFormRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseFormRevenue.Name = "btnCloseFormRevenue";
            this.btnCloseFormRevenue.Size = new System.Drawing.Size(52, 41);
            this.btnCloseFormRevenue.TabIndex = 6;
            this.btnCloseFormRevenue.UseVisualStyleBackColor = false;
            this.btnCloseFormRevenue.Click += new System.EventHandler(this.btnCloseFormRevenue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "Doanh thu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 745);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseFormRevenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fRevenue";
            this.Text = "fRevenue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCloseFormRevenue;
        private System.Windows.Forms.Label label1;
    }
}