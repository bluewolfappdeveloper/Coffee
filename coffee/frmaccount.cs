using coffee.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace coffee
{
    public partial class frmaccount : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmaccount()
        {
            InitializeComponent();
            dgvitem.DataSource = null;
            dgvitem.Rows.Clear();
            dgvitem.Refresh();
            DataTable datatable = DataProviderDAO.Instance.ExecuteQuery("SELECT * FROM dbo.login ORDER BY name");
            string status;
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                if (datatable.Rows[i][7].ToString() == "1") status = "Admin"; else status = "User";
                dgvitem.Rows.Add(datatable.Rows[i][0], (i + 1).ToString(), datatable.Rows[i][1], datatable.Rows[i][2], datatable.Rows[i][3],datatable.Rows[i][4].ToString().Substring(0,10), datatable.Rows[i][5], datatable.Rows[i][6], status);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvitem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmaccount_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width < 847) this.Width = 847;
            if (this.Height < 323) this.Height = 323;
        }

        private void frmaccount_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
