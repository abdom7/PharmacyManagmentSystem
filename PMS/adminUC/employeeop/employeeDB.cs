using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.adminUC.employeeop
{
    class employeeDB
    {
        string query = "";


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-70BV2PL\HOMEPC;Initial Catalog=pms;Persist Security Info=True;User ID=sa;Password=01120051499");
        SqlCommand cmd;
        public string id
        {

            set;
            get;
        }
        public string name
        {
            set;
            get;
        }
        public string salary
        {
            set; get;
        }
        public string age
        {
            set;
            get;
        }
        public string phone
        {
            set;
            get;

        }
        public string gender
        {
            set;
            get;
        }
        public string jobRole
        {
            set;get;

        }
        public void addEmployee(employeeDB md , string msg)
        {
            con.Open();

            query = "insert into EmployeeInfo (name,age,salary,phonenumber,jobrole,gendre) values (@a,@b,@c,@d,@e,@f)";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@a", md.name);
            cmd.Parameters.AddWithValue("@b", md.age);
            cmd.Parameters.AddWithValue("@c", md.salary);
            cmd.Parameters.AddWithValue("@d", md.phone);
            cmd.Parameters.AddWithValue("@e", md.jobRole);
            cmd.Parameters.AddWithValue("@f", md.gender);




            cmd.ExecuteNonQuery();
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void updateEmployee(employeeDB md,string msg)
        {
            con.Open();
            query = "update EmployeeInfo set name=@a,salary=@c,phonenumber=@d,jobrole=@f where  Id = @id";


            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@id", int.Parse(md.id));
            cmd.Parameters.AddWithValue("@a", md.name);
            cmd.Parameters.AddWithValue("@c", md.salary);
            cmd.Parameters.AddWithValue("@d", md.phone);
            cmd.Parameters.AddWithValue("@f", md.jobRole);


            cmd.ExecuteNonQuery();
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK , MessageBoxIcon.Information);
            con.Close();

        }

    }
}
