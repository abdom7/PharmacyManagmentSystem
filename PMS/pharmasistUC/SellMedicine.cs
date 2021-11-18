using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace PMS.pharmasistUC
{
    public partial class SellMedicine : UserControl
    {
        medicineDB inst = new medicineDB();
        string query;
        DataSet ds; 
        public SellMedicine()
        {
            InitializeComponent();
        }

        private void syncbtn_Click(object sender, EventArgs e)
        {
            SellMedicine_Load(this, null);
        }

        private void SellMedicine_Load(object sender, EventArgs e)
        {
            medicinelistbox.Items.Clear();
            query = "select medname from MedicineInfo where edate >= getdate() and quantity >'0'";
            ds = inst.getData(query);
            for(int i = 0; i<ds.Tables[0].Rows.Count; i++)
            {

                medicinelistbox.Items.Add(ds.Tables[0].Rows[i][0].ToString()); 
            }

        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            medicinelistbox.Items.Clear();
            query = "select medname from MedicineInfo where medname like '" + searchtxt.Text + "%' and edate >= getdate() and quantity > '0' ";
            ds = inst.getData(query);
            for(int i = 0; i<ds.Tables[0].Rows.Count; i++)
            {

                medicinelistbox.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void medicinelistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantitytxt.Clear();
            string name = medicinelistbox.GetItemText(medicinelistbox.SelectedItem);
            mednametxt.Text = name;
            query = "select medcode,sellingprice,edate from MedicineInfo where medname = '" + name + "'";
            ds = inst.getData(query);
            medcodetxt.Text = ds.Tables[0].Rows[0][0].ToString();
            spricetxt.Text = ds.Tables[0].Rows[0][1].ToString();
            edatetxt.Text = ds.Tables[0].Rows[0][2].ToString(); 
             
        }

        private void quantitytxt_TextChanged(object sender, EventArgs e)
        {
            if(quantitytxt.Text != "")
            {
                Int64 price_per_unit = Int64.Parse(spricetxt.Text);
                Int64 number_of_unit = Int64.Parse(quantitytxt.Text);
                Int64 totalnumber = price_per_unit * number_of_unit;
                totaltxt.Text =totalnumber.ToString(); 

            }
            else
            {
                quantitytxt.Clear(); 
            }
        }
        protected int  n, totalamount = 0;
        protected Int64 quantity, newquantity;
        
       

        private void addtocardbtn_Click(object sender, EventArgs e)
        {if(medcodetxt.Text!= "")
            {
                query = "select quantity from MedicineInfo where medcode = '" + medcodetxt.Text + "'";
                ds = inst.getData(query);
                quantity =Int64.Parse( ds.Tables[0].Rows[0][0].ToString());
                newquantity = quantity - Int64.Parse(quantitytxt.Text);
                if(newquantity >= 0)
                {
                    n = MedicineGridView.Rows.Add();
                    MedicineGridView.Rows[n].Cells[0].Value = medcodetxt.Text;
                    MedicineGridView.Rows[n].Cells[1].Value = mednametxt.Text;
                    MedicineGridView.Rows[n].Cells[2].Value = edatetxt.Text;
                    MedicineGridView.Rows[n].Cells[3].Value = spricetxt.Text;
                    MedicineGridView.Rows[n].Cells[4].Value = quantitytxt.Text;
                    MedicineGridView.Rows[n].Cells[5].Value = totaltxt.Text;
                    totalamount = totalamount + int.Parse(totaltxt.Text);
                    RSlabel.Text= "RS. " + totalamount.ToString();

                    query = "update MedicineInfo set quantity = '" + newquantity + "' where medcode = '" + medcodetxt.Text + "'";
                    inst.setData(query, "Medicine Added"); 
                }
                else
                {
                    MessageBox.Show("Medicine is out of Stock.\n Only " + quantity + "Left", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearAll(); 
                SellMedicine_Load(this,null);
            }
else {
                MessageBox.Show("Select Medicine First.", "Information!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void clearAll()
        {
            medcodetxt.Clear();
            mednametxt.Clear();
            spricetxt.Clear();
            quantitytxt.Clear();
            edatetxt.ResetText();
            totaltxt.Clear(); 

        }
        int valueAmount;
        string valueid;

       

        protected Int64 noOfUnit;

        private void Purchasebbtn_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date :- {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payable Amount : " + RSlabel.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(MedicineGridView);
            totalamount = 0;
            RSlabel.Text = "RS.00";
            MedicineGridView.DataSource = 0; 
        }

        private void MedicineGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(MedicineGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueid = MedicineGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfUnit = Int64.Parse(MedicineGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch(Exception ex)
            {

            }
        }
        private void removebtn_Click(object sender, EventArgs e)
        {
            if(valueid != null)
            {
                try
                {
                    MedicineGridView.Rows.RemoveAt(this.MedicineGridView.SelectedRows[0].Index);
                }
                catch  { }

                finally
                {
                    query = "select quantity from MedicineInfo where medcode = '" + valueid + "'";
                    ds = inst.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newquantity = quantity + noOfUnit;
                    query = "update MedicineInfo set quantity = '" + newquantity + "' where medcode = '" + valueid + "'";
                    inst.setData(query, "Medicine Removed from Cart.");
                    totalamount = totalamount - valueAmount;
                    RSlabel.Text = "RS. " + totalamount.ToString();
                }
                SellMedicine_Load(this, null);
            }
        }
    }
}
