namespace coffee
{
    partial class frmsellbill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsellbill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsukien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblloaikhach = new System.Windows.Forms.Label();
            this.lblkhachhang = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtprice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbname = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnloc = new System.Windows.Forms.Button();
            this.btnadd = new DevComponents.DotNetBar.ButtonX();
            this.btndelete = new DevComponents.DotNetBar.ButtonX();
            this.btnshow = new DevComponents.DotNetBar.ButtonX();
            this.btnrepair = new DevComponents.DotNetBar.ButtonX();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Label();
            this.sum2 = new System.Windows.Forms.TextBox();
            this.dgvitem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.btnprint = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.lblngaylap = new System.Windows.Forms.Label();
            this.chkthanhtoan = new System.Windows.Forms.CheckBox();
            this.lbltinhtrang = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtsum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.nudcount = new System.Windows.Forms.NumericUpDown();
            this.lblsum = new System.Windows.Forms.Label();
            this.lblquality = new System.Windows.Forms.Label();
            this.cbidkhach = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudcount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtsukien);
            this.panel1.Controls.Add(this.lblloaikhach);
            this.panel1.Controls.Add(this.lblkhachhang);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(4, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 97);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(186, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "name";
            // 
            // txtsukien
            // 
            this.txtsukien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtsukien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsukien.Location = new System.Drawing.Point(175, 55);
            this.txtsukien.Name = "txtsukien";
            this.txtsukien.Size = new System.Drawing.Size(294, 26);
            this.txtsukien.TabIndex = 43;
            this.txtsukien.TabStop = false;
            this.txtsukien.TextChanged += new System.EventHandler(this.txtsukien_TextChanged);
            // 
            // lblloaikhach
            // 
            this.lblloaikhach.AutoSize = true;
            this.lblloaikhach.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblloaikhach.Location = new System.Drawing.Point(9, 60);
            this.lblloaikhach.Name = "lblloaikhach";
            this.lblloaikhach.Size = new System.Drawing.Size(90, 25);
            this.lblloaikhach.TabIndex = 17;
            this.lblloaikhach.Text = "Sự kiện:";
            // 
            // lblkhachhang
            // 
            this.lblkhachhang.AutoSize = true;
            this.lblkhachhang.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblkhachhang.Location = new System.Drawing.Point(9, 20);
            this.lblkhachhang.Name = "lblkhachhang";
            this.lblkhachhang.Size = new System.Drawing.Size(171, 25);
            this.lblkhachhang.TabIndex = 12;
            this.lblkhachhang.Text = "Tên khách hàng:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panel3.Controls.Add(this.txtprice);
            this.panel3.Controls.Add(this.cbname);
            this.panel3.Controls.Add(this.lblprice);
            this.panel3.Controls.Add(this.lblname);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel3.Location = new System.Drawing.Point(3, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 96);
            this.panel3.TabIndex = 34;
            // 
            // txtprice
            // 
            this.txtprice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtprice.Border.Class = "TextBoxBorder";
            this.txtprice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtprice.Location = new System.Drawing.Point(176, 60);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(294, 29);
            this.txtprice.TabIndex = 3;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            this.txtprice.Leave += new System.EventHandler(this.txtprice_Leave);
            this.txtprice.MouseLeave += new System.EventHandler(this.txtprice_Leave);
            // 
            // cbname
            // 
            this.cbname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbname.DisplayMember = "Text";
            this.cbname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbname.FormattingEnabled = true;
            this.cbname.ItemHeight = 23;
            this.cbname.Location = new System.Drawing.Point(176, 16);
            this.cbname.Name = "cbname";
            this.cbname.Size = new System.Drawing.Size(294, 29);
            this.cbname.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbname.TabIndex = 1;
            this.cbname.SelectedIndexChanged += new System.EventHandler(this.cbname_SelectedIndexChanged);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblprice.Location = new System.Drawing.Point(10, 55);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(87, 25);
            this.lblprice.TabIndex = 10;
            this.lblprice.Text = "Giá bán";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblname.Location = new System.Drawing.Point(10, 16);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(146, 25);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Tên sản phẩm";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.btnloc);
            this.panel5.Controls.Add(this.btnadd);
            this.panel5.Controls.Add(this.btndelete);
            this.panel5.Controls.Add(this.btnshow);
            this.panel5.Controls.Add(this.btnrepair);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel5.Location = new System.Drawing.Point(4, 260);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(926, 52);
            this.panel5.TabIndex = 35;
            // 
            // btnloc
            // 
            this.btnloc.Image = ((System.Drawing.Image)(resources.GetObject("btnloc.Image")));
            this.btnloc.Location = new System.Drawing.Point(220, 16);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(32, 23);
            this.btnloc.TabIndex = 16;
            this.btnloc.TabStop = false;
            this.btnloc.UseVisualStyleBackColor = true;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // btnadd
            // 
            this.btnadd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnadd.Image = global::coffee.Properties.Resources.if_add1__32378__2_;
            this.btnadd.Location = new System.Drawing.Point(343, 3);
            this.btnadd.Name = "btnadd";
            this.btnadd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlT);
            this.btnadd.Size = new System.Drawing.Size(139, 46);
            this.btnadd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnadd.TabIndex = 14;
            this.btnadd.TabStop = false;
            this.btnadd.Text = "THÊM";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndelete.Image = global::coffee.Properties.Resources.if_f_cross_256_282471;
            this.btndelete.Location = new System.Drawing.Point(488, 3);
            this.btndelete.Name = "btndelete";
            this.btndelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btndelete.Size = new System.Drawing.Size(139, 46);
            this.btndelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndelete.TabIndex = 12;
            this.btndelete.TabStop = false;
            this.btndelete.Text = "<div>XÓA</div>";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnshow
            // 
            this.btnshow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnshow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnshow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshow.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnshow.Image = global::coffee.Properties.Resources.if_reload_15542;
            this.btnshow.Location = new System.Drawing.Point(778, 3);
            this.btnshow.Name = "btnshow";
            this.btnshow.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnshow.Size = new System.Drawing.Size(139, 46);
            this.btnshow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnshow.TabIndex = 15;
            this.btnshow.TabStop = false;
            this.btnshow.Text = "<div>XEM</div>";
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnrepair
            // 
            this.btnrepair.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnrepair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrepair.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnrepair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrepair.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnrepair.Image = global::coffee.Properties.Resources.if_Options_105206;
            this.btnrepair.Location = new System.Drawing.Point(633, 3);
            this.btnrepair.Name = "btnrepair";
            this.btnrepair.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnrepair.Size = new System.Drawing.Size(139, 46);
            this.btnrepair.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnrepair.TabIndex = 13;
            this.btnrepair.TabStop = false;
            this.btnrepair.Text = "<div>SỬA</div>";
            this.btnrepair.Click += new System.EventHandler(this.btnrepair_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Danh sách sản phẩm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(372, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 45);
            this.label6.TabIndex = 38;
            this.label6.Text = "BÁN HÀNG";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sum
            // 
            this.sum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sum.AutoSize = true;
            this.sum.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sum.Location = new System.Drawing.Point(465, 548);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(144, 26);
            this.sum.TabIndex = 41;
            this.sum.Text = "TỔNG TIỀN";
            // 
            // sum2
            // 
            this.sum2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sum2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sum2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sum2.ForeColor = System.Drawing.Color.White;
            this.sum2.Location = new System.Drawing.Point(613, 543);
            this.sum2.Name = "sum2";
            this.sum2.ReadOnly = true;
            this.sum2.Size = new System.Drawing.Size(315, 35);
            this.sum2.TabIndex = 40;
            this.sum2.TabStop = false;
            this.sum2.Text = "0";
            this.sum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvitem
            // 
            this.dgvitem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvitem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvitem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvitem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvitem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.id,
            this.TenHang,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien});
            this.dgvitem.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvitem.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvitem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvitem.Location = new System.Drawing.Point(3, 318);
            this.dgvitem.Name = "dgvitem";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvitem.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvitem.Size = new System.Drawing.Size(927, 211);
            this.dgvitem.TabIndex = 42;
            this.dgvitem.TabStop = false;
            this.dgvitem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitem_CellContentClick);
            this.dgvitem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitem_CellContentClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.STT.DefaultCellStyle = dataGridViewCellStyle2;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 100;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // TenHang
            // 
            this.TenHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.TenHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenHang.HeaderText = "Tên Hàng";
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            this.TenHang.Width = 250;
            // 
            // DonGia
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.Format = "#,### ";
            dataGridViewCellStyle4.NullValue = null;
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle4;
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle5;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 150;
            // 
            // ThanhTien
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.Format = "#,### ";
            dataGridViewCellStyle6.NullValue = null;
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle6;
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(726, 26);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(100, 20);
            this.txtSTT.TabIndex = 43;
            this.txtSTT.TabStop = false;
            this.txtSTT.Visible = false;
            // 
            // btnprint
            // 
            this.btnprint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnprint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnprint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnprint.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnprint.Location = new System.Drawing.Point(22, 535);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(137, 46);
            this.btnprint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnprint.TabIndex = 44;
            this.btnprint.Text = "IN";
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.date);
            this.panel2.Controls.Add(this.lblngaylap);
            this.panel2.Controls.Add(this.chkthanhtoan);
            this.panel2.Controls.Add(this.lbltinhtrang);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel2.Location = new System.Drawing.Point(482, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 97);
            this.panel2.TabIndex = 0;
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date.CustomFormat = "dd/MM/yyyy        hh:mm:ss";
            this.date.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(146, 52);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(273, 30);
            this.date.TabIndex = 40;
            this.date.TabStop = false;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // lblngaylap
            // 
            this.lblngaylap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblngaylap.AutoSize = true;
            this.lblngaylap.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblngaylap.Location = new System.Drawing.Point(22, 53);
            this.lblngaylap.Name = "lblngaylap";
            this.lblngaylap.Size = new System.Drawing.Size(102, 25);
            this.lblngaylap.TabIndex = 41;
            this.lblngaylap.Text = "Ngày lập:";
            // 
            // chkthanhtoan
            // 
            this.chkthanhtoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkthanhtoan.AutoSize = true;
            this.chkthanhtoan.Checked = true;
            this.chkthanhtoan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkthanhtoan.Location = new System.Drawing.Point(201, 15);
            this.chkthanhtoan.Name = "chkthanhtoan";
            this.chkthanhtoan.Size = new System.Drawing.Size(156, 28);
            this.chkthanhtoan.TabIndex = 39;
            this.chkthanhtoan.TabStop = false;
            this.chkthanhtoan.Text = "Đã thanh toán";
            this.chkthanhtoan.UseVisualStyleBackColor = true;
            // 
            // lbltinhtrang
            // 
            this.lbltinhtrang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltinhtrang.AutoSize = true;
            this.lbltinhtrang.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbltinhtrang.Location = new System.Drawing.Point(22, 15);
            this.lbltinhtrang.Name = "lbltinhtrang";
            this.lbltinhtrang.Size = new System.Drawing.Size(120, 25);
            this.lbltinhtrang.TabIndex = 38;
            this.lbltinhtrang.Text = "Tình trạng:";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panel4.Controls.Add(this.txtsum);
            this.panel4.Controls.Add(this.nudcount);
            this.panel4.Controls.Add(this.lblsum);
            this.panel4.Controls.Add(this.lblquality);
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel4.Location = new System.Drawing.Point(482, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 96);
            this.panel4.TabIndex = 34;
            // 
            // txtsum
            // 
            this.txtsum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtsum.Border.Class = "TextBoxBorder";
            this.txtsum.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsum.Location = new System.Drawing.Point(146, 51);
            this.txtsum.Name = "txtsum";
            this.txtsum.Size = new System.Drawing.Size(273, 29);
            this.txtsum.TabIndex = 16;
            // 
            // nudcount
            // 
            this.nudcount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudcount.Location = new System.Drawing.Point(146, 8);
            this.nudcount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudcount.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudcount.Name = "nudcount";
            this.nudcount.Size = new System.Drawing.Size(273, 29);
            this.nudcount.TabIndex = 15;
            this.nudcount.ThousandsSeparator = true;
            this.nudcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblsum
            // 
            this.lblsum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsum.AutoSize = true;
            this.lblsum.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblsum.Location = new System.Drawing.Point(25, 55);
            this.lblsum.Name = "lblsum";
            this.lblsum.Size = new System.Drawing.Size(115, 25);
            this.lblsum.TabIndex = 18;
            this.lblsum.Text = "Thành tiền";
            // 
            // lblquality
            // 
            this.lblquality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblquality.AutoSize = true;
            this.lblquality.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblquality.Location = new System.Drawing.Point(25, 11);
            this.lblquality.Name = "lblquality";
            this.lblquality.Size = new System.Drawing.Size(95, 25);
            this.lblquality.TabIndex = 17;
            this.lblquality.Text = "Số lượng";
            // 
            // cbidkhach
            // 
            this.cbidkhach.DisplayMember = "Text";
            this.cbidkhach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbidkhach.FormattingEnabled = true;
            this.cbidkhach.ItemHeight = 14;
            this.cbidkhach.Location = new System.Drawing.Point(655, 29);
            this.cbidkhach.Name = "cbidkhach";
            this.cbidkhach.Size = new System.Drawing.Size(121, 20);
            this.cbidkhach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbidkhach.TabIndex = 46;
            this.cbidkhach.Visible = false;
            // 
            // frmsellbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(940, 603);
            this.Controls.Add(this.cbidkhach);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.dgvitem);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.sum2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmsellbill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmsell_FormClosed);
            this.ResizeEnd += new System.EventHandler(this.frmsellbill_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.frmsell_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudcount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblkhachhang;
        private System.Windows.Forms.Label lblloaikhach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.TextBox sum2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtprice;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbname;
        private DevComponents.DotNetBar.ButtonX btnadd;
        private DevComponents.DotNetBar.ButtonX btndelete;
        private DevComponents.DotNetBar.ButtonX btnrepair;
        private DevComponents.DotNetBar.ButtonX btnshow;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvitem;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private DevComponents.DotNetBar.ButtonX btnprint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label lblngaylap;
        private System.Windows.Forms.CheckBox chkthanhtoan;
        private System.Windows.Forms.Label lbltinhtrang;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsum;
        private System.Windows.Forms.NumericUpDown nudcount;
        private System.Windows.Forms.Label lblsum;
        private System.Windows.Forms.Label lblquality;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbidkhach;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsukien;
        private System.Windows.Forms.Button btnloc;
    }
}