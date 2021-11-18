using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class adminstrator : Form
    {
        string user = "";
        public string id
        {
            get { return user.ToString(); }
        }
        public adminstrator()
        {
            InitializeComponent();

        }
        public adminstrator(string user)
        {
            InitializeComponent();
            userlb.Text = user;
            this.user = user;
            viewUser_uc1.id = id;
            profile_uc1.id = id; 

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void adminstrator_Load(object sender, EventArgs e)
        {

            dash_uc1.Visible = false;
            addUser_uc1.Visible = false;
            viewUser_uc1.Visible = false;
            profile_uc1.Visible = false;
            companySubMain1.Visible = false;
            employeesubmain1.Visible = false;

            bunifuButton1.PerformClick();


        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            dash_uc1.Visible = true;
            dash_uc1.BringToFront();
        }

        private void adduserbtn_Click(object sender, EventArgs e)
        {
            addUser_uc1.Visible = true;
            addUser_uc1.BringToFront();
        }

        private void addUser_uc1_Load(object sender, EventArgs e)
        {

        }

        private void viewUserbtn_Click(object sender, EventArgs e)
        {
            viewUser_uc1.Visible = true;
            viewUser_uc1.BringToFront();
        }

        private void viewUser_uc1_Load(object sender, EventArgs e)
        {

        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            profile_uc1.Visible = true;
            profile_uc1.BringToFront();
        }

        private void companybtn_Click(object sender, EventArgs e)
        {
            companySubMain1.Visible = true;
            companySubMain1.BringToFront();
        }

        private void employeebtn_Click(object sender, EventArgs e)
        {
            employeesubmain1.Visible = true;
            employeesubmain1.BringToFront();
        }
    }
}
