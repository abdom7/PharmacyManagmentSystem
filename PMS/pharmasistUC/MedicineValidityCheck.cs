using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.pharmasistUC
{
    public partial class MedicineValidityCheck : UserControl
    {
        medicineDB inst = new medicineDB();
        string query;
        DataSet ds; 
        public MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void checktxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checktxt.SelectedIndex == 0)
            {


                query = "select * from MedicineInfo where edate >= getdate()";
                setDataGridView(query, "Valid Medicines.");

            }
            else if (checktxt.SelectedIndex == 1)
            {
                query = "select * from MedicineInfo where edate < getdate()";
                setDataGridView(query, "Expired Medicines.");

            }
            else if(checktxt.SelectedIndex == 2)
            {
                query = "select * from MedicineInfo";
                setDataGridView(query, "All Medicine");

            }
        }
        private void setDataGridView(string query , string label)
        {
            ds = inst.getData(query);
            MedicineGridView.DataSource = ds.Tables[0];
            setlabel.Text = label;
        }
        private void MedicineValidityCheck_Load(object sender, EventArgs e)
        {
            setlabel.Text = ""; 
        }
    }
}
