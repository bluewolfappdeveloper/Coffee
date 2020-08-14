namespace coffee
{
    partial class frminformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminformation));
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkshowpass = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lbuser = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexit = new DevComponents.DotNetBar.ButtonX();
            this.btnupdate = new DevComponents.DotNetBar.ButtonX();
            this.txtReEnterPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNewPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtpass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtuser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(572, 242);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.TabStop = false;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(572, 192);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.TabStop = false;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkshowpass
            // 
            this.chkshowpass.AutoSize = true;
            this.chkshowpass.Location = new System.Drawing.Point(572, 135);
            this.chkshowpass.Name = "chkshowpass";
            this.chkshowpass.Size = new System.Drawing.Size(15, 14);
            this.chkshowpass.TabIndex = 6;
            this.chkshowpass.TabStop = false;
            this.chkshowpass.UseVisualStyleBackColor = true;
            this.chkshowpass.Click += new System.EventHandler(this.chkshowpass_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(30, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhập lại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(26, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(24, 130);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(90, 22);
            this.lblpass.TabIndex = 8;
            this.lblpass.Text = "Mật khẩu";
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Location = new System.Drawing.Point(25, 71);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(132, 22);
            this.lbuser.TabIndex = 6;
            this.lbuser.Text = "Tên đăng nhập";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(24, 21);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(125, 22);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(105, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 59);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.txtReEnterPass);
            this.panel1.Controls.Add(this.txtNewPass);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtuser);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.chkshowpass);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblpass);
            this.panel1.Controls.Add(this.lbuser);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.txtmanv);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(9, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 333);
            this.panel1.TabIndex = 7;
            // 
            // btnexit
            // 
            this.btnexit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnexit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnexit.Location = new System.Drawing.Point(449, 277);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(112, 46);
            this.btnexit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnexit.TabIndex = 16;
            this.btnexit.TabStop = false;
            this.btnexit.Text = "THOÁT";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnupdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnupdate.Location = new System.Drawing.Point(316, 277);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(112, 46);
            this.btnupdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "CẬP NHẬT";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtReEnterPass
            // 
            // 
            // 
            // 
            this.txtReEnterPass.Border.Class = "TextBoxBorder";
            this.txtReEnterPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtReEnterPass.Location = new System.Drawing.Point(174, 235);
            this.txtReEnterPass.Name = "txtReEnterPass";
            this.txtReEnterPass.PasswordChar = '*';
            this.txtReEnterPass.Size = new System.Drawing.Size(387, 29);
            this.txtReEnterPass.TabIndex = 5;
            // 
            // txtNewPass
            // 
            // 
            // 
            // 
            this.txtNewPass.Border.Class = "TextBoxBorder";
            this.txtNewPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNewPass.Location = new System.Drawing.Point(174, 185);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(387, 29);
            this.txtNewPass.TabIndex = 4;
            // 
            // txtpass
            // 
            // 
            // 
            // 
            this.txtpass.Border.Class = "TextBoxBorder";
            this.txtpass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpass.Location = new System.Drawing.Point(174, 128);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(387, 29);
            this.txtpass.TabIndex = 3;
            // 
            // txtuser
            // 
            // 
            // 
            // 
            this.txtuser.Border.Class = "TextBoxBorder";
            this.txtuser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtuser.Location = new System.Drawing.Point(174, 71);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(387, 29);
            this.txtuser.TabIndex = 2;
            // 
            // txtname
            // 
            // 
            // 
            // 
            this.txtname.Border.Class = "TextBoxBorder";
            this.txtname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtname.Location = new System.Drawing.Point(174, 14);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(387, 29);
            this.txtname.TabIndex = 1;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(204, 14);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.ReadOnly = true;
            this.txtmanv.Size = new System.Drawing.Size(259, 29);
            this.txtmanv.TabIndex = 1;
            this.txtmanv.Visible = false;
            // 
            // frminformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(627, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frminformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frminformation_FormClosed);
            this.ResizeEnd += new System.EventHandler(this.frminformation_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkshowpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtmanv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtReEnterPass;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNewPass;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpass;
        private DevComponents.DotNetBar.Controls.TextBoxX txtuser;
        private DevComponents.DotNetBar.Controls.TextBoxX txtname;
        private DevComponents.DotNetBar.ButtonX btnexit;
        private DevComponents.DotNetBar.ButtonX btnupdate;
    }
}