namespace coffee
{
    partial class frmcustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcustomer));
            this.txtname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtchucvu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new DevComponents.DotNetBar.ButtonX();
            this.btndelete = new DevComponents.DotNetBar.ButtonX();
            this.btnrepair = new DevComponents.DotNetBar.ButtonX();
            this.btnshow = new DevComponents.DotNetBar.ButtonX();
            this.dgvitem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcode = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).BeginInit();
            this.SuspendLayout();
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
            this.txtname.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtname.Location = new System.Drawing.Point(147, 60);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(476, 29);
            this.txtname.TabIndex = 31;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelX3.Location = new System.Drawing.Point(12, 103);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(98, 31);
            this.labelX3.TabIndex = 32;
            this.labelX3.Text = "Đơn Vị";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelX2.Location = new System.Drawing.Point(12, 60);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(158, 28);
            this.labelX2.TabIndex = 33;
            this.labelX2.Text = "Tên Khách";
            // 
            // txtchucvu
            // 
            this.txtchucvu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtchucvu.Border.Class = "TextBoxBorder";
            this.txtchucvu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtchucvu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtchucvu.Location = new System.Drawing.Point(147, 103);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(476, 29);
            this.txtchucvu.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(211, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 49);
            this.label1.TabIndex = 39;
            this.label1.Text = "KHÁCH HÀNG";
            // 
            // btnadd
            // 
            this.btnadd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnadd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnadd.Image = global::coffee.Properties.Resources.if_add1__32378__2_;
            this.btnadd.Location = new System.Drawing.Point(299, 146);
            this.btnadd.Name = "btnadd";
            this.btnadd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlT);
            this.btnadd.Size = new System.Drawing.Size(79, 38);
            this.btnadd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnadd.TabIndex = 42;
            this.btnadd.TabStop = false;
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
            this.btndelete.Location = new System.Drawing.Point(380, 146);
            this.btndelete.Name = "btndelete";
            this.btndelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btndelete.Size = new System.Drawing.Size(79, 38);
            this.btndelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndelete.TabIndex = 40;
            this.btndelete.TabStop = false;
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
            this.btnrepair.Location = new System.Drawing.Point(461, 146);
            this.btnrepair.Name = "btnrepair";
            this.btnrepair.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnrepair.Size = new System.Drawing.Size(79, 38);
            this.btnrepair.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnrepair.TabIndex = 41;
            this.btnrepair.TabStop = false;
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
            this.btnshow.Location = new System.Drawing.Point(542, 146);
            this.btnshow.Name = "btnshow";
            this.btnshow.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnshow.Size = new System.Drawing.Size(79, 38);
            this.btnshow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnshow.TabIndex = 43;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
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
            this.ten,
            this.priceitem});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvitem.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvitem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvitem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvitem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvitem.Location = new System.Drawing.Point(0, 204);
            this.dgvitem.Name = "dgvitem";
            this.dgvitem.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.Default;
            this.dgvitem.Size = new System.Drawing.Size(635, 207);
            this.dgvitem.TabIndex = 44;
            this.dgvitem.TabStop = false;
            this.dgvitem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitem_CellContentClick);
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
            // ten
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.ten.DefaultCellStyle = dataGridViewCellStyle4;
            this.ten.FillWeight = 92.7242F;
            this.ten.HeaderText = "Tên Khách";
            this.ten.Name = "ten";
            // 
            // priceitem
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.Format = "#,### ";
            dataGridViewCellStyle5.NullValue = null;
            this.priceitem.DefaultCellStyle = dataGridViewCellStyle5;
            this.priceitem.FillWeight = 92.7242F;
            this.priceitem.HeaderText = "Đơn Vị";
            this.priceitem.Name = "priceitem";
            // 
            // txtcode
            // 
            this.txtcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtcode.Border.Class = "TextBoxBorder";
            this.txtcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcode.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtcode.Location = new System.Drawing.Point(66, 21);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(75, 32);
            this.txtcode.TabIndex = 31;
            this.txtcode.Visible = false;
            // 
            // frmcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(635, 411);
            this.Controls.Add(this.dgvitem);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnrepair);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtchucvu);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmcustomer_FormClosed);
            this.ResizeEnd += new System.EventHandler(this.frmcustomer_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtname;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtchucvu;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnadd;
        private DevComponents.DotNetBar.ButtonX btndelete;
        private DevComponents.DotNetBar.ButtonX btnrepair;
        private DevComponents.DotNetBar.ButtonX btnshow;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceitem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcode;
    }
}