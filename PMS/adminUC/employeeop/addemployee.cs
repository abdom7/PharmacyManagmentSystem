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
    public partial class addemployee : UserControl
    {
        employeeDB inst = new employeeDB();
        string query;
        DataSet ds; 
        public addemployee()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {

            inst.name = nametxt.Text;
            inst.salary = salarytxt.Text;
            inst.phone = phonetxt.Text;
            inst.jobRole = jobroletxt.SelectedItem.ToString();
            inst.gender = gendretxt.SelectedItem.ToString();
            inst.age = agetxt.Text;
            inst.addEmployee(inst, "Employee Added Successfully.");
            clearall();


        }
        private void clearall()
        {
            nametxt.Clear();
            salarytxt.Clear();
            jobroletxt.SelectedIndex = -1;
            gendretxt.SelectedIndex = -1;
            agetxt.Clear();
            pictureBox1.Image = null; 
            phonetxt.Clear();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from EmployeeInfo where name = '" + nametxt.Text + "'";
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

        private void addemployee_Load(object sender, EventArgs e)
        {
            clearall();

        }
    }
}
