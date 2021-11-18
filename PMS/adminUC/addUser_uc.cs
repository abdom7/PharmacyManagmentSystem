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
    public partial class addUser_uc : UserControl
    {
        users_db inst = new users_db();
        public addUser_uc()
        {
            InitializeComponent();
        }

        private void addUser_uc_Load(object sender, EventArgs e)
        {

        }

        private void companynametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void namelb_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            inst.name = fullnametxt.Text;
            inst.userRole = userroletxt.SelectedItem.ToString();
          
            inst.email = emailtxt.Text;
            inst.phonenumber = phonetxt.Text;
            inst.username = usernametxt.Text;
            inst.password = passwordtxt.Text;
            inst.dob = dobbtn.Text;
            inst.adduser(inst, "Sign Up Sucessfully");
        }

        private void bunifuLabel7_Click(object sender, EventArgs e)
        {

        }

        public void clearAll()
        {
            userroletxt.SelectedIndex = -1;
            fullnametxt.Clear();
            emailtxt.Clear();
            usernametxt.Clear();
            passwordtxt.Clear();
            dobbtn.ResetText();
            phonetxt.Clear();
            pictureBox1.Image = null;
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            clearAll();

        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from Users where username = '" + usernametxt.Text + "'";
            DataSet ds = inst.getData(query);
            if(ds.Tables[0].Rows.Count == 0)
            {


                pictureBox1.ImageLocation = @"D:\PMS\data\10.png";

            }
            else
            {
                pictureBox1.ImageLocation = @"D:\PMS\data\11.png";

            }
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
