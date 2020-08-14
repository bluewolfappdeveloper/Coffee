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
    public partial class frmbillcheck : Form
    {
        public frmbillcheck()
        {
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            if (frmcheck.query == "") { frmcheck.query = "select * from kiemtra"; }
            DataTable tb = DataProviderDAO.Instance.ExecuteQuery(frmcheck.query);
            reportcheck report = new reportcheck();
            report.SetDataSource(tb);
            reportviewer.ReportSource = report;
        }


        
    }
}
