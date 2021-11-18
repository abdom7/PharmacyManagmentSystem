using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.adminUC
{
    public partial class employeesubmain : UserControl
    {
        public employeesubmain()
        {
            InitializeComponent();
        }

        private void employeesubmain_Load(object sender, EventArgs e)
        {
            addemployee1.Visible = false;
            viewEmployee1.Visible = false;
            modifyemployee1.Visible = false;

            addempbtn.PerformClick();

        }

        private void addempbtn_Click(object sender, EventArgs e)
        {
            addemployee1.Visible = true;
            addemployee1.BringToFront();
        }

        private void viewempbtn_Click(object sender, EventArgs e)
        {
            viewEmployee1.Visible = true;
            viewEmployee1.BringToFront();

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            modifyemployee1.Visible = true;
            modifyemployee1.BringToFront();
        }
    }
}
