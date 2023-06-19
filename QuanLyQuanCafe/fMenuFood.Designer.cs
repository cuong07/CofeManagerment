﻿namespace QuanLyQuanCafe
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.clhSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhFoodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnDSMTop = new System.Windows.Forms.Panel();
            this.cbFilterDishes = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbFindFoodName = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnCloseFormMenuFood = new System.Windows.Forms.Button();
            this.pnRight = new System.Windows.Forms.Panel();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.pnDSMTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.pnDSMTop);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 714);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách món ăn";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhSTT,
            this.clhFoodName,
            this.clhPrice});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 62);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(910, 649);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clhSTT
            // 
            this.clhSTT.Text = "STT";
            this.clhSTT.Width = 55;
            // 
            // clhFoodName
            // 
            this.clhFoodName.Text = "Tên món ăn";
            this.clhFoodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhFoodName.Width = 400;
            // 
            // clhPrice
            // 
            this.clhPrice.Text = "Đơn giá vnđ/cái";
            this.clhPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhPrice.Width = 150;
            // 
            // pnDSMTop
            // 
            this.pnDSMTop.Controls.Add(this.cbFilterDishes);
            this.pnDSMTop.Controls.Add(this.pictureBox1);
            this.pnDSMTop.Controls.Add(this.cbFindFoodName);
            this.pnDSMTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDSMTop.Location = new System.Drawing.Point(3, 26);
            this.pnDSMTop.Name = "pnDSMTop";
            this.pnDSMTop.Size = new System.Drawing.Size(910, 36);
            this.pnDSMTop.TabIndex = 25;
            // 
            // cbFilterDishes
            // 
            this.cbFilterDishes.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.cbFilterDishes.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbFilterDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbFilterDishes.FormattingEnabled = true;
            this.cbFilterDishes.Items.AddRange(new object[] {
            "Món nước",
            "Điểm tâm sáng",
            "Ăn nhẹ",
            "Topping"});
            this.cbFilterDishes.Location = new System.Drawing.Point(0, 0);
            this.cbFilterDishes.Name = "cbFilterDishes";
            this.cbFilterDishes.Size = new System.Drawing.Size(172, 33);
            this.cbFilterDishes.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::QuanLyQuanCafe.Properties.Resources.fFoodMenu_icon_find;
            this.pictureBox1.Location = new System.Drawing.Point(585, 0);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(36, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // cbFindFoodName
            // 
            this.cbFindFoodName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbFindFoodName.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbFindFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbFindFoodName.FormattingEnabled = true;
            this.cbFindFoodName.Location = new System.Drawing.Point(621, 0);
            this.cbFindFoodName.Name = "cbFindFoodName";
            this.cbFindFoodName.Size = new System.Drawing.Size(289, 33);
            this.cbFindFoodName.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 30);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(4, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 260);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chỉnh sửa";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 231);
            this.panel1.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.Location = new System.Drawing.Point(351, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xóa món ăn";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món ăn:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Location = new System.Drawing.Point(182, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 30);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá vnđ/cái:";
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
            // pnRight
            // 
            this.pnRight.Controls.Add(this.groupBox2);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(922, 42);
            this.pnRight.MinimumSize = new System.Drawing.Size(223, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(523, 723);
            this.pnRight.TabIndex = 22;
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.groupBox1);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLeft.Location = new System.Drawing.Point(0, 42);
            this.pnLeft.MinimumSize = new System.Drawing.Size(550, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(922, 723);
            this.pnLeft.TabIndex = 24;
            // 
            // fMenuFood
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1445, 765);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnTop);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fMenuFood";
            this.Text = "fMenuFood";
            this.groupBox1.ResumeLayout(false);
            this.pnDSMTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.pnRight.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCloseFormMenuFood;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbFilterDishes;
        private System.Windows.Forms.ComboBox cbFindFoodName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clhSTT;
        private System.Windows.Forms.ColumnHeader clhFoodName;
        private System.Windows.Forms.ColumnHeader clhPrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnDSMTop;
        private System.Windows.Forms.Panel panel1;
    }
}