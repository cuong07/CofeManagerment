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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lbDayend = new System.Windows.Forms.Label();
            this.lbDaybegin = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbSelectday = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbToTal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.lbDayend);
            this.groupBox1.Controls.Add(this.lbDaybegin);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cbSelectday);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1315, 127);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(1183, 34);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(101, 70);
            this.btnShow.TabIndex = 23;
            this.btnShow.Text = "Xem";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // lbDayend
            // 
            this.lbDayend.AutoSize = true;
            this.lbDayend.Location = new System.Drawing.Point(711, 50);
            this.lbDayend.Name = "lbDayend";
            this.lbDayend.Size = new System.Drawing.Size(120, 26);
            this.lbDayend.TabIndex = 22;
            this.lbDayend.Text = "Đến  ngày:";
            this.lbDayend.Visible = false;
            // 
            // lbDaybegin
            // 
            this.lbDaybegin.AutoSize = true;
            this.lbDaybegin.Location = new System.Drawing.Point(265, 50);
            this.lbDaybegin.Name = "lbDaybegin";
            this.lbDaybegin.Size = new System.Drawing.Size(101, 26);
            this.lbDaybegin.TabIndex = 22;
            this.lbDaybegin.Text = "Từ ngày:";
            this.lbDaybegin.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(849, 50);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(307, 34);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(398, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(307, 34);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Visible = false;
            // 
            // cbSelectday
            // 
            this.cbSelectday.FormattingEnabled = true;
            this.cbSelectday.Items.AddRange(new object[] {
            "Xem một ngày",
            "Xem nhiều ngày"});
            this.cbSelectday.Location = new System.Drawing.Point(6, 50);
            this.cbSelectday.Name = "cbSelectday";
            this.cbSelectday.Size = new System.Drawing.Size(253, 34);
            this.cbSelectday.TabIndex = 0;
            this.cbSelectday.Text = "-chọn-";
            this.cbSelectday.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 182);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1315, 470);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Từ ngày:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(711, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Đến  ngày:";
            this.label3.Visible = false;
            // 
            // lbToTal
            // 
            this.lbToTal.AutoSize = true;
            this.lbToTal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbToTal.Location = new System.Drawing.Point(733, 687);
            this.lbToTal.Name = "lbToTal";
            this.lbToTal.Size = new System.Drawing.Size(111, 26);
            this.lbToTal.TabIndex = 23;
            this.lbToTal.Text = "Tổng tiền:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotal.Location = new System.Drawing.Point(861, 687);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(366, 34);
            this.txtTotal.TabIndex = 24;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 745);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbToTal);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseFormRevenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fRevenue";
            this.Text = "fRevenue";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCloseFormRevenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSelectday;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lbDayend;
        private System.Windows.Forms.Label lbDaybegin;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbToTal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}