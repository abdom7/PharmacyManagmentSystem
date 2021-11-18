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
    public partial class viewEmployee : UserControl
    {
        employeeDB inst = new employeeDB();
        string query;
        DataSet ds; 
        public viewEmployee()
        {
            InitializeComponent();
        }

        private void viewEmployee_Load(object sender, EventArgs e)
        {
            query = "select * from EmployeeInfo";
            setDataGridView(query);
        }
        private void setDataGridView(string query)
        {
            ds = inst.getData(query);
            Employeegridview.DataSource = ds.Tables[0];
        }

        private void syncbtn_Click(object sender, EventArgs e)
        {
            viewEmployee_Load(this, null);
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {
            query = "select * from EmployeeInfo where name like '" + nametxt.Text + "%'";
            setDataGridView(query);
        }

        int employeeid; 
        private void Employeegridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                employeeid = int.Parse(Employeegridview.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            catch { }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                query = "delete from EmployeeInfo where id = '" + employeeid + "'";
                inst.setData(query, "Employee Record Deleted.");
                viewEmployee_Load(this, null);
            }
        }
    }
}
