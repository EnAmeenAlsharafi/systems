using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Rental_House_Management_Sytem
{
    class Database
    {
       
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E51FLN4\SQLEXPRESS,1433;Initial Catalog=RentalHouse;User ID=sa;Password=ameen");
        SqlCommand com = new SqlCommand();
        public DataTable readData(string send,string m)
        {
            DataTable tb = new DataTable();
            try {
                com.Connection = con;
                com.CommandText = send;
                con.Open();
                tb.Load(com.ExecuteReader());
                if(m !="")
                {
                    MessageBox.Show(m, "Comferm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return tb;
        }
        public bool ExecuteData(string send,string m)
        {
            try
            {
                com.Connection = con;
                com.CommandText = send;
                con.Open();
                com.ExecuteNonQuery();
                if(m !="")
                {
                    MessageBox.Show(m,"conferm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                con.Close();
                return true;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            



        }
    }

}