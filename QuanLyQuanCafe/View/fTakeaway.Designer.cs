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
            this.btnDone = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.lbIdAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvBillDetail = new System.Windows.Forms.ListView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnRight = new System.Windows.Forms.Panel();
            this.btnCloseFormTakeaway = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lsvTABill = new System.Windows.Forms.ListView();
            this.clhId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhIdTableFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhInDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhOutDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnTopTab1 = new System.Windows.Forms.Panel();
            this.cbIdTABill = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lsvTADone = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbFindIdP2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnTopTab1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDone.Location = new System.Drawing.Point(400, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(143, 44);
            this.btnDone.TabIndex = 14;
            this.btnDone.Text = "Hoàn thành";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
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
            this.label3.Size = new System.Drawing.Size(696, 37);
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
            this.panel4.Size = new System.Drawing.Size(696, 47);
            this.panel4.TabIndex = 22;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteOrder.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteOrder.Location = new System.Drawing.Point(549, 2);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(135, 45);
            this.btnDeleteOrder.TabIndex = 16;
            this.btnDeleteOrder.Text = "Hủy đơn";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // rtbNote
            // 
            this.rtbNote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtbNote.Location = new System.Drawing.Point(0, 520);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(696, 87);
            this.rtbNote.TabIndex = 17;
            this.rtbNote.Text = "Ghi chú:";
            // 
            // lbIdAddress
            // 
            this.lbIdAddress.BackColor = System.Drawing.Color.White;
            this.lbIdAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbIdAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbIdAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbIdAddress.Location = new System.Drawing.Point(117, 0);
            this.lbIdAddress.Name = "lbIdAddress";
            this.lbIdAddress.Size = new System.Drawing.Size(579, 53);
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
            // panel6
            // 
            this.panel6.Controls.Add(this.lbIdAddress);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(696, 53);
            this.panel6.TabIndex = 20;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Quantity";
            this.columnHeader9.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Food Name";
            this.columnHeader8.Width = 240;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Food ID";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bill ID";
            this.columnHeader3.Width = 90;
            // 
            // lsvBillDetail
            // 
            this.lsvBillDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lsvBillDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvBillDetail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsvBillDetail.FullRowSelect = true;
            this.lsvBillDetail.GridLines = true;
            this.lsvBillDetail.HideSelection = false;
            this.lsvBillDetail.Location = new System.Drawing.Point(0, 53);
            this.lsvBillDetail.MultiSelect = false;
            this.lsvBillDetail.Name = "lsvBillDetail";
            this.lsvBillDetail.Size = new System.Drawing.Size(696, 467);
            this.lsvBillDetail.TabIndex = 21;
            this.lsvBillDetail.UseCompatibleStateImageBehavior = false;
            this.lsvBillDetail.View = System.Windows.Forms.View.Details;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lsvBillDetail);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.rtbNote);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(10, 47);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(696, 607);
            this.panel7.TabIndex = 23;
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.panel7);
            this.pnRight.Controls.Add(this.label3);
            this.pnRight.Controls.Add(this.panel4);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRight.Location = new System.Drawing.Point(601, 44);
            this.pnRight.Name = "pnRight";
            this.pnRight.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pnRight.Size = new System.Drawing.Size(706, 701);
            this.pnRight.TabIndex = 29;
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
            this.panel1.TabIndex = 27;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 701);
            this.tabControl1.TabIndex = 20;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lsvTABill);
            this.tabPage1.Controls.Add(this.pnTopTab1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(593, 672);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Waiting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lsvTABill
            // 
            this.lsvTABill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId,
            this.clhIdTableFood,
            this.clhInDate,
            this.clhOutDate,
            this.clhStatus,
            this.columnHeader1});
            this.lsvTABill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvTABill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsvTABill.FullRowSelect = true;
            this.lsvTABill.GridLines = true;
            this.lsvTABill.HideSelection = false;
            this.lsvTABill.Location = new System.Drawing.Point(0, 40);
            this.lsvTABill.MultiSelect = false;
            this.lsvTABill.Name = "lsvTABill";
            this.lsvTABill.Size = new System.Drawing.Size(593, 632);
            this.lsvTABill.TabIndex = 17;
            this.lsvTABill.UseCompatibleStateImageBehavior = false;
            this.lsvTABill.View = System.Windows.Forms.View.Details;
            this.lsvTABill.SelectedIndexChanged += new System.EventHandler(this.lsvTABill_SelectedIndexChanged);
            // 
            // clhId
            // 
            this.clhId.Text = "ID Bill";
            this.clhId.Width = 55;
            // 
            // clhIdTableFood
            // 
            this.clhIdTableFood.Text = "Table ID";
            this.clhIdTableFood.Width = 90;
            // 
            // clhInDate
            // 
            this.clhInDate.Text = "CheckIn Date";
            this.clhInDate.Width = 110;
            // 
            // clhOutDate
            // 
            this.clhOutDate.Text = "Checout Date";
            this.clhOutDate.Width = 110;
            // 
            // clhStatus
            // 
            this.clhStatus.Text = "Paid";
            this.clhStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Employee ID";
            // 
            // pnTopTab1
            // 
            this.pnTopTab1.Controls.Add(this.cbIdTABill);
            this.pnTopTab1.Controls.Add(this.label2);
            this.pnTopTab1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopTab1.Location = new System.Drawing.Point(0, 0);
            this.pnTopTab1.Name = "pnTopTab1";
            this.pnTopTab1.Size = new System.Drawing.Size(593, 40);
            this.pnTopTab1.TabIndex = 0;
            // 
            // cbIdTABill
            // 
            this.cbIdTABill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIdTABill.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbIdTABill.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbIdTABill.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.cbIdTABill.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbIdTABill.FormattingEnabled = true;
            this.cbIdTABill.Location = new System.Drawing.Point(350, 3);
            this.cbIdTABill.Margin = new System.Windows.Forms.Padding(0);
            this.cbIdTABill.Name = "cbIdTABill";
            this.cbIdTABill.Size = new System.Drawing.Size(243, 34);
            this.cbIdTABill.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(0, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID đơn hàng đang chờ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lsvTADone);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(593, 672);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Finished";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lsvTADone
            // 
            this.lsvTADone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader10,
            this.columnHeader11});
            this.lsvTADone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvTADone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsvTADone.FullRowSelect = true;
            this.lsvTADone.GridLines = true;
            this.lsvTADone.HideSelection = false;
            this.lsvTADone.Location = new System.Drawing.Point(3, 43);
            this.lsvTADone.MultiSelect = false;
            this.lsvTADone.Name = "lsvTADone";
            this.lsvTADone.Size = new System.Drawing.Size(587, 626);
            this.lsvTADone.TabIndex = 17;
            this.lsvTADone.UseCompatibleStateImageBehavior = false;
            this.lsvTADone.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID Bill";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Table ID";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CheckIn Date";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Checout Date";
            this.columnHeader6.Width = 110;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Paid";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Employee ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbFindIdP2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 40);
            this.panel2.TabIndex = 18;
            // 
            // cbFindIdP2
            // 
            this.cbFindIdP2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFindIdP2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFindIdP2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFindIdP2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.cbFindIdP2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbFindIdP2.FormattingEnabled = true;
            this.cbFindIdP2.Location = new System.Drawing.Point(341, 2);
            this.cbFindIdP2.Margin = new System.Windows.Forms.Padding(0);
            this.cbFindIdP2.Name = "cbFindIdP2";
            this.cbFindIdP2.Size = new System.Drawing.Size(243, 34);
            this.cbFindIdP2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(0, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "ĐH mang về đã hoàn thành";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.tabControl1);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 44);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(601, 701);
            this.pnLeft.TabIndex = 28;
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
            this.Load += new System.EventHandler(this.fTakeaway_Load);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnRight.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnTopTab1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label lbIdAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lsvBillDetail;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Button btnCloseFormTakeaway;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIdTABill;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.ListView lsvTABill;
        private System.Windows.Forms.ColumnHeader clhId;
        private System.Windows.Forms.ColumnHeader clhIdTableFood;
        private System.Windows.Forms.ColumnHeader clhInDate;
        private System.Windows.Forms.ColumnHeader clhOutDate;
        private System.Windows.Forms.ColumnHeader clhStatus;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel pnTopTab1;
        private System.Windows.Forms.ListView lsvTADone;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbFindIdP2;
        private System.Windows.Forms.Label label4;
    }
}