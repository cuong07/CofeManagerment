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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseFormTakeaway = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.lsbIDOrder = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnRight = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lsbDetail = new System.Windows.Forms.ListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbIdAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnCloseFormTakeaway);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 44);
            this.panel1.TabIndex = 24;
            // 
            // btnCloseFormTakeaway
            // 
            this.btnCloseFormTakeaway.BackColor = System.Drawing.Color.Black;
            this.btnCloseFormTakeaway.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseFormTakeaway.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCloseFormTakeaway.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseFormTakeaway.Location = new System.Drawing.Point(1248, 0);
            this.btnCloseFormTakeaway.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseFormTakeaway.Name = "btnCloseFormTakeaway";
            this.btnCloseFormTakeaway.Size = new System.Drawing.Size(59, 44);
            this.btnCloseFormTakeaway.TabIndex = 8;
            this.btnCloseFormTakeaway.Text = "X";
            this.btnCloseFormTakeaway.UseVisualStyleBackColor = false;
            this.btnCloseFormTakeaway.Click += new System.EventHandler(this.btnCloseFormTakeaway_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1307, 44);
            this.label1.TabIndex = 19;
            this.label1.Text = "Phục vụ mang về";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.lsbIDOrder);
            this.pnLeft.Controls.Add(this.tableLayoutPanel5);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 44);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnLeft.Size = new System.Drawing.Size(514, 701);
            this.pnLeft.TabIndex = 25;
            // 
            // lsbIDOrder
            // 
            this.lsbIDOrder.BackColor = System.Drawing.Color.White;
            this.lsbIDOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbIDOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsbIDOrder.FormattingEnabled = true;
            this.lsbIDOrder.ItemHeight = 23;
            this.lsbIDOrder.Location = new System.Drawing.Point(0, 49);
            this.lsbIDOrder.Name = "lsbIDOrder";
            this.lsbIDOrder.Size = new System.Drawing.Size(514, 652);
            this.lsbIDOrder.TabIndex = 11;
            this.lsbIDOrder.SelectedIndexChanged += new System.EventHandler(this.lsbIDOrder_SelectedIndexChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 10);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(514, 39);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID đơn hàng đang chờ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(271, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 34);
            this.comboBox1.TabIndex = 12;
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.panel7);
            this.pnRight.Controls.Add(this.label3);
            this.pnRight.Controls.Add(this.panel4);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRight.Location = new System.Drawing.Point(514, 44);
            this.pnRight.Name = "pnRight";
            this.pnRight.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pnRight.Size = new System.Drawing.Size(793, 701);
            this.pnRight.TabIndex = 26;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lsbDetail);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.rtbNote);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(10, 47);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(783, 607);
            this.panel7.TabIndex = 23;
            // 
            // lsbDetail
            // 
            this.lsbDetail.BackColor = System.Drawing.Color.White;
            this.lsbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbDetail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsbDetail.FormattingEnabled = true;
            this.lsbDetail.ItemHeight = 23;
            this.lsbDetail.Location = new System.Drawing.Point(0, 53);
            this.lsbDetail.Name = "lsbDetail";
            this.lsbDetail.Size = new System.Drawing.Size(783, 467);
            this.lsbDetail.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbIdAddress);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(783, 53);
            this.panel6.TabIndex = 20;
            // 
            // lbIdAddress
            // 
            this.lbIdAddress.BackColor = System.Drawing.Color.White;
            this.lbIdAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbIdAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbIdAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbIdAddress.Location = new System.Drawing.Point(117, 0);
            this.lbIdAddress.Name = "lbIdAddress";
            this.lbIdAddress.Size = new System.Drawing.Size(666, 53);
            this.lbIdAddress.TabIndex = 18;
            this.lbIdAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 53);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID:\r\nAddress:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtbNote
            // 
            this.rtbNote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtbNote.Location = new System.Drawing.Point(0, 520);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(783, 87);
            this.rtbNote.TabIndex = 17;
            this.rtbNote.Text = "Ghi chú:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(783, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "Thông tin chi tiết đơn hàng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnDeleteOrder);
            this.panel4.Controls.Add(this.btnDone);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 654);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(783, 47);
            this.panel4.TabIndex = 22;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteOrder.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteOrder.Location = new System.Drawing.Point(636, 2);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(135, 45);
            this.btnDeleteOrder.TabIndex = 16;
            this.btnDeleteOrder.Text = "Hủy đơn";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDone.Location = new System.Drawing.Point(487, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(143, 44);
            this.btnDone.TabIndex = 14;
            this.btnDone.Text = "Hoàn thành";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // fTakeaway
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 745);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTakeaway";
            this.Text = "fTakeaway";
            this.panel1.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.pnRight.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseFormTakeaway;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.ListBox lsbIDOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListBox lsbDetail;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbIdAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnDone;
    }
}