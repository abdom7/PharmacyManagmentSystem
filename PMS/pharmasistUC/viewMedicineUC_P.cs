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
    public partial class viewMedicineUC_P : UserControl
    {
        medicineDB inst = new medicineDB();
        string query;
        DataSet ds; 
        public viewMedicineUC_P()
        {
            InitializeComponent();
        }

        private void viewMedicineUC_P_Load(object sender, EventArgs e)
        {
            query = "select * from MedicineInfo";
            setDataGridView(query);


        }

        private void mednametxt_TextChanged(object sender, EventArgs e)
        {
            query = "select * from MedicineInfo where medname like '" + mednametxt.Text + "%'";
            setDataGridView(query);
        }
        private void setDataGridView(string query)
        {
            ds = inst.getData(query);
            MedicineGridView.DataSource = ds.Tables[0];
        }

        string medcode; 
        private void MedicineGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medcode = MedicineGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                
            }
            catch { }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("are you sure ?", "Delete Confirmation" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning)== DialogResult.Yes)
            {

                query = "delete from MedicineInfo where medcode = '" + medcode + "'";
                inst.setData(query, "Medicine Record Deleted.");
                viewMedicineUC_P_Load(this, null);
            }
        }

        private void syncbtn_Click(object sender, EventArgs e)
        {
            viewMedicineUC_P_Load(this, null);

        }
    }
}
