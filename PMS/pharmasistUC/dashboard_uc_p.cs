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
    public partial class dashboard_uc_p : UserControl
    {
        medicineDB inst = new medicineDB();
        string query;
        DataSet ds;
        Int64 count = 0; 
        public dashboard_uc_p()
        {
            InitializeComponent();
        }

        private void dashboard_uc_p_Load(object sender, EventArgs e)
        {
            loadchart();
        }
        public void loadchart()
        {
            query = "select count(medname) from MedicineInfo where edate >= getdate()";
            ds = inst.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Expired Medicine"].Points.AddXY("Medicine Validity Chart", count);

            query = "select count(medname) from MedicineInfo where edate < getdate()";

            ds = inst.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            this.chart1.Series["Valid Medicine"].Points.AddXY("Medicine Validity Chart", count);
        }

        private void reloadbtn_Click(object sender, EventArgs e)
        {
            chart1.Series["Valid Medicine"].Points.Clear();
            chart1.Series["Expired Medicine"].Points.Clear();
            loadchart();

        }
    }
}
