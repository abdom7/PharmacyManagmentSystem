using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PMS.pharmasistUC
{
    class medicineDB
    {
        string query = "";


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-70BV2PL\HOMEPC;Initial Catalog=pms;Persist Security Info=True;User ID=sa;Password=01120051499");
        SqlCommand cmd;
        DataSet ds; 

        public string medname
        {

            set;
            get;
        }
        public string medcode
        {

            set;
            get;

        }
        public Int64 Sprice
        {
            set;
            get;

        }
        public Int64 Bprice
        {
            set;
            get;

        }
        public string medtype
        {

            set;
            get;
        }
        public Int64 Quantity
        {

            set; get;

        }
        public string mdate
        {
            set;
            get;

        }
        public string edate
        {

            set; get;
        }
        public string mednumber
        {
            set; get;
        }
        public string medcompany
        {
            set;
            get;
        }
        public void addMedicine(medicineDB md , string msg)
        {


            try
            {
                con.Open();

                query = "insert into MedicineInfo(medname,medcode,quantity,buyingprice,sellingprice,mdate,edate,mednumber,medtype,company) values (@a,@b,@c,@d,@e,@f,@g,@h,@k,@l)";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@a", md.medname);
                cmd.Parameters.AddWithValue("@b", md.medcode);
                cmd.Parameters.AddWithValue("@c", md.Quantity);
                cmd.Parameters.AddWithValue("@d", md.Bprice);
                cmd.Parameters.AddWithValue("@e", md.Sprice);
                cmd.Parameters.AddWithValue("@f", md.mdate);
                cmd.Parameters.AddWithValue("@g", md.edate);
                cmd.Parameters.AddWithValue("@h", md.mednumber);
                cmd.Parameters.AddWithValue("@k", md.medtype);
            cmd.Parameters.AddWithValue("@l", md.medcompany);




            cmd.ExecuteNonQuery();
                MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
        }
            catch (Exception e)
            {
                MessageBox.Show("Medicine  Allready  exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Medicine Allready  exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void updateMedicine(medicineDB md, string msg)
        {
            con.Open();
            query = "update MedicineInfo set medname=@a,mednumber=@b,edate=@c,mdate=@d,company=@e,quantity=@f , sellingprice=@g where medcode = @h";


            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@a", md.medname);
            cmd.Parameters.AddWithValue("@b", md.mednumber);
            cmd.Parameters.AddWithValue("@c", md.edate);
            cmd.Parameters.AddWithValue("@d", md.mdate);
            cmd.Parameters.AddWithValue("@e", md.medcompany);
            cmd.Parameters.AddWithValue("@f", md.Quantity);
            cmd.Parameters.AddWithValue("@g", md.Sprice);

            cmd.Parameters.AddWithValue("@h", md.medcode);


            cmd.ExecuteNonQuery();
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();

        }
        public void populateToComboBox(ComboBox e)
        {
            con.Open();
            query = "select * from  CompanyInfo ";
            cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable ds = new DataTable();
            ds.Columns.Add("name", typeof(string));

            ds.Load(rdr);
            e.ValueMember = "name";
            e.DataSource = ds;
            con.Close();


        }

        public bool is_medcode(int medcode)
        {
            con.Open();
            query = "select medcode from Medicine_tb1 where medcode = @medcodes";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@medcodes", medcode);
            SqlDataReader reader = cmd.ExecuteReader();
            int id2 = 0;
            while (reader.Read())
            {
                id2 = Int32.Parse(reader["medcode"].ToString());

            }
            con.Close();

            return medcode == id2;

        }
    }
}
