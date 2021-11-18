using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.adminUC.employeeop
{
    public partial class modifyemployee : UserControl
    {
        employeeDB inst = new employeeDB();
        string query;
        DataSet ds; 
        public modifyemployee()
        {
            InitializeComponent();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (is_txt_empty())
            {
                MessageBox.Show("please enter all data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                inst.id = employeidtxt.Text;
                inst.name = nametxt.Text;
                inst.phone = phonetxt.Text;
                inst.jobRole = jobroletxt.SelectedItem.ToString();
                inst.salary = salarytxt.Text;

                inst.updateEmployee(inst, "Medicine Records updated Successfully");
                clearall();
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (employeidtxt.Text != "")
            {
                query = "select * from EmployeeInfo where Id  = '" + int.Parse(employeidtxt.Text) + "'";
                ds = inst.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    nametxt.Text = ds.Tables[0].Rows[0][1].ToString();
                    phonetxt.Text = ds.Tables[0].Rows[0][5].ToString();
                    salarytxt.Text = ds.Tables[0].Rows[0][4].ToString();

                }
                else
                {
                    MessageBox.Show("No Employee with Id : " + employeidtxt.Text + "exist.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearall();
                }

            }
            else
            {
                clearall();
            }
           
        }
        private bool is_txt_empty()
        {
            return employeidtxt.Text == "" || phonetxt.Text == "" || nametxt.Text == "" || salarytxt.Text == "" || nametxt.Text == ""|| jobroletxt.SelectedIndex ==-1 ;


        }
        private void clearall()
        {

            employeidtxt.Clear();
            nametxt.Clear();
            phonetxt.Clear();
            salarytxt.Clear();
            phonetxt.Clear();
            jobroletxt.SelectedIndex = -1; 
        }

        private void modifyemployee_Load(object sender, EventArgs e)
        {

        }
    }
}
