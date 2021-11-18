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
    public partial class addMedicineUC_P : UserControl
    {
        medicineDB inst = new medicineDB();
        string query;
        DataSet ds; 
        public addMedicineUC_P()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            if (is_txt_empty())
            {
                MessageBox.Show("Please Enter All Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                inst.medcode = medcodetxt.Text;
                inst.medname = mednametxt.Text;
                inst.medcompany = medcompanytxt.SelectedValue.ToString();
                inst.Bprice = Int64.Parse(Bpricetxt.Text);
                inst.Sprice = Int64.Parse(Spricetxt.Text);
                inst.Quantity = Int64.Parse(medquanttxt.Text);
                inst.edate = edatetxt.Text;
                inst.mdate = mdatetxt.Text;
                inst.medtype = medtypetxt.SelectedItem.ToString();
                inst.mednumber = mednumbertxt.Text;
                inst.addMedicine(inst, "Medicine Added To Database.");
                clearAll();
            }
        }
        public void clearAll()
        {

            medcodetxt.Clear();
            mednametxt.Clear();
            medcompanytxt.SelectedIndex = -1;
            Bpricetxt.Clear();
            Spricetxt.Clear();
            medquanttxt.Clear();
            edatetxt.ResetText();
            mdatetxt.ResetText();
            medtypetxt.SelectedIndex = -1;
            mednumbertxt.Clear(); 

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public bool is_txt_empty()
        {
            if (medcodetxt.Text == ""|| mednametxt.Text == "" || medcompanytxt.SelectedIndex == -1 ||Bpricetxt.Text == "" || medquanttxt.Text == "" || medtypetxt.SelectedIndex == -1 ||mednumbertxt.Text == "") {
                return true; 
            }

                return false ; 
        }

        private void addMedicineUC_P_Load(object sender, EventArgs e)
        {
          inst.populateToComboBox(medcompanytxt);
        }
    }
}
