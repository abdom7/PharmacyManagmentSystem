using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.adminUC.companyop
{
    class companyDB
    {
        string query = "";


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-70BV2PL\HOMEPC;Initial Catalog=pms;Persist Security Info=True;User ID=sa;Password=01120051499");
        SqlCommand cmd;
        public string id
        {

            set; get;
        }
        public string phone
        {
            set; get;


        }
        public string name
        {

            set; get;

        }
        public string location
        {
            set; get;
        }
        public string email
        {
            set; get;
        }
        public void addCompany(companyDB md,string msg)
        {
            con.Open();

            query = "insert into CompanyInfo (compid,name,phonenumber,email,location) values (@a,@b,@c,@d,@e)";
            SqlCommand cmd = new SqlCommand(query,con);
            
            cmd.Parameters.AddWithValue("@a", md.id);
            cmd.Parameters.AddWithValue("@b", md.name);
            cmd.Parameters.AddWithValue("@c", md.phone);
            cmd.Parameters.AddWithValue("@d", md.location);
            cmd.Parameters.AddWithValue("@e", md.email);





            cmd.ExecuteNonQuery();
            MessageBox.Show(msg,"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();



        }



        public DataSet getData(string query)
        {


            cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(string query, string msg)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Usrname Allready  exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void updatecompany(companyDB md, string msg)
        {
            con.Open();
            query = "update CompanyInfo set name=@a,phonenumber=@b,location=@c,email=@d where compid = @e";


            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@a", md.name);
            cmd.Parameters.AddWithValue("@b", md.phone);
            cmd.Parameters.AddWithValue("@c", md.location);
            cmd.Parameters.AddWithValue("@d", md.email);
            cmd.Parameters.AddWithValue("@e", md.id);


            cmd.ExecuteNonQuery();
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();

        }
    }
}
