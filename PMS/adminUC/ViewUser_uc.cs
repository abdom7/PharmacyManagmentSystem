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
    public partial class ViewUser_uc : UserControl
    {
        users_db inst = new users_db();
        string query;
        string currentuser = ""; 
        DataSet ds; 
        public string id
        {
            set { currentuser = value;  }
        }
        public ViewUser_uc()
        {
            InitializeComponent();
        }

        private void ViewUser_uc_Load(object sender, EventArgs e)
        {
            query = "select * from Users";
            ds = inst.getData(query);
            UserGridView.DataSource = ds.Tables[0];

        }

        private void fullnametxt_TextChanged(object sender, EventArgs e)
        {
            query = "select * from Users where Username like '" + fullnametxt.Text + "%'";
            ds = inst.getData(query);
            UserGridView.DataSource = ds.Tables[0];
        }
        string userN; 
        private void UserGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                userN = UserGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {if (MessageBox.Show("are you sure ? ", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {


                if (currentuser != userN)
                {
                    query = "delete  from Users where Username ='" + userN + "' ";
                    inst.setData(query, "User Records Deleted.");
                    ViewUser_uc_Load(this, null);
                }
                else
                {
                    MessageBox.Show("you are trying to delete \n Your own Profile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void syncbtn_Click(object sender, EventArgs e)
        {
            ViewUser_uc_Load(this, null);
        }
    }
}
