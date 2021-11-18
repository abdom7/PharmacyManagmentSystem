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
    public partial class modifycompany : UserControl
    {
        companyDB inst = new companyDB();
        string query;
        DataSet ds; 

        public modifycompany()
        {
            InitializeComponent();
        }

        private void modifycompany_Load(object sender, EventArgs e)
        {

        }
        private void clearall()
        {
            companyidtxt.Clear();
            nametxt.Clear();
            phonetxt.Clear();
            locationtxt.Clear();
            emailtxt.Clear();
        }

            
        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (companyidtxt.Text != "")
            {
                query = "select * from CompanyInfo where compid = '" + companyidtxt.Text + "'";
                ds = inst.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    nametxt.Text = ds.Tables[0].Rows[0][1].ToString();
                    phonetxt.Text = ds.Tables[0].Rows[0][2].ToString();
                    locationtxt.Text = ds.Tables[0].Rows[0][4].ToString();
                    emailtxt.Text = ds.Tables[0].Rows[0][3].ToString();
                    

                }
                else
                {
                    MessageBox.Show("No Company with Id : " + companyidtxt.Text + "exist.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearall();
                }

            }
            else
            {
                clearall();
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            clearall();
        }
        private bool is_txt_empty()
        {
            return companyidtxt.Text == "" || phonetxt.Text == "" || emailtxt.Text == "" || locationtxt.Text == "" || nametxt.Text == "";


        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (is_txt_empty())
            {
                MessageBox.Show("please enter all data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                inst.id = companyidtxt.Text;
                inst.name = nametxt.Text;
                inst.phone = phonetxt.Text;
                inst.email = emailtxt.Text;
                inst.location = locationtxt.Text;
                
                inst.updatecompany(inst, "Medicine Records updated Successfully");
                clearall();           }
        }

        private void companyidtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

