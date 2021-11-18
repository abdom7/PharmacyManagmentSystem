using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace PMS.adminUC
{
    public partial class dash_uc : UserControl
    {
        users_db inst = new users_db();
        DataSet ds;
        string query; 
        public dash_uc()
        {
            InitializeComponent();
        }

        private void bunifuLabel10_Click(object sender, EventArgs e)
        {

        }

        private void dash_uc_Load(object sender, EventArgs e)
        {
            query = "select count(UserRole) from Users where UserRole ='Adminstrator'";
            ds = inst.getData(query);
            setLabel(ds, adminnumberlb);



            query = "select count(UserRole) from Users where UserRole ='Pharamsist'";
            ds = inst.getData(query);
            setLabel(ds, pharnumberlb);
        }
        public void setLabel(DataSet ds , BunifuLabel l)
        {
            if(ds.Tables[0].Rows.Count != 0) {
                l.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                l.Text = "0";
            }
        }

        private void syncbtn_Click(object sender, EventArgs e)
        {
            dash_uc_Load(this, null);
        }
    }
}
