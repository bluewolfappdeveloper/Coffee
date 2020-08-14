namespace coffee
{
    partial class frmitem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmitem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnadd = new DevComponents.DotNetBar.ButtonX();
            this.btndelete = new DevComponents.DotNetBar.ButtonX();
            this.btnrepair = new DevComponents.DotNetBar.ButtonX();
            this.btnshow = new DevComponents.DotNetBar.ButtonX();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtfind = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.numupdown1 = new System.Windows.Forms.NumericUpDown();
            this.txtname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dgvitem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 156);
            this.panel1.TabIndex = 0;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(328, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "NHẬP HÀNG";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.flowLayoutPanel1.Controls.Add(this.btnadd);
            this.flowLayoutPanel1.Controls.Add(this.btndelete);
            this.flowLayoutPanel1.Controls.Add(this.btnrepair);
            this.flowLayoutPanel1.Controls.Add(this.btnshow);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(385, 85);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnadd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnadd.Image = global::coffee.Properties.Resources.if_add1__32378__2_;
            this.btnadd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnadd.Location = new System.Drawing.Point(3, 3);
            this.btnadd.Name = "btnadd";
            this.btnadd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlT);
            this.btnadd.Size = new System.Drawing.Size(90, 79);
            this.btnadd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnadd.TabIndex = 4;
            this.btnadd.TabStop = false;
            this.btnadd.Text = "<div>THÊM</div>";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndelete.Image = global::coffee.Properties.Resources.if_f_cross_256_282471;
            this.btndelete.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btndelete.Location = new System.Drawing.Point(99, 3);
            this.btndelete.Name = "btndelete";
            this.btndelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btndelete.Size = new System.Drawing.Size(90, 79);
            this.btndelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndelete.TabIndex = 0;
            this.btndelete.TabStop = false;
            this.btndelete.Text = "<div>XÓA</div>";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnrepair
            // 
            this.btnrepair.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnrepair.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnrepair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrepair.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnrepair.Image = global::coffee.Properties.Resources.if_Options_105206;
            this.btnrepair.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnrepair.Location = new System.Drawing.Point(195, 3);
            this.btnrepair.Name = "btnrepair";
            this.btnrepair.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnrepair.Size = new System.Drawing.Size(90, 79);
            this.btnrepair.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnrepair.TabIndex = 0;
            this.btnrepair.TabStop = false;
            this.btnrepair.Text = "<div>SỬA</div>";
            this.btnrepair.Click += new System.EventHandler(this.btnrepair_Click);
            // 
            // btnshow
            // 
            this.btnshow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnshow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshow.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnshow.Image = global::coffee.Properties.Resources.if_reload_15542;
            this.btnshow.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnshow.Location = new System.Drawing.Point(291, 3);
            this.btnshow.Name = "btnshow";
            this.btnshow.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnshow.Size = new System.Drawing.Size(90, 79);
            this.btnshow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnshow.TabIndex = 4;
            this.btnshow.Text = "<div>XEM</div>";
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panel5.Controls.Add(this.txtfind);
            this.panel5.Controls.Add(this.labelX1);
            this.panel5.Location = new System.Drawing.Point(394, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(512, 85);
            this.panel5.TabIndex = 0;
            // 
            // txtfind
            // 
            this.txtfind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtfind.Border.Class = "TextBoxBorder";
            this.txtfind.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtfind.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtfind.Location = new System.Drawing.Point(129, 27);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(371, 32);
            this.txtfind.TabIndex = 1;
            this.txtfind.TabStop = false;
            this.txtfind.TextChanged += new System.EventHandler(this.txtfind_TextChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelX1.Location = new System.Drawing.Point(14, 27);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(131, 30);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tìm kiếm";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtcode);
            this.panel3.Controls.Add(this.numupdown1);
            this.panel3.Controls.Add(this.txtname);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.labelX3);
            this.panel3.Controls.Add(this.labelX2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(394, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 409);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(170, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 13;
            this.label3.Resize += new System.EventHandler(this.label3_Resize);
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(252, 17);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(100, 20);
            this.txtcode.TabIndex = 3;
            this.txtcode.TabStop = false;
            this.txtcode.Visible = false;
            // 
            // numupdown1
            // 
            this.numupdown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numupdown1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.numupdown1.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numupdown1.Location = new System.Drawing.Point(132, 132);
            this.numupdown1.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.numupdown1.Minimum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            -2147483648});
            this.numupdown1.Name = "numupdown1";
            this.numupdown1.Size = new System.Drawing.Size(371, 32);
            this.numupdown1.TabIndex = 1;
            this.numupdown1.ThousandsSeparator = true;
            // 
            // txtname
            // 
            this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtname.Border.Class = "TextBoxBorder";
            this.txtname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtname.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtname.Location = new System.Drawing.Point(132, 58);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(371, 32);
            this.txtname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(0, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "* Tổng mặt hàng:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelX3.Location = new System.Drawing.Point(17, 132);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(131, 31);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Đơn giá";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelX2.Location = new System.Drawing.Point(17, 58);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(131, 28);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tên hàng";
            // 
            // dgvitem
            // 
            this.dgvitem.AllowUserToDeleteRows = false;
            this.dgvitem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvitem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvitem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvitem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.STT,
            this.nameitem,
            this.priceitem});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvitem.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvitem.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvitem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvitem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvitem.Location = new System.Drawing.Point(0, 156);
            this.dgvitem.Name = "dgvitem";
            this.dgvitem.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.Default;
            this.dgvitem.Size = new System.Drawing.Size(388, 409);
            this.dgvitem.TabIndex = 3;
            this.dgvitem.TabStop = false;
            this.dgvitem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitem_CellClick);
            this.dgvitem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitem_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.STT.DefaultCellStyle = dataGridViewCellStyle3;
            this.STT.FillWeight = 121.8274F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 45;
            // 
            // nameitem
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.nameitem.DefaultCellStyle = dataGridViewCellStyle4;
            this.nameitem.FillWeight = 92.7242F;
            this.nameitem.HeaderText = "Tên Hàng";
            this.nameitem.Name = "nameitem";
            // 
            // priceitem
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.Format = "#,### ";
            dataGridViewCellStyle5.NullValue = null;
            this.priceitem.DefaultCellStyle = dataGridViewCellStyle5;
            this.priceitem.FillWeight = 92.7242F;
            this.priceitem.HeaderText = "Đơn giá";
            this.priceitem.Name = "priceitem";
            // 
            // frmitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(909, 565);
            this.Controls.Add(this.dgvitem);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmitem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHẬP HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmitem_FormClosed);
            this.Load += new System.EventHandler(this.frmitem_Load);
            this.ResizeEnd += new System.EventHandler(this.frmitem_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.frmitem_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevComponents.DotNetBar.ButtonX btnadd;
        private DevComponents.DotNetBar.ButtonX btndelete;
        private DevComponents.DotNetBar.ButtonX btnrepair;
        private DevComponents.DotNetBar.ButtonX btnshow;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtfind;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numupdown1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtname;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceitem;
    }
}