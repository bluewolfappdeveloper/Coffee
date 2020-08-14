namespace coffee
{
    partial class frmbill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbill));
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idbill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnreload2 = new DevComponents.DotNetBar.ButtonX();
            this.btnreload1 = new DevComponents.DotNetBar.ButtonX();
            this.btnfind2 = new DevComponents.DotNetBar.ButtonX();
            this.btnfind1 = new DevComponents.DotNetBar.ButtonX();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtfind = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnupdate = new DevComponents.DotNetBar.ButtonX();
            this.btnthanhtoan = new DevComponents.DotNetBar.ButtonX();
            this.btnshow = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvbill = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typekhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvbillinfo = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.iNHÓAĐƠNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sỬAHÓAĐƠNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbillinfo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.AutoCompleteCustomSource.AddRange(new string[] {
            "Khách quen",
            "Khách lạ",
            "Khánh quen + Khách lạ"});
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Location = new System.Drawing.Point(581, 23);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(121, 20);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.idbill);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 52);
            this.panel1.TabIndex = 2;
            // 
            // idbill
            // 
            this.idbill.Location = new System.Drawing.Point(667, 12);
            this.idbill.Name = "idbill";
            this.idbill.Size = new System.Drawing.Size(100, 20);
            this.idbill.TabIndex = 18;
            this.idbill.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(260, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "THANH TOÁN HÓA ĐƠN";
            // 
            // btnreload2
            // 
            this.btnreload2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnreload2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnreload2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnreload2.Location = new System.Drawing.Point(387, 6);
            this.btnreload2.Name = "btnreload2";
            this.btnreload2.Size = new System.Drawing.Size(49, 26);
            this.btnreload2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnreload2.TabIndex = 16;
            this.btnreload2.Text = "RELOAD";
            this.btnreload2.Click += new System.EventHandler(this.btnreload2_Click);
            // 
            // btnreload1
            // 
            this.btnreload1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnreload1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnreload1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnreload1.Location = new System.Drawing.Point(387, 6);
            this.btnreload1.Name = "btnreload1";
            this.btnreload1.Size = new System.Drawing.Size(49, 26);
            this.btnreload1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnreload1.TabIndex = 15;
            this.btnreload1.Text = "RELOAD";
            this.btnreload1.Click += new System.EventHandler(this.btnreload1_Click);
            // 
            // btnfind2
            // 
            this.btnfind2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnfind2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnfind2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnfind2.Location = new System.Drawing.Point(332, 6);
            this.btnfind2.Name = "btnfind2";
            this.btnfind2.Size = new System.Drawing.Size(49, 26);
            this.btnfind2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnfind2.TabIndex = 17;
            this.btnfind2.Text = "FIND";
            this.btnfind2.Click += new System.EventHandler(this.btnfind2_Click);
            // 
            // btnfind1
            // 
            this.btnfind1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnfind1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnfind1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnfind1.Location = new System.Drawing.Point(332, 6);
            this.btnfind1.Name = "btnfind1";
            this.btnfind1.Size = new System.Drawing.Size(49, 26);
            this.btnfind1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnfind1.TabIndex = 15;
            this.btnfind1.Text = "FIND";
            this.btnfind1.Click += new System.EventHandler(this.btnfind1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(320, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // txtfind
            // 
            this.txtfind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtfind.Border.Class = "TextBoxBorder";
            this.txtfind.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtfind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtfind.Location = new System.Drawing.Point(3, 6);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(326, 26);
            this.txtfind.TabIndex = 13;
            this.txtfind.TabStop = false;
            this.txtfind.TextChanged += new System.EventHandler(this.txtfind_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonX1);
            this.panel3.Controls.Add(this.btnupdate);
            this.panel3.Controls.Add(this.btnthanhtoan);
            this.panel3.Controls.Add(this.btnshow);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(908, 63);
            this.panel3.TabIndex = 4;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX1.Enabled = false;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonX1.Image = global::coffee.Properties.Resources.Apply;
            this.buttonX1.Location = new System.Drawing.Point(300, 8);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.buttonX1.Size = new System.Drawing.Size(139, 46);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 17;
            this.buttonX1.TabStop = false;
            this.buttonX1.Text = "<div>Cập nhật thanh toán</div>";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click_1);
            // 
            // btnupdate
            // 
            this.btnupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnupdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.Enabled = false;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnupdate.Image = global::coffee.Properties.Resources.if_Options_105206;
            this.btnupdate.Location = new System.Drawing.Point(715, 8);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnupdate.Size = new System.Drawing.Size(181, 46);
            this.btnupdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnupdate.TabIndex = 16;
            this.btnupdate.TabStop = false;
            this.btnupdate.Text = "<div>CẬP NHẬT</div>";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthanhtoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnthanhtoan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthanhtoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthanhtoan.Enabled = false;
            this.btnthanhtoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthanhtoan.Image = global::coffee.Properties.Resources.if_Purse_669953__2_;
            this.btnthanhtoan.Location = new System.Drawing.Point(501, 8);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(181, 46);
            this.btnthanhtoan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthanhtoan.TabIndex = 16;
            this.btnthanhtoan.TabStop = false;
            this.btnthanhtoan.Text = "<div>THANH TOÁN</div>";
            this.btnthanhtoan.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnshow
            // 
            this.btnshow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnshow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnshow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshow.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnshow.Image = global::coffee.Properties.Resources.if_reload_15542;
            this.btnshow.Location = new System.Drawing.Point(77, 8);
            this.btnshow.Name = "btnshow";
            this.btnshow.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnshow.Size = new System.Drawing.Size(139, 46);
            this.btnshow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnshow.TabIndex = 16;
            this.btnshow.TabStop = false;
            this.btnshow.Text = "<div>XEM</div>";
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.dgvbill);
            this.panel2.Controls.Add(this.txtfind);
            this.panel2.Controls.Add(this.btnreload1);
            this.panel2.Controls.Add(this.btnfind1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 349);
            this.panel2.TabIndex = 5;
            // 
            // dgvbill
            // 
            this.dgvbill.AllowUserToAddRows = false;
            this.dgvbill.AllowUserToDeleteRows = false;
            this.dgvbill.AllowUserToResizeColumns = false;
            this.dgvbill.AllowUserToResizeRows = false;
            this.dgvbill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvbill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.name,
            this.SumBill,
            this.CountBill,
            this.typekhach});
            this.dgvbill.Location = new System.Drawing.Point(0, 38);
            this.dgvbill.Name = "dgvbill";
            this.dgvbill.Size = new System.Drawing.Size(439, 311);
            this.dgvbill.TabIndex = 0;
            this.dgvbill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbill_CellClick);
            this.dgvbill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbill_CellClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.STT.DefaultCellStyle = dataGridViewCellStyle2;
            this.STT.FillWeight = 101.5228F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // name
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.name.DefaultCellStyle = dataGridViewCellStyle3;
            this.name.FillWeight = 99.49239F;
            this.name.HeaderText = "Tên Khách";
            this.name.Name = "name";
            // 
            // SumBill
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.Format = "#,###";
            this.SumBill.DefaultCellStyle = dataGridViewCellStyle4;
            this.SumBill.FillWeight = 99.49239F;
            this.SumBill.HeaderText = "Tổng Tiền";
            this.SumBill.Name = "SumBill";
            // 
            // CountBill
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.CountBill.DefaultCellStyle = dataGridViewCellStyle5;
            this.CountBill.FillWeight = 99.49239F;
            this.CountBill.HeaderText = "Số hóa đơn";
            this.CountBill.Name = "CountBill";
            // 
            // typekhach
            // 
            this.typekhach.HeaderText = "Typekhach";
            this.typekhach.Name = "typekhach";
            this.typekhach.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.dgvbillinfo);
            this.panel4.Controls.Add(this.btnreload2);
            this.panel4.Controls.Add(this.btnfind2);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(469, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(439, 349);
            this.panel4.TabIndex = 0;
            // 
            // dgvbillinfo
            // 
            this.dgvbillinfo.AllowUserToAddRows = false;
            this.dgvbillinfo.AllowUserToDeleteRows = false;
            this.dgvbillinfo.AllowUserToResizeColumns = false;
            this.dgvbillinfo.AllowUserToResizeRows = false;
            this.dgvbillinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvbillinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbillinfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbillinfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvbillinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbillinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.STT1,
            this.Date,
            this.time,
            this.SuKien,
            this.TongTien});
            this.dgvbillinfo.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvbillinfo.Location = new System.Drawing.Point(0, 38);
            this.dgvbillinfo.Name = "dgvbillinfo";
            this.dgvbillinfo.Size = new System.Drawing.Size(439, 311);
            this.dgvbillinfo.TabIndex = 0;
            this.dgvbillinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinfobill_CellContentClick);
            this.dgvbillinfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinfobill_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // STT1
            // 
            this.STT1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.STT1.DefaultCellStyle = dataGridViewCellStyle7;
            this.STT1.HeaderText = "STT";
            this.STT1.Name = "STT1";
            this.STT1.Width = 50;
            // 
            // Date
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Date.DefaultCellStyle = dataGridViewCellStyle8;
            this.Date.HeaderText = "Ngày Mua";
            this.Date.Name = "Date";
            // 
            // time
            // 
            this.time.HeaderText = "time";
            this.time.Name = "time";
            this.time.Visible = false;
            // 
            // SuKien
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.SuKien.DefaultCellStyle = dataGridViewCellStyle9;
            this.SuKien.HeaderText = "Sự Kiện";
            this.SuKien.Name = "SuKien";
            // 
            // TongTien
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.Format = "#,###";
            this.TongTien.DefaultCellStyle = dataGridViewCellStyle10;
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNHÓAĐƠNToolStripMenuItem,
            this.sỬAHÓAĐƠNToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 48);
            // 
            // iNHÓAĐƠNToolStripMenuItem
            // 
            this.iNHÓAĐƠNToolStripMenuItem.Image = global::coffee.Properties.Resources.if_Purse_669953__2_;
            this.iNHÓAĐƠNToolStripMenuItem.Name = "iNHÓAĐƠNToolStripMenuItem";
            this.iNHÓAĐƠNToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.iNHÓAĐƠNToolStripMenuItem.Text = "THANH TOÁN";
            // 
            // sỬAHÓAĐƠNToolStripMenuItem
            // 
            this.sỬAHÓAĐƠNToolStripMenuItem.Image = global::coffee.Properties.Resources.if_Options_105206;
            this.sỬAHÓAĐƠNToolStripMenuItem.Name = "sỬAHÓAĐƠNToolStripMenuItem";
            this.sỬAHÓAĐƠNToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.sỬAHÓAĐƠNToolStripMenuItem.Text = "CẬP NHẬT";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(439, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 349);
            this.panel5.TabIndex = 6;
            // 
            // frmbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(908, 464);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxEx1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmbill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THANH TOÁN HÓA ĐƠN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmbill_FormClosed);
            this.Load += new System.EventHandler(this.frmbill_Load);
            this.ResizeEnd += new System.EventHandler(this.frmbill_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.frmbill_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbillinfo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvbillinfo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnshow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNHÓAĐƠNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sỬAHÓAĐƠNToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvbill;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn typekhach;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtfind;
        private DevComponents.DotNetBar.ButtonX btnupdate;
        private DevComponents.DotNetBar.ButtonX btnthanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private DevComponents.DotNetBar.ButtonX btnreload2;
        private DevComponents.DotNetBar.ButtonX btnreload1;
        private DevComponents.DotNetBar.ButtonX btnfind2;
        private DevComponents.DotNetBar.ButtonX btnfind1;
        private System.Windows.Forms.TextBox idbill;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}