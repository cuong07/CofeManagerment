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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvFood = new System.Windows.Forms.ListView();
            this.clhId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhFoodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhIdCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnDSMTop = new System.Windows.Forms.Panel();
            this.cbFilterDishes = new System.Windows.Forms.ComboBox();
            this.cbFindFoodName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnCloseFormMenuFood = new System.Windows.Forms.Button();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.grbEditFood = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEditIdCategory = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditId = new System.Windows.Forms.TextBox();
            this.txtEditImageName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEditFoodName = new System.Windows.Forms.TextBox();
            this.txtEditPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnThemMon = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNewIdCategory = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNewImages = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewFoodName = new System.Windows.Forms.TextBox();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnRight = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.pnDSMTop.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.grbEditFood.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnThemMon.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.lsvFood);
            this.groupBox1.Controls.Add(this.pnDSMTop);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 713);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách món ăn";
            // 
            // lsvFood
            // 
            this.lsvFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId,
            this.clhFoodName,
            this.clhImage,
            this.clhPrice,
            this.clhIdCategory});
            this.lsvFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvFood.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsvFood.FullRowSelect = true;
            this.lsvFood.GridLines = true;
            this.lsvFood.HideSelection = false;
            this.lsvFood.Location = new System.Drawing.Point(3, 58);
            this.lsvFood.MultiSelect = false;
            this.lsvFood.Name = "lsvFood";
            this.lsvFood.Size = new System.Drawing.Size(765, 652);
            this.lsvFood.TabIndex = 15;
            this.lsvFood.UseCompatibleStateImageBehavior = false;
            this.lsvFood.View = System.Windows.Forms.View.Details;
            this.lsvFood.SelectedIndexChanged += new System.EventHandler(this.lsvFood_SelectedIndexChanged);
            // 
            // clhId
            // 
            this.clhId.Text = "ID";
            this.clhId.Width = 55;
            // 
            // clhFoodName
            // 
            this.clhFoodName.Text = "Tên món ăn";
            this.clhFoodName.Width = 250;
            // 
            // clhImage
            // 
            this.clhImage.Text = "Image Name";
            this.clhImage.Width = 150;
            // 
            // clhPrice
            // 
            this.clhPrice.Text = "Đơn giá vnđ/cái";
            this.clhPrice.Width = 186;
            // 
            // clhIdCategory
            // 
            this.clhIdCategory.Text = "ID Category";
            this.clhIdCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhIdCategory.Width = 120;
            // 
            // pnDSMTop
            // 
            this.pnDSMTop.Controls.Add(this.cbFilterDishes);
            this.pnDSMTop.Controls.Add(this.cbFindFoodName);
            this.pnDSMTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDSMTop.Location = new System.Drawing.Point(3, 22);
            this.pnDSMTop.Name = "pnDSMTop";
            this.pnDSMTop.Size = new System.Drawing.Size(765, 36);
            this.pnDSMTop.TabIndex = 25;
            // 
            // cbFilterDishes
            // 
            this.cbFilterDishes.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.cbFilterDishes.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbFilterDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbFilterDishes.FormattingEnabled = true;
            this.cbFilterDishes.Items.AddRange(new object[] {
            "All"});
            this.cbFilterDishes.Location = new System.Drawing.Point(0, 0);
            this.cbFilterDishes.Name = "cbFilterDishes";
            this.cbFilterDishes.Size = new System.Drawing.Size(190, 28);
            this.cbFilterDishes.TabIndex = 17;
            this.cbFilterDishes.SelectedIndexChanged += new System.EventHandler(this.cbFilterDishes_SelectedIndexChanged);
            // 
            // cbFindFoodName
            // 
            this.cbFindFoodName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFindFoodName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFindFoodName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbFindFoodName.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbFindFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbFindFoodName.FormattingEnabled = true;
            this.cbFindFoodName.Location = new System.Drawing.Point(476, 0);
            this.cbFindFoodName.Name = "cbFindFoodName";
            this.cbFindFoodName.Size = new System.Drawing.Size(289, 28);
            this.cbFindFoodName.TabIndex = 16;
            this.cbFindFoodName.SelectedIndexChanged += new System.EventHandler(this.cbFindFoodName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1443, 40);
            this.label1.TabIndex = 21;
            this.label1.Text = "Danh sách món";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTop
            // 
            this.pnTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTop.Controls.Add(this.btnCloseFormMenuFood);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1445, 42);
            this.pnTop.TabIndex = 23;
            // 
            // btnCloseFormMenuFood
            // 
            this.btnCloseFormMenuFood.BackColor = System.Drawing.Color.Black;
            this.btnCloseFormMenuFood.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseFormMenuFood.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCloseFormMenuFood.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCloseFormMenuFood.Location = new System.Drawing.Point(1384, 0);
            this.btnCloseFormMenuFood.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseFormMenuFood.Name = "btnCloseFormMenuFood";
            this.btnCloseFormMenuFood.Size = new System.Drawing.Size(59, 40);
            this.btnCloseFormMenuFood.TabIndex = 4;
            this.btnCloseFormMenuFood.Text = "X";
            this.btnCloseFormMenuFood.UseVisualStyleBackColor = false;
            this.btnCloseFormMenuFood.Click += new System.EventHandler(this.btnCloseFormMenuFood_Click);
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.groupBox1);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 42);
            this.pnLeft.MinimumSize = new System.Drawing.Size(550, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnLeft.Size = new System.Drawing.Size(771, 723);
            this.pnLeft.TabIndex = 24;
            // 
            // grbEditFood
            // 
            this.grbEditFood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbEditFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grbEditFood.Controls.Add(this.panel1);
            this.grbEditFood.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbEditFood.ForeColor = System.Drawing.Color.White;
            this.grbEditFood.Location = new System.Drawing.Point(8, 347);
            this.grbEditFood.Name = "grbEditFood";
            this.grbEditFood.Size = new System.Drawing.Size(665, 364);
            this.grbEditFood.TabIndex = 20;
            this.grbEditFood.TabStop = false;
            this.grbEditFood.Text = "Chỉnh sửa";
            this.grbEditFood.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtEditIdCategory);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtEditId);
            this.panel1.Controls.Add(this.txtEditImageName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnEditExit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtEditFoodName);
            this.panel1.Controls.Add(this.txtEditPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 335);
            this.panel1.TabIndex = 21;
            // 
            // txtEditIdCategory
            // 
            this.txtEditIdCategory.Location = new System.Drawing.Point(211, 221);
            this.txtEditIdCategory.Name = "txtEditIdCategory";
            this.txtEditIdCategory.Size = new System.Drawing.Size(319, 26);
            this.txtEditIdCategory.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(76, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = "Id Category:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(92, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Id món ăn:";
            // 
            // txtEditId
            // 
            this.txtEditId.Location = new System.Drawing.Point(211, 38);
            this.txtEditId.Name = "txtEditId";
            this.txtEditId.ReadOnly = true;
            this.txtEditId.Size = new System.Drawing.Size(319, 26);
            this.txtEditId.TabIndex = 10;
            // 
            // txtEditImageName
            // 
            this.txtEditImageName.Location = new System.Drawing.Point(211, 126);
            this.txtEditImageName.Name = "txtEditImageName";
            this.txtEditImageName.ReadOnly = true;
            this.txtEditImageName.Size = new System.Drawing.Size(319, 26);
            this.txtEditImageName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(67, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Image Name:";
            // 
            // btnEditExit
            // 
            this.btnEditExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditExit.BackColor = System.Drawing.Color.Black;
            this.btnEditExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEditExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEditExit.Location = new System.Drawing.Point(617, 0);
            this.btnEditExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditExit.Name = "btnEditExit";
            this.btnEditExit.Size = new System.Drawing.Size(31, 33);
            this.btnEditExit.TabIndex = 6;
            this.btnEditExit.Text = "X";
            this.btnEditExit.UseVisualStyleBackColor = false;
            this.btnEditExit.Click += new System.EventHandler(this.btnEditExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDelete.Location = new System.Drawing.Point(380, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 43);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa món";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(77, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món ăn:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Location = new System.Drawing.Point(211, 286);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 43);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEditFoodName
            // 
            this.txtEditFoodName.Location = new System.Drawing.Point(211, 81);
            this.txtEditFoodName.Name = "txtEditFoodName";
            this.txtEditFoodName.Size = new System.Drawing.Size(319, 26);
            this.txtEditFoodName.TabIndex = 1;
            // 
            // txtEditPrice
            // 
            this.txtEditPrice.Location = new System.Drawing.Point(211, 172);
            this.txtEditPrice.Name = "txtEditPrice";
            this.txtEditPrice.Size = new System.Drawing.Size(319, 26);
            this.txtEditPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(44, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá vnđ/cái:";
            // 
            // pnThemMon
            // 
            this.pnThemMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnThemMon.Controls.Add(this.panel3);
            this.pnThemMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnThemMon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnThemMon.ForeColor = System.Drawing.Color.White;
            this.pnThemMon.Location = new System.Drawing.Point(10, 10);
            this.pnThemMon.Name = "pnThemMon";
            this.pnThemMon.Size = new System.Drawing.Size(664, 306);
            this.pnThemMon.TabIndex = 20;
            this.pnThemMon.TabStop = false;
            this.pnThemMon.Text = "Thêm món ăn";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtNewIdCategory);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtNewImages);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtNewFoodName);
            this.panel3.Controls.Add(this.txtNewPrice);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 277);
            this.panel3.TabIndex = 21;
            // 
            // txtNewIdCategory
            // 
            this.txtNewIdCategory.Location = new System.Drawing.Point(209, 186);
            this.txtNewIdCategory.Name = "txtNewIdCategory";
            this.txtNewIdCategory.Size = new System.Drawing.Size(319, 26);
            this.txtNewIdCategory.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(80, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "IdCategory:";
            // 
            // txtNewImages
            // 
            this.txtNewImages.Location = new System.Drawing.Point(209, 103);
            this.txtNewImages.Name = "txtNewImages";
            this.txtNewImages.ReadOnly = true;
            this.txtNewImages.Size = new System.Drawing.Size(319, 26);
            this.txtNewImages.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(65, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Image Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(74, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tên món ăn:";
            // 
            // txtNewFoodName
            // 
            this.txtNewFoodName.Location = new System.Drawing.Point(209, 54);
            this.txtNewFoodName.Name = "txtNewFoodName";
            this.txtNewFoodName.Size = new System.Drawing.Size(319, 26);
            this.txtNewFoodName.TabIndex = 12;
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(209, 149);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(319, 26);
            this.txtNewPrice.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(42, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Đơn giá vnđ/cái:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Location = new System.Drawing.Point(300, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 43);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm món";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.grbEditFood);
            this.pnRight.Controls.Add(this.pnThemMon);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRight.Location = new System.Drawing.Point(771, 42);
            this.pnRight.Name = "pnRight";
            this.pnRight.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pnRight.Size = new System.Drawing.Size(674, 723);
            this.pnRight.TabIndex = 22;
            // 
            // fMenuFood
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1445, 765);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnTop);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fMenuFood";
            this.Text = "fMenuFood";
            this.Load += new System.EventHandler(this.fMenuFood_Load);
            this.groupBox1.ResumeLayout(false);
            this.pnDSMTop.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.grbEditFood.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnThemMon.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCloseFormMenuFood;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFilterDishes;
        private System.Windows.Forms.ComboBox cbFindFoodName;
        private System.Windows.Forms.ListView lsvFood;
        private System.Windows.Forms.ColumnHeader clhId;
        private System.Windows.Forms.ColumnHeader clhFoodName;
        private System.Windows.Forms.ColumnHeader clhPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnDSMTop;
        private System.Windows.Forms.GroupBox grbEditFood;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEditFoodName;
        private System.Windows.Forms.TextBox txtEditPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox pnThemMon;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Button btnEditExit;
        private System.Windows.Forms.ColumnHeader clhImage;
        private System.Windows.Forms.TextBox txtEditImageName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNewImages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewFoodName;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNewIdCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEditIdCategory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColumnHeader clhIdCategory;
    }
}