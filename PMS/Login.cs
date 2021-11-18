using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS.adminUC; 
namespace PMS
{
    public partial class Login : Form
    {
        users_db inst = new users_db();
        DataSet ds;
        string query;
        public Login()
        {
            InitializeComponent();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            passwordlb.Visible = true; 
        }

        private void L_Reset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtpassword.Clear();
            hidelabel();
            txtUsername.Focus();

        }

        private void L_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
        public void hidelabel()
        {
            usernamelb.Visible = false;
            passwordlb.Visible = false; 

        }

        private void Login_Load(object sender, EventArgs e)
        {
            hidelabel();
        }

        private void testbtn_Click(object sender, EventArgs e)
        {
            hidelabel();


             query = "select * from Users";
            ds = inst.getData(query);
            if(ds.Tables[0].Rows.Count == 0)
            {
                if(txtUsername.Text == "root"&& txtpassword.Text == "root")
                {
                    adminstrator adminf = new adminstrator();
                    adminf.Show();
                    this.Hide();

                }
            }
            else
            {

                 query = "select * from Users where username = '" + txtUsername.Text + "' and password = '"+txtpassword.Text+"'";
                ds = inst.getData(query);
                if(ds.Tables[0].Rows.Count != 0)
                {
                    string role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Adminstrator")
                    {
                        adminstrator adminf = new adminstrator(txtUsername.Text);
                        adminf.Show();
                        this.Hide();
                    }
                    else if (role == "Pharamsist")
                    {
                        Pharamsist pharama = new Pharamsist();
                        pharama.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // if(txtpassword.Text == "12345" && txtUsername.Text == "admin")
            // {
            //     adminstrator adminf = new adminstrator();
            //     adminf.Show();
            //     this.Hide();

            // }
            //else
            // {

            //     MessageBox.Show("Wrong Username Or Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            // }
            //         
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            usernamelb.Visible = true; 

           
        }
    }
}
