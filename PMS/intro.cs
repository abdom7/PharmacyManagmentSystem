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
    public partial class intro : Form
    {
        int startPoint = 0; 
        public intro()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 1; 
            bunifuCircleProgress1.Value = startPoint; 
            if(bunifuCircleProgress1.Value == 100)
            {
                timer1.Stop();


                Login myLogin = new Login();
                this.Hide();

                myLogin.Show();
                bunifuCircleProgress1.Value = 0;


            }


        }

        private void bunifuCircleProgress1_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {

        }

        private void intro_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

       
    }
}
