using coffee.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace coffee.Report
{
    public partial class frmtakebill : Form
    {
        public frmtakebill()
        {
            InitializeComponent();
        }

        private void frmbillsell_Load(object sender, EventArgs e)
        {
            DataTable tb = DataProviderDAO.Instance.ExecuteQuery("SELECT dbo.bill.namedrink,dbo.bill.price, SUM(quantify) as 'quantify', SUM(dbo.bill.total) as 'total' FROM dbo.bill WHERE idtable = " + frmbill.bill + " GROUP BY dbo.bill.namedrink, price ORDER BY namedrink");
            reporttakebill report = new reporttakebill();
            report.SetDataSource(tb);
            if (frmbill.day == null) { report.SetParameterValue("date", DateTime.Now.ToShortDateString()); } 
                else report.SetParameterValue("date", frmbill.day);

            if (frmbill.khachhang == "") { report.SetParameterValue("name", ""); }
            else report.SetParameterValue("name", frmbill.khachhang);

            if (frmbill.sukien == "") { report.SetParameterValue("sukien", ""); }
            else report.SetParameterValue("sukien",frmbill.sukien);

            if (frmbill.tg == "") { report.SetParameterValue("time", DateTime.Now.ToShortTimeString()); }
            else report.SetParameterValue("time",frmbill.tg);

            object tong = DataProviderDAO.Instance.ExecuteScalar("SELECT SUM(total) FROM bill WHERE idtable = "+frmbill.bill);

            report.SetParameterValue("sum", tong.ToString());
            reportviewer.ReportSource = report;
        }

        private void frmtakebill_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmbill.frm == "1")
            {
                this.Hide();
                Form bill = new frmbill();
                bill.Show();
            }
            if (frmbill.frm == "2")
            {
                this.Hide();
                Form sellbill = new frmsellbill();
                sellbill.Show();
            }
            
        }

        private void reportviewer_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
