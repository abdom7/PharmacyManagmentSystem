using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.adminUC.companyop
{
    public partial class addcompany : UserControl
    {
        companyDB inst = new companyDB();

        public addcompany()
        {
            InitializeComponent();
        }

        private void addcompany_Load(object sender, EventArgs e)
        {
            clearAll();

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            inst.id = compidtxt.Text;
            inst.phone = phonetxt.Text;
            inst.name = nametxt.Text;
            inst.location = locationtxt.Text ;
            inst.email = emailtxt.Text;
            inst.addCompany(inst, "Company Added Successfully.");
            clearAll();
        }
        protected void clearAll()
        {
            compidtxt.Clear();
            phonetxt.Clear();
            emailtxt.Clear();
            locationtxt.Clear();
            nametxt.Clear();
            pictureBox1.Image = null;

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void compidtxt_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from CompanyInfo where compid = '" + compidtxt.Text + "'";
            DataSet ds = inst.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {


                pictureBox1.ImageLocation = @"D:\PMS\data\10.png";

            }
            else
            {
                pictureBox1.ImageLocation = @"D:\PMS\data\11.png";

            }
        }
    }
}
