namespace QuanLyQuanCafe
{
    partial class fHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHome));
            this.pnLeft = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.pnBody = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnTakeAway = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnRevenua = new System.Windows.Forms.Button();
            this.ptbMenu = new System.Windows.Forms.PictureBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pnLeft.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.Black;
            this.pnLeft.Controls.Add(this.panel7);
            this.pnLeft.Controls.Add(this.panel4);
            this.pnLeft.Controls.Add(this.btnSetting);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.pnLeft.MaximumSize = new System.Drawing.Size(199, 0);
            this.pnLeft.MinimumSize = new System.Drawing.Size(50, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(199, 769);
            this.pnLeft.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnMenu);
            this.panel7.Controls.Add(this.btnTakeAway);
            this.panel7.Controls.Add(this.btnHome);
            this.panel7.Controls.Add(this.btnBill);
            this.panel7.Controls.Add(this.btnRevenua);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 88);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(199, 270);
            this.panel7.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbAccountName);
            this.panel4.Controls.Add(this.ptbMenu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 88);
            this.panel4.TabIndex = 5;
            // 
            // lbAccountName
            // 
            this.lbAccountName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAccountName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAccountName.Location = new System.Drawing.Point(71, 6);
            this.lbAccountName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(124, 80);
            this.lbAccountName.TabIndex = 6;
            this.lbAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnBody
            // 
            this.pnBody.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.bg;
            this.pnBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(199, 0);
            this.pnBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1329, 769);
            this.pnBody.TabIndex = 8;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::QuanLyQuanCafe.Properties.Resources.fHome_icon_menuFoods;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 108);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(199, 54);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "          Thực đơn";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.BackColor = System.Drawing.Color.Transparent;
            this.btnTakeAway.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTakeAway.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTakeAway.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeAway.ForeColor = System.Drawing.Color.White;
            this.btnTakeAway.Image = global::QuanLyQuanCafe.Properties.Resources.fHome_icon_delivery1;
            this.btnTakeAway.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTakeAway.Location = new System.Drawing.Point(0, 54);
            this.btnTakeAway.Margin = new System.Windows.Forms.Padding(0);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnTakeAway.Size = new System.Drawing.Size(199, 54);
            this.btnTakeAway.TabIndex = 2;
            this.btnTakeAway.Text = "          Mang đi";
            this.btnTakeAway.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTakeAway.UseVisualStyleBackColor = false;
            this.btnTakeAway.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::QuanLyQuanCafe.Properties.Resources.fHome_icon_table;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(199, 54);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "          Tại quán";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.Transparent;
            this.btnBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = global::QuanLyQuanCafe.Properties.Resources.fHome_icon_bill;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(0, 162);
            this.btnBill.Margin = new System.Windows.Forms.Padding(0);
            this.btnBill.Name = "btnBill";
            this.btnBill.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnBill.Size = new System.Drawing.Size(199, 54);
            this.btnBill.TabIndex = 4;
            this.btnBill.Text = "          Hóa đơn";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRevenua
            // 
            this.btnRevenua.BackColor = System.Drawing.Color.Transparent;
            this.btnRevenua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevenua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRevenua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRevenua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenua.ForeColor = System.Drawing.Color.White;
            this.btnRevenua.Image = global::QuanLyQuanCafe.Properties.Resources.fHome_icon_employee;
            this.btnRevenua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenua.Location = new System.Drawing.Point(0, 216);
            this.btnRevenua.Margin = new System.Windows.Forms.Padding(0);
            this.btnRevenua.Name = "btnRevenua";
            this.btnRevenua.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnRevenua.Size = new System.Drawing.Size(199, 54);
            this.btnRevenua.TabIndex = 5;
            this.btnRevenua.Text = "          Nhân sự";
            this.btnRevenua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenua.UseVisualStyleBackColor = false;
            this.btnRevenua.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ptbMenu
            // 
            this.ptbMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMenu.ErrorImage = null;
            this.ptbMenu.Image = global::QuanLyQuanCafe.Properties.Resources.fHome_icon_option;
            this.ptbMenu.Location = new System.Drawing.Point(8, 25);
            this.ptbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.ptbMenu.Name = "ptbMenu";
            this.ptbMenu.Size = new System.Drawing.Size(32, 32);
            this.ptbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbMenu.TabIndex = 6;
            this.ptbMenu.TabStop = false;
            this.ptbMenu.Click += new System.EventHandler(this.ptbMenu_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = global::QuanLyQuanCafe.Properties.Resources.fHome_icon_settings;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 709);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(199, 60);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "          Cài đặt";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 769);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Quản Lý Quán Cà Phê";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTableManager_FormClosing);
            this.Load += new System.EventHandler(this.fTableManager_Load);
            this.pnLeft.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.PictureBox ptbMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnRevenua;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnTakeAway;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnBody;
    }
}