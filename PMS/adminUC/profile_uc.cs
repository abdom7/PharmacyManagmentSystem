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
    public partial class profile_uc : UserControl
    {
        users_db inst = new users_db();
        string query;
        DataSet ds; 

        public profile_uc()
        {
            InitializeComponent();
        }
        public string id
        {
            set { usernamelb.Text = value;  }
        }
        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void profile_uc_Load(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void profile_uc_Enter(object sender, EventArgs e)
        {
            query = "select * from Users where Username = '" + usernamelb.Text + "'";
            ds = inst.getData(query);
            userroletxt.Text = ds.Tables[0].Rows[0][1].ToString();
            fullnametxt.Text = ds.Tables[0].Rows[0][2].ToString();
            dobtxt.Text = ds.Tables[0].Rows[0][3].ToString();
            phonetxt.Text = ds.Tables[0].Rows[0][4].ToString();
            emailtxt.Text = ds.Tables[0].Rows[0][5].ToString();
            passwordtxt.Text = ds.Tables[0].Rows[0][7].ToString();

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            profile_uc_Enter(this, null);
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            inst.username = usernamelb.Text;
            inst.userRole = userroletxt.SelectedItem.ToString();
            inst.password = passwordtxt.Text;
            inst.email = emailtxt.Text;
            inst.phonenumber = phonetxt.Text;
            inst.dob = dobtxt.Text;
            inst.name = fullnametxt.Text;
            inst.updateUser(inst, "User Record Updated Sucessfully");
        }
    }
}
