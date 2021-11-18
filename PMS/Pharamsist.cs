using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class Pharamsist : Form
    {
        public Pharamsist()
        {
            InitializeComponent();
        }

        private void Pharamsist_Load(object sender, EventArgs e)
        {
            dashboard_uc_p1.Visible = false;
            addMedicineUC_P1.Visible = false;
            viewMedicineUC_P1.Visible = false;
            modifyMedicineUC_pc1.Visible = false;
            medicineValidityCheck1.Visible = false;
            sellMedicine1.Visible = false; 
            dashboardbtn.PerformClick(); 

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            dashboard_uc_p1.Visible = true;
            dashboard_uc_p1.BringToFront(); 

        }

        private void addmedicinebtn_Click(object sender, EventArgs e)
        {
            addMedicineUC_P1.Visible = true;
            addMedicineUC_P1.BringToFront();
        }

        private void viewmedicinebtn_Click(object sender, EventArgs e)
        {
            viewMedicineUC_P1.Visible = true;
            viewMedicineUC_P1.BringToFront();
        }

        private void modifyMedicinebtn_Click(object sender, EventArgs e)
        {
            modifyMedicineUC_pc1.Visible = true;
            modifyMedicineUC_pc1.BringToFront(); 
        }

        private void medicinevalbtn_Click(object sender, EventArgs e)
        {
            medicineValidityCheck1.Visible = true;
            medicineValidityCheck1.BringToFront();

        }

        private void sellmedicinebtn_Click(object sender, EventArgs e)
        {
            sellMedicine1.Visible = true;
            sellMedicine1.BringToFront(); 

        }

    }
}
