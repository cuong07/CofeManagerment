namespace QuanLyQuanCafe
{
    partial class fTableManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pnLeft = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnTakeAway = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnRevenua = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbMenu = new System.Windows.Forms.PictureBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnLeft.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.Black;
            this.pnLeft.Controls.Add(this.panel7);
            this.pnLeft.Controls.Add(this.panel4);
            this.pnLeft.Controls.Add(this.btnSetting);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.pnLeft.MaximumSize = new System.Drawing.Size(149, 0);
            this.pnLeft.MinimumSize = new System.Drawing.Size(45, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(45, 625);
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
            this.panel7.Location = new System.Drawing.Point(0, 72);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(45, 219);
            this.panel7.TabIndex = 6;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::QuanLyQuanCafe.Properties.Resources.menu;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 87);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(45, 44);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "          Thực đơn";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.BackColor = System.Drawing.Color.Transparent;
            this.btnTakeAway.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTakeAway.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTakeAway.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeAway.ForeColor = System.Drawing.Color.White;
            this.btnTakeAway.Image = global::QuanLyQuanCafe.Properties.Resources.revenue;
            this.btnTakeAway.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTakeAway.Location = new System.Drawing.Point(0, 44);
            this.btnTakeAway.Margin = new System.Windows.Forms.Padding(0);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnTakeAway.Size = new System.Drawing.Size(45, 44);
            this.btnTakeAway.TabIndex = 2;
            this.btnTakeAway.Text = "          Bán mang đi";
            this.btnTakeAway.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTakeAway.UseVisualStyleBackColor = false;
            this.btnTakeAway.Click += new System.EventHandler(this.btnTakeaway_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::QuanLyQuanCafe.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(45, 44);
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
            this.btnBill.Image = global::QuanLyQuanCafe.Properties.Resources.bill;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(0, 131);
            this.btnBill.Margin = new System.Windows.Forms.Padding(0);
            this.btnBill.Name = "btnBill";
            this.btnBill.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnBill.Size = new System.Drawing.Size(45, 44);
            this.btnBill.TabIndex = 4;
            this.btnBill.Text = "          Hóa đơn";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnRevenua
            // 
            this.btnRevenua.BackColor = System.Drawing.Color.Transparent;
            this.btnRevenua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevenua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRevenua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRevenua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenua.ForeColor = System.Drawing.Color.White;
            this.btnRevenua.Image = global::QuanLyQuanCafe.Properties.Resources.revenue;
            this.btnRevenua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenua.Location = new System.Drawing.Point(0, 175);
            this.btnRevenua.Margin = new System.Windows.Forms.Padding(0);
            this.btnRevenua.Name = "btnRevenua";
            this.btnRevenua.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnRevenua.Size = new System.Drawing.Size(45, 44);
            this.btnRevenua.TabIndex = 5;
            this.btnRevenua.Text = "          Doanh thu";
            this.btnRevenua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenua.UseVisualStyleBackColor = false;
            this.btnRevenua.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.ptbMenu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(45, 72);
            this.panel4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(53, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 65);
            this.label2.TabIndex = 6;
            this.label2.Text = "MENU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ptbMenu
            // 
            this.ptbMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMenu.Image = global::QuanLyQuanCafe.Properties.Resources.menu_30;
            this.ptbMenu.Location = new System.Drawing.Point(6, 20);
            this.ptbMenu.Name = "ptbMenu";
            this.ptbMenu.Size = new System.Drawing.Size(30, 30);
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
            this.btnSetting.Image = global::QuanLyQuanCafe.Properties.Resources.setting;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 576);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(45, 49);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "          Cài đặt";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // pnBody
            // 
            this.pnBody.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.bg;
            this.pnBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(45, 0);
            this.pnBody.Margin = new System.Windows.Forms.Padding(2);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1101, 625);
            this.pnBody.TabIndex = 8;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 625);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Quán Cà Phê";
            this.pnLeft.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
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