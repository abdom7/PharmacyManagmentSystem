using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.adminUC
{
    class users_db
    {
        string query = "";


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-70BV2PL\HOMEPC;Initial Catalog=pms;Persist Security Info=True;User ID=sa;Password=01120051499");
        SqlCommand cmd;

        public int id
        {
            set; get;
        }
        public string userRole
        {
            set; get;
        }
        public string name
        {
            set; get;
        }
        public string phonenumber
        {
            set; get;
        }
        public string dob
        {
            set; get;
        }
        public string email
        {
            set; get;
        }
        public string username
        {
            set; get;
        }
        public string password
        {
            set; get;
        }
        public void adduser(users_db md,string msg)
        {
            try
            {
                con.Open();

                query = "insert into Users(Name,UserRole,DOB,phone,email,username,password) values (@a,@b,@c,@d,@e,@f,@g)";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@a", md.name);
                cmd.Parameters.AddWithValue("@b", md.userRole);
                cmd.Parameters.AddWithValue("@c", md.dob);
                cmd.Parameters.AddWithValue("@d", md.phonenumber);
                cmd.Parameters.AddWithValue("@e", md.email);
                cmd.Parameters.AddWithValue("@f", md.username);
                cmd.Parameters.AddWithValue("@g", md.password);


                cmd.ExecuteNonQuery();
                MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                con.Close();
       }
      catch(Exception e)
       {
          MessageBox.Show("Usrname Allready  exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
       }



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
        { try
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
        public void updateUser(users_db md,string msg)
        {
            con.Open();
            query = "update Users set UserRole=@a,Name=@b,DOB=@c,Phone=@d,email=@e,Password=@f where UserName=@username";


            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@a", md.userRole);
            cmd.Parameters.AddWithValue("@b", md.name);
            cmd.Parameters.AddWithValue("@c", md.dob);
            cmd.Parameters.AddWithValue("@d", md.phonenumber);
            cmd.Parameters.AddWithValue("@e", md.email);
            cmd.Parameters.AddWithValue("@f", md.password);
            cmd.Parameters.AddWithValue("@username", md.username);


            cmd.ExecuteNonQuery();
            MessageBox.Show(msg, "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            con.Close();

        }
    }
}
