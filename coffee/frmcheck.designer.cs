namespace coffee
{
    partial class frmcheck
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcheck));
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvitem = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.btnexit = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnprint = new DevComponents.DotNetBar.ButtonX();
            this.btnshow = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(294, -40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 45);
            this.label6.TabIndex = 39;
            this.label6.Text = "KIỂM TRA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.AutoFitMinFontSize = 5;
            legend1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(477, 110);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Red,
        System.Drawing.Color.Silver,
        System.Drawing.Color.Aqua,
        System.Drawing.SystemColors.ControlDarkDark,
        System.Drawing.Color.Lavender,
        System.Drawing.Color.Purple,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))),
        System.Drawing.SystemColors.ControlLight,
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.SystemColors.Highlight,
        System.Drawing.Color.Violet};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            series1.Legend = "Legend1";
            series1.Name = "kt";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(437, 313);
            this.chart1.TabIndex = 41;
            title1.BackColor = System.Drawing.Color.White;
            title1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Red;
            title1.Name = "Title1";
            title1.Text = "BẢNG THỐNG KÊ";
            this.chart1.Titles.Add(title1);
            // 
            // dgvitem
            // 
            this.dgvitem.AllowDrop = true;
            this.dgvitem.AllowUserToAddRows = false;
            this.dgvitem.AllowUserToDeleteRows = false;
            this.dgvitem.AllowUserToResizeRows = false;
            this.dgvitem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvitem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvitem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvitem.ColumnHeadersHeight = 27;
            this.dgvitem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.tensanpham,
            this.soluong,
            this.thanhtien});
            this.dgvitem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvitem.Location = new System.Drawing.Point(3, 110);
            this.dgvitem.Name = "dgvitem";
            this.dgvitem.ReadOnly = true;
            this.dgvitem.Size = new System.Drawing.Size(449, 313);
            this.dgvitem.TabIndex = 42;
            this.dgvitem.TabStop = false;
            this.dgvitem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitem_CellContentClick);
            // 
            // stt
            // 
            this.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stt.FillWeight = 30F;
            this.stt.Frozen = true;
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 55;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 55;
            // 
            // tensanpham
            // 
            this.tensanpham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tensanpham.DefaultCellStyle = dataGridViewCellStyle2;
            this.tensanpham.FillWeight = 12.81279F;
            this.tensanpham.HeaderText = "Tên sản phẩm";
            this.tensanpham.MinimumWidth = 40;
            this.tensanpham.Name = "tensanpham";
            this.tensanpham.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.soluong.FillWeight = 2.798394F;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.thanhtien.DefaultCellStyle = dataGridViewCellStyle3;
            this.thanhtien.FillWeight = 6.405814F;
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            this.thanhtien.Width = 106;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(363, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 45);
            this.label1.TabIndex = 43;
            this.label1.Text = "KIỂM TRA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // date1
            // 
            this.date1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date1.CustomFormat = "dd/MM/yyyy";
            this.date1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(14, 74);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(146, 30);
            this.date1.TabIndex = 45;
            this.date1.TabStop = false;
            // 
            // date2
            // 
            this.date2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date2.CustomFormat = "dd/MM/yyyy";
            this.date2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2.Location = new System.Drawing.Point(302, 74);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(146, 30);
            this.date2.TabIndex = 45;
            this.date2.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(735, 431);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(179, 45);
            this.btnexit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnexit.TabIndex = 47;
            this.btnexit.TabStop = false;
            this.btnexit.Text = "<div> THOÁT </div>";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonX1.Image = global::coffee.Properties.Resources.if_reload_15542;
            this.buttonX1.Location = new System.Drawing.Point(172, 71);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.buttonX1.Size = new System.Drawing.Size(114, 33);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 46;
            this.buttonX1.TabStop = false;
            this.buttonX1.Text = "<div>XEM</div>";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnprint
            // 
            this.btnprint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnprint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnprint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprint.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnprint.Image = global::coffee.Properties.Resources.if_print_16_22615;
            this.btnprint.Location = new System.Drawing.Point(386, 430);
            this.btnprint.Name = "btnprint";
            this.btnprint.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnprint.Size = new System.Drawing.Size(183, 46);
            this.btnprint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnprint.TabIndex = 46;
            this.btnprint.TabStop = false;
            this.btnprint.Text = "<div> IN BÁO CÁO</div>";
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnshow
            // 
            this.btnshow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnshow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnshow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshow.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnshow.Image = global::coffee.Properties.Resources.if_reload_15542;
            this.btnshow.Location = new System.Drawing.Point(53, 430);
            this.btnshow.Name = "btnshow";
            this.btnshow.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnshow.Size = new System.Drawing.Size(183, 46);
            this.btnshow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnshow.TabIndex = 46;
            this.btnshow.TabStop = false;
            this.btnshow.Text = "<div>XEM</div>";
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // frmcheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(926, 488);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvitem);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm tra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmcheck_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmcheck_FormClosed);
            this.ResizeEnd += new System.EventHandler(this.frmcheck_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.frmcheck_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dgvitem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.DateTimePicker date2;
        private DevComponents.DotNetBar.ButtonX btnshow;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btnprint;
        private DevComponents.DotNetBar.ButtonX btnexit;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
    }
}