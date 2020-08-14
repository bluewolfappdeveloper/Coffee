using System;
using System.Drawing;
using System.Windows.Forms;


namespace coffee
{
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
        }

        private void frmhome_Load(object sender, EventArgs e)
        {
            //frmhome.DefaultFont = "194, 217, 247";
            lblname.Text = frmlogin.name;
            if (frmlogin.status == "0")
            {
                nh.Visible = true;

            }

        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new frmlogin();
            login.Show();
        }

        private void frmhome_SizeChanged(object sender, EventArgs e)
        {
            panel3.Location = new Point(panel2.Width-panel2.Width/3,panel4.Height-panel4.Height/2);
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new frmabout();
            about.ShowDialog();
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            Form item = new frmitem();
            item.Show();
            this.Hide();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form item = new frmitem();
            item.Show();
            this.Hide();
        }

        private void btnaccount_Click(object sender, EventArgs e)
        {
            if (frmlogin.status != "1")
            {
                Form account = new frmaccount();
                account.ShowDialog();
                this.Hide();
            }
            else
            {
                Form list = new frmlistemployer();
                list.ShowDialog();
                this.Hide();
            }
            
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form account = new frmaccount();
            account.ShowDialog();
        }

        private void frmhome_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form login = new frmlogin();
            login.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form info = new frminformation();
            info.ShowDialog();
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form employ = new frmlistemployer();
            //employ.Show();
            //this.Hide();
        }

        private void tàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmlogin.status != "1")
            {
                Form account = new frmaccount();
                account.ShowDialog();
            }
            else
            {
                Form list = new frmlistemployer();
                list.ShowDialog();
                this.Hide();
            }

        }

        private void btnsell_Click(object sender, EventArgs e)
        {
            Form sell = new frmsell();
            sell.Show();
            this.Hide();
        }

        private void nhậpKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form customer = new frmcustomer();
            customer.ShowDialog();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form bill = new frmbill();
            bill.Show();
            this.Hide();
        }

        private void frmhome_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Width < 941) this.Width = 924;
            if (this.Height < 549) this.Height = 549;
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            Form check = new frmcheck();
            check.Show();
            this.Hide();
        }

        private void kiểmHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form check = new frmcheck();
            check.Show();
            this.Hide();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnsell_Click(btnsell, new EventArgs());
        }
    }
}
