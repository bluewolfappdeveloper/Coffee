using coffee.DAO;
using coffee.Report;
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
    public partial class frmcheck : Form
    {
        public frmcheck()
        {
            InitializeComponent();
            btnshow_Click(btnshow, "SELECT * FROM kiemtra", new EventArgs());
        }

        public static string query = "select * from kiemtra";
        private void frmcheck_Activated(object sender, EventArgs e)
        {
            
        }


        private void btnshow_Click(object sender, string query, EventArgs e)
        {
            dgvitem.DataSource = null;
            dgvitem.Rows.Clear();
            dgvitem.Refresh();

            chart1.Series["kt"].Points.Clear();
            //chart1.Series.Add("kt");
            //chart1.Series["kt"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;



            DataTable datatable = DataProviderDAO.Instance.ExecuteQuery(query);
            object sum;
            if (k==1)
            {
                string q = "SELECT SUM(b.quantify) FROM dbo.bill AS b,dbo.bill_info AS i  WHERE b.idtable = i.id AND i.ngaymua <= '" + date2.Value.Date.ToString("yyyy/MM/dd") + "' AND i.ngaymua >= '" + date1.Value.Date.ToString("yyyy/MM/dd") + "'";
                sum = DataProviderDAO.Instance.ExecuteScalar(q);
            } else  sum = DataProviderDAO.Instance.ExecuteScalar("SELECT sum(quantify) FROM  kiemtra");


            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                dgvitem.Rows.Add((i + 1).ToString(), datatable.Rows[i][0], datatable.Rows[i][1], datatable.Rows[i][2]);
                double phantram;
                if (sum.ToString() != "0")
                    phantram = (Double.Parse(datatable.Rows[i][1].ToString()) / Double.Parse(sum.ToString())) * 100;
                else phantram = 0;
                phantram = Math.Round(phantram, 1); chart1.Series["kt"].SetDefault(true);
                chart1.Series["kt"].Points.AddY(Double.Parse(datatable.Rows[i][1].ToString()));
                //chart1.Series["kt"].Points[i].Label = datatable.Rows[i][0].ToString() ;
                chart1.Series["kt"].Points[i].LegendText = datatable.Rows[i][0].ToString() + " " + phantram.ToString() + "%";

            }
        }

        int k;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (date1.Value.Date < date2.Value.Date)
            {
                query = "SELECT b.namedrink, sum(b.quantify) as 'quantify' , SUM(b.total) AS 'total' FROM dbo.bill AS b,dbo.bill_info AS i  WHERE b.idtable = i.id AND i.ngaymua <= '" + date2.Value.Date.ToString("yyyy/MM/dd") + "' AND i.ngaymua >= '" + date1.Value.Date.ToString("yyyy/MM/dd") + "' GROUP BY b.namedrink, b.price ";
                btnshow_Click(btnshow, query, new EventArgs());
                k = 1;
            }
            else
                if (date1.Value.Date == date2.Value.Date)
                {
                    query = "SELECT * FROM kiemtra";
                    btnshow_Click(btnshow, query, new EventArgs());
                    k = 2;
                }
                else
                {
                    query = "SELECT b.namedrink,sum(b.quantify) as 'quantify', SUM(b.total) AS 'total' FROM dbo.bill AS b,dbo.bill_info AS i  WHERE b.idtable = i.id AND i.ngaymua <= '" + date1.Value.Date.ToString("yyyy/MM/dd") + "' AND i.ngaymua >= '" + date2.Value.Date.ToString("yyyy/MM/dd") + "' GROUP BY b.namedrink, b.price";
                    btnshow_Click(btnshow, query, new EventArgs());
                    k = 1;
                }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM kiemtra"; 
            btnshow_Click(btnshow, query , new EventArgs());
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Form billcheck = new frmbillcheck();
            billcheck.ShowDialog();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form home = new frmhome();
            home.Show();
        }

        private void dgvitem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmcheck_SizeChanged(object sender, EventArgs e)
        {
            dgvitem.Width = this.Width / 2 - 30;
            chart1.Width = this.Width / 2 - 30;
            chart1.Location = new Point(dgvitem.Location.X+dgvitem.Width+30,110);

        }

        private void frmcheck_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Width < 942) this.Width = 942;
            if (this.Height < 527) this.Height = 527;
        }

        private void frmcheck_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form home = new frmhome();
            home.Show();
            this.Hide();
        }
    }
}
