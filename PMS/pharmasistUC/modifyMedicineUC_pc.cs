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
    public partial class modifyMedicineUC_pc : UserControl
    {
        medicineDB inst = new medicineDB();
        string query;
        DataSet ds; 
        public modifyMedicineUC_pc()
        {
            InitializeComponent();
        }

        private void modifyMedicineUC_pc_Load(object sender, EventArgs e)
        {
            inst.populateToComboBox(medcompanytxt);
        }
        private void clearAll()
        {
            medcodetxt.Clear();
            mednametxt.Clear();
            medicinenumbertxt.Clear();
            edatetxt.ResetText();
            mdatebtn.ResetText();
            availQtytxt.Clear();
            addQtytxt.Clear();
            medcompanytxt.SelectedIndex = -1;
            Spricetxt.Clear();
            addQtytxt.Text = "0";
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (medcodetxt.Text != "")
            {
                query = "select * from MedicineInfo where medcode = '" + medcodetxt.Text + "'";
                ds = inst.getData(query);
                if(ds.Tables[0].Rows.Count != 0)
                {
                    mednametxt.Text = ds.Tables[0].Rows[0][1].ToString();
                    medicinenumbertxt.Text = ds.Tables[0].Rows[0][8].ToString();
                   edatetxt.Text = ds.Tables[0].Rows[0][7].ToString();
                    mdatebtn.Text = ds.Tables[0].Rows[0][6].ToString();
                    availQtytxt.Text = ds.Tables[0].Rows[0][3].ToString();
                    Spricetxt.Text = ds.Tables[0].Rows[0][5].ToString();

                }
                else
                {
                    MessageBox.Show("No Medicine with Id : " + medcodetxt.Text + "exist.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (is_txt_empty() ){
                MessageBox.Show("please enter all data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else{
                Int64 totalqty = Int64.Parse(availQtytxt.Text) + Int64.Parse(addQtytxt.Text);
                inst.medcode = medcodetxt.Text;
                inst.medname = mednametxt.Text;
                inst.mdate = mdatebtn.Text;
                inst.edate = edatetxt.Text;
                inst.mednumber = medicinenumbertxt.Text;
                inst.Quantity = totalqty;
                inst.medcompany = medcompanytxt.SelectedValue.ToString();
                inst.Sprice = Int64.Parse(Spricetxt.Text);
                inst.updateMedicine(inst, "Medicine Records updated Successfully");
                clearAll(); }
        }
        private bool is_txt_empty()
        {
            return mednametxt.Text == "" || medicinenumbertxt.Text == "" || medcompanytxt.SelectedIndex == -1  || Spricetxt.Text == "" || availQtytxt.Text == "" || addQtytxt.Text== "0";


        }
    }
}
