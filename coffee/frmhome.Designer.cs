namespace coffee
{
    partial class frmhome
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
            DevComponents.DotNetBar.Controls.ClockStyleData clockStyleData1 = new DevComponents.DotNetBar.Controls.ClockStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData1 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData2 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData3 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ClockHandStyleData clockHandStyleData1 = new DevComponents.DotNetBar.Controls.ClockHandStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData4 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData5 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ClockHandStyleData clockHandStyleData2 = new DevComponents.DotNetBar.Controls.ClockHandStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData6 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ClockHandStyleData clockHandStyleData3 = new DevComponents.DotNetBar.Controls.ClockHandStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData7 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData8 = new DevComponents.DotNetBar.Controls.ColorData();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nh = new System.Windows.Forms.ToolStripMenuItem();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analogClockControl2 = new DevComponents.DotNetBar.Controls.AnalogClockControl();
            this.label1 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnaccount = new DevComponents.DotNetBar.ButtonX();
            this.btnsell = new DevComponents.DotNetBar.ButtonX();
            this.btncheck = new DevComponents.DotNetBar.ButtonX();
            this.btnimport = new DevComponents.DotNetBar.ButtonX();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nh,
            this.bánHàngToolStripMenuItem,
            this.kiểmHàngToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // nh
            // 
            this.nh.Name = "nh";
            this.nh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.nh.Size = new System.Drawing.Size(174, 22);
            this.nh.Text = "Nhập Hàng";
            this.nh.Click += new System.EventHandler(this.nhậpHàngToolStripMenuItem_Click);
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.bánHàngToolStripMenuItem.Text = "Bán Hàng";
            this.bánHàngToolStripMenuItem.Click += new System.EventHandler(this.bánHàngToolStripMenuItem_Click);
            // 
            // kiểmHàngToolStripMenuItem
            // 
            this.kiểmHàngToolStripMenuItem.Name = "kiểmHàngToolStripMenuItem";
            this.kiểmHàngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.kiểmHàngToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.kiểmHàngToolStripMenuItem.Text = "Kiểm Hàng";
            this.kiểmHàngToolStripMenuItem.Click += new System.EventHandler(this.kiểmHàngToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Danh Sách Tài Khoản";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.đổiMậtKhẩuToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.đổiMậtKhẩuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpKháchHàngToolStripMenuItem,
            this.quảnLýHóaĐơnToolStripMenuItem});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            // 
            // nhậpKháchHàngToolStripMenuItem
            // 
            this.nhậpKháchHàngToolStripMenuItem.Name = "nhậpKháchHàngToolStripMenuItem";
            this.nhậpKháchHàngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.K)));
            this.nhậpKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.nhậpKháchHàngToolStripMenuItem.Text = "Nhập Khách Hàng";
            this.nhậpKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.nhậpKháchHàngToolStripMenuItem_Click);
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            this.quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            this.quảnLýHóaĐơnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quảnLýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.quảnLýHóaĐơnToolStripMenuItem.Text = "Quản lý hóa đơn";
            this.quảnLýHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHóaĐơnToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông Tin";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // analogClockControl2
            // 
            this.analogClockControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.analogClockControl2.AutomaticMode = true;
            this.analogClockControl2.BackColor = System.Drawing.SystemColors.MenuText;
            this.analogClockControl2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.analogClockControl2.ClockStyle = DevComponents.DotNetBar.Controls.eClockStyles.Custom;
            colorData1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData1.BrushAngle = 90F;
            colorData1.BrushSBSScale = 1F;
            colorData1.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            colorData1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            clockStyleData1.BezelColor = colorData1;
            colorData2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData2.BorderWidth = 0.01F;
            colorData2.BrushSBSScale = 1F;
            colorData2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            colorData2.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            clockStyleData1.CapColor = colorData2;
            clockStyleData1.CapSize = 0.1F;
            colorData3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData3.BrushAngle = 90F;
            colorData3.BrushSBSScale = 1F;
            colorData3.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData3.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            colorData3.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            clockStyleData1.FaceColor = colorData3;
            clockStyleData1.GlassAngle = 0;
            colorData4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData4.BorderWidth = 0.01F;
            colorData4.BrushAngle = 90F;
            colorData4.BrushSBSScale = 1F;
            colorData4.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData4.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData4.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            clockHandStyleData1.HandColor = colorData4;
            clockHandStyleData1.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style3;
            clockHandStyleData1.Length = 0.45F;
            clockHandStyleData1.Width = 0.175F;
            clockStyleData1.HourHandStyle = clockHandStyleData1;
            colorData5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData5.BorderWidth = 0.01F;
            colorData5.BrushSBSScale = 1F;
            colorData5.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData5.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            clockStyleData1.LargeTickColor = colorData5;
            clockStyleData1.LargeTickWidth = 0.01F;
            colorData6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData6.BorderWidth = 0.01F;
            colorData6.BrushAngle = 90F;
            colorData6.BrushSBSScale = 1F;
            colorData6.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData6.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData6.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            clockHandStyleData2.HandColor = colorData6;
            clockHandStyleData2.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style3;
            clockHandStyleData2.Length = 0.75F;
            clockHandStyleData2.Width = 0.175F;
            clockStyleData1.MinuteHandStyle = clockHandStyleData2;
            clockStyleData1.NumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            clockStyleData1.NumberFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            clockHandStyleData3.DrawOverCap = true;
            colorData7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData7.BorderWidth = 0.01F;
            colorData7.BrushSBSScale = 1F;
            colorData7.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData7.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            clockHandStyleData3.HandColor = colorData7;
            clockHandStyleData3.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style4;
            clockHandStyleData3.Length = 0.9F;
            clockHandStyleData3.Width = 0.01F;
            clockStyleData1.SecondHandStyle = clockHandStyleData3;
            colorData8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData8.BorderWidth = 0.01F;
            colorData8.BrushSBSScale = 1F;
            colorData8.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorData8.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            clockStyleData1.SmallTickColor = colorData8;
            clockStyleData1.SmallTickLength = 0.01F;
            clockStyleData1.SmallTickWidth = 0.01F;
            clockStyleData1.Style = DevComponents.DotNetBar.Controls.eClockStyles.Custom;
            this.analogClockControl2.ClockStyleData = clockStyleData1;
            this.analogClockControl2.IndicatorStyle = DevComponents.DotNetBar.Controls.eClockIndicatorStyles.Numbers;
            this.analogClockControl2.Location = new System.Drawing.Point(777, 24);
            this.analogClockControl2.Name = "analogClockControl2";
            this.analogClockControl2.ShowGlassOverlay = false;
            this.analogClockControl2.Size = new System.Drawing.Size(148, 148);
            this.analogClockControl2.TabIndex = 3;
            this.analogClockControl2.TabStop = false;
            this.analogClockControl2.Text = "analogClockControl2";
            this.analogClockControl2.UseWaitCursor = true;
            this.analogClockControl2.Value = new System.DateTime(2018, 2, 18, 13, 7, 33, 953);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ QUÁN CAFE - NHÂN VIÊN";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblname.ForeColor = System.Drawing.Color.Red;
            this.lblname.Location = new System.Drawing.Point(506, 36);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(40, 41);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "Đ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 427);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnaccount);
            this.panel3.Controls.Add(this.btnsell);
            this.panel3.Controls.Add(this.btncheck);
            this.panel3.Controls.Add(this.btnimport);
            this.panel3.Location = new System.Drawing.Point(139, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(467, 332);
            this.panel3.TabIndex = 7;
            // 
            // btnaccount
            // 
            this.btnaccount.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnaccount.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnaccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaccount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnaccount.Image = global::coffee.Properties.Resources.if_goa_account_msn_79748;
            this.btnaccount.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnaccount.Location = new System.Drawing.Point(296, 188);
            this.btnaccount.Name = "btnaccount";
            this.btnaccount.Size = new System.Drawing.Size(169, 142);
            this.btnaccount.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnaccount.TabIndex = 4;
            this.btnaccount.Text = "TÀI KHOẢN";
            this.btnaccount.Click += new System.EventHandler(this.btnaccount_Click);
            // 
            // btnsell
            // 
            this.btnsell.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsell.AutoCheckOnClick = true;
            this.btnsell.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsell.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsell.Image = global::coffee.Properties.Resources.if_history_58875;
            this.btnsell.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnsell.Location = new System.Drawing.Point(296, 0);
            this.btnsell.Name = "btnsell";
            this.btnsell.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlB);
            this.btnsell.Size = new System.Drawing.Size(169, 142);
            this.btnsell.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnsell.TabIndex = 2;
            this.btnsell.Text = "BÁN HÀNG";
            this.btnsell.Click += new System.EventHandler(this.btnsell_Click);
            // 
            // btncheck
            // 
            this.btncheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btncheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncheck.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btncheck.Image = global::coffee.Properties.Resources.if_Bar_chart_85353;
            this.btncheck.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btncheck.Location = new System.Drawing.Point(1, 188);
            this.btncheck.Name = "btncheck";
            this.btncheck.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlK);
            this.btncheck.Size = new System.Drawing.Size(169, 142);
            this.btncheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btncheck.TabIndex = 3;
            this.btncheck.Text = "<div>KIỂM HÀNG </div>";
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // btnimport
            // 
            this.btnimport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnimport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnimport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnimport.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnimport.Image = global::coffee.Properties.Resources.if_shopping_basket_add_63149;
            this.btnimport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnimport.Location = new System.Drawing.Point(1, 0);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(169, 142);
            this.btnimport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnimport.TabIndex = 1;
            this.btnimport.Text = "<div> NHẬP HÀNG </div>";
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(777, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 32);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Location = new System.Drawing.Point(235, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(139, 51);
            this.panel4.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 39);
            this.panel2.TabIndex = 6;
            // 
            // frmhome
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(925, 510);
            this.Controls.Add(this.analogClockControl2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANG CHỦ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmhome_FormClosed);
            this.Load += new System.EventHandler(this.frmhome_Load);
            this.ResizeEnd += new System.EventHandler(this.frmhome_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.frmhome_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.AnalogClockControl analogClockControl1;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.ButtonItem buttonItem6;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar2;
        private DevComponents.DotNetBar.ButtonItem buttonItem7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nh;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.AnalogClockControl analogClockControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevComponents.DotNetBar.ButtonX btnaccount;
        private DevComponents.DotNetBar.ButtonX btnsell;
        private DevComponents.DotNetBar.ButtonX btncheck;
        private DevComponents.DotNetBar.ButtonX btnimport;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
    }
}