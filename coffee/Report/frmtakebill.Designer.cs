namespace coffee.Report
{
    partial class frmtakebill
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
            this.reportviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportviewer
            // 
            this.reportviewer.ActiveViewIndex = 0;
            this.reportviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportviewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportviewer.Location = new System.Drawing.Point(0, 0);
            this.reportviewer.Name = "reportviewer";
            this.reportviewer.ReportSource = "F:\\coffee\\coffee\\Report\\reporttakebill.rpt";
            this.reportviewer.Size = new System.Drawing.Size(792, 423);
            this.reportviewer.TabIndex = 0;
            this.reportviewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frmtakebill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 423);
            this.Controls.Add(this.reportviewer);
            this.Name = "frmtakebill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmtakebill_FormClosed);
            this.Load += new System.EventHandler(this.frmbillsell_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private reporttakebill reporttakebill1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportviewer;
    }
}