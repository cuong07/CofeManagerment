namespace QuanLyQuanCafe
{
    partial class fMenuFood
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
            this.btnCloseFormMenuFood = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Food thực đơn";
            // 
            // btnCloseFormMenuFood
            // 
            this.btnCloseFormMenuFood.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseFormMenuFood.Image = global::QuanLyQuanCafe.Properties.Resources.close_25;
            this.btnCloseFormMenuFood.Location = new System.Drawing.Point(940, 1);
            this.btnCloseFormMenuFood.Name = "btnCloseFormMenuFood";
            this.btnCloseFormMenuFood.Size = new System.Drawing.Size(39, 33);
            this.btnCloseFormMenuFood.TabIndex = 4;
            this.btnCloseFormMenuFood.UseVisualStyleBackColor = false;
            this.btnCloseFormMenuFood.Click += new System.EventHandler(this.btnCloseFormMenuFood_Click);
            // 
            // fMenuFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseFormMenuFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMenuFood";
            this.Text = "fMenuFood";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseFormMenuFood;
    }
}