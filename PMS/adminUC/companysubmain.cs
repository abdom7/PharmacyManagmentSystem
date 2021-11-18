using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.pharmasistUC.companyconig
{
    public partial class companySubMain : UserControl
    {
        public companySubMain()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            addcompany1.Visible = true;
            addcompany1.BringToFront();
        }

        private void companySubMain_Load(object sender, EventArgs e)
        {
            addcompany1.Visible = false;
            viewCompany1.Visible = false;
            modifycompany1.Visible = false ;

            bunifuImageButton1.PerformClick();
        }

        private void viewcompanybtn_Click(object sender, EventArgs e)
        {
            viewCompany1.Visible = true;
            viewCompany1.BringToFront();

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            modifycompany1.Visible = true;
            modifycompany1.BringToFront();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
        }
    }
}
