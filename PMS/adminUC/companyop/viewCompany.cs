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
    public partial class viewCompany : UserControl
    {
        companyDB inst = new companyDB();
        string query;
        DataSet ds; 
        public viewCompany()
        {
            InitializeComponent();
        }

        private void viewCompany_Load(object sender, EventArgs e)
        {
            query = "select * from CompanyInfo";
            setDataGridView(query);
        }
        private void setDataGridView(string query)
        {
            ds = inst.getData(query);
            companygridview.DataSource = ds.Tables[0];
        }

        private void syncbtn_Click(object sender, EventArgs e)
        {
            viewCompany_Load(this, null);
        }

        private void companynametxt_TextChanged(object sender, EventArgs e)
        {
            query = "select * from CompanyInfo where name like '" + companynametxt.Text + "%'";
            setDataGridView(query);
        }
        string compname; 

        private void companygridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                compname = companygridview.Rows[e.RowIndex].Cells[5].Value.ToString();

            }
            catch { }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                query = "delete from CompanyInfo where name = '" + compname + "'";
                inst.setData(query, "Company Record Deleted.");
                viewCompany_Load(this, null);
            }
        }
    }
}
