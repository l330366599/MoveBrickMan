using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveBrickMan
{
    public partial class XMB : Form
    {
        public XMB()
        {
            InitializeComponent();
        }

        private void XMB_Load(object sender, EventArgs e)
        {
          
        }

        private void MSAccounting_Click(object sender, EventArgs e)
        {
            Accounting ACC = new Accounting();
            ACC.MdiParent = this;
            ACC.Show();
            ACC.Dock = DockStyle.Fill;
        }
    }
}
