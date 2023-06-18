namespace QuanLyQuanCafe
{
    partial class fTakeaway
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
            this.btnCloseFormTakeaway = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbIDOrder = new System.Windows.Forms.ListBox();
            this.lsbDetail = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbIdAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseFormTakeaway
            // 
            this.btnCloseFormTakeaway.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseFormTakeaway.Image = global::QuanLyQuanCafe.Properties.Resources.close_25;
            this.btnCloseFormTakeaway.Location = new System.Drawing.Point(970, 12);
            this.btnCloseFormTakeaway.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseFormTakeaway.Name = "btnCloseFormTakeaway";
            this.btnCloseFormTakeaway.Size = new System.Drawing.Size(52, 41);
            this.btnCloseFormTakeaway.TabIndex = 8;
            this.btnCloseFormTakeaway.UseVisualStyleBackColor = false;
            this.btnCloseFormTakeaway.Click += new System.EventHandler(this.btnCloseFormTakeaway_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 47);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID đơn hàng đang chờ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsbIDOrder
            // 
            this.lsbIDOrder.BackColor = System.Drawing.Color.Silver;
            this.lsbIDOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsbIDOrder.FormattingEnabled = true;
            this.lsbIDOrder.ItemHeight = 25;
            this.lsbIDOrder.Location = new System.Drawing.Point(16, 85);
            this.lsbIDOrder.Name = "lsbIDOrder";
            this.lsbIDOrder.Size = new System.Drawing.Size(366, 554);
            this.lsbIDOrder.TabIndex = 11;
            this.lsbIDOrder.SelectedIndexChanged += new System.EventHandler(this.lsbIDOrder_SelectedIndexChanged);
            // 
            // lsbDetail
            // 
            this.lsbDetail.BackColor = System.Drawing.Color.Silver;
            this.lsbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsbDetail.FormattingEnabled = true;
            this.lsbDetail.ItemHeight = 25;
            this.lsbDetail.Location = new System.Drawing.Point(404, 135);
            this.lsbDetail.Name = "lsbDetail";
            this.lsbDetail.Size = new System.Drawing.Size(390, 429);
            this.lsbDetail.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(434, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 47);
            this.label3.TabIndex = 12;
            this.label3.Text = "Thông tin chi tiết đơn hàng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDone
            // 
            this.btnDone.AutoSize = true;
            this.btnDone.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDone.Location = new System.Drawing.Point(800, 85);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(123, 35);
            this.btnDone.TabIndex = 14;
            this.btnDone.Text = "Hoàn thành";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.AutoSize = true;
            this.btnDeleteOrder.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteOrder.Location = new System.Drawing.Point(800, 126);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(123, 35);
            this.btnDeleteOrder.TabIndex = 16;
            this.btnDeleteOrder.Text = "Hủy đơn";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Visible = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // rtbNote
            // 
            this.rtbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtbNote.Location = new System.Drawing.Point(404, 570);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(390, 69);
            this.rtbNote.TabIndex = 17;
            this.rtbNote.Text = "Ghi chú:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbIdAddress);
            this.groupBox1.Controls.Add(this.lsbDetail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDeleteOrder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rtbNote);
            this.groupBox1.Controls.Add(this.btnDone);
            this.groupBox1.Controls.Add(this.lsbIDOrder);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(21, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 665);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delivery";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(404, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 47);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID:\r\nAddress:";
            // 
            // lbIdAddress
            // 
            this.lbIdAddress.BackColor = System.Drawing.Color.White;
            this.lbIdAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbIdAddress.Location = new System.Drawing.Point(506, 85);
            this.lbIdAddress.Name = "lbIdAddress";
            this.lbIdAddress.Size = new System.Drawing.Size(288, 47);
            this.lbIdAddress.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 34);
            this.label1.TabIndex = 19;
            this.label1.Text = "Phục vụ mang về";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fTakeaway
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 745);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCloseFormTakeaway);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTakeaway";
            this.Text = "fTakeaway";
            this.Load += new System.EventHandler(this.fTakeaway_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCloseFormTakeaway;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbIDOrder;
        private System.Windows.Forms.ListBox lsbDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbIdAddress;
        private System.Windows.Forms.Label label1;
    }
}