using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace coffee
{
    public partial class frmabout:Form
    {
        public frmabout()
        {
            InitializeComponent();
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
