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
    public partial class frmbillsell : Form
    {
        public frmbillsell()
        {
            InitializeComponent();
        }

        private void frmbillsell_Load(object sender, EventArgs e)
        {
            DataTable tb = DataProviderDAO.Instance.ExecuteQuery("select * from tablebill");
            reportbillsell report = new reportbillsell();
            report.SetDataSource(tb);
            if (frmsell.day == null) { report.SetParameterValue("date", DateTime.Now.ToShortDateString()); } 
                else report.SetParameterValue("date", frmsell.day);

            if (frmsell.ten == "") { report.SetParameterValue("name", ""); }
            else report.SetParameterValue("name", frmsell.ten);

            if (frmsell.sukien == "") { report.SetParameterValue("sukien", ""); }
            else report.SetParameterValue("sukien",frmsell.sukien);

            if (frmsell.time == "") { report.SetParameterValue("time", DateTime.Now.ToShortTimeString()); }
            else report.SetParameterValue("time",frmsell.time);

            reportviewer.ReportSource = report;
        }

        private void frmbillsell_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
