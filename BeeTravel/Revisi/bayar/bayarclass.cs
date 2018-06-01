using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisi.bayar
{
    class bayarclass
    {
        //Getter Sette Properties
        //Acts as Data Carrier in Our Application
        public string NamaPemesan { get; set; }
        public string EmailPemesan { get; set; }
        public string NoTelepon { get; set; }
        public string TitleWisatawan { get; set; }
        public string NamaWisatawan { get; set; }
        public string MetodeBayar { get; set; }
        public int Nominal { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting Data from Database
        public DataTable Select()
        {
            //Step 1 : Koneksi DataBase
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Step 1 : Menulis Query SQL
                string sql = "SELECT * FROM tbl_bayar";
                //Membuat cmd menggunakan sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Membuat SQL DataAdapter menggunakan cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception e)
            {
               
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //Insert Menu
         public bool Insert(bayarclass c)
        {
             //Creating a default return type and setting its value to false
            bool isSuccess = false;
            //Step1 : connect DataBase
             SqlConnection conn = new SqlConnection(myconnstrng);
             try
             {
                 //Step2 : Create a SQL Query to insert Data
                 string sql = "INSERT INTO tbl_bayar (NamaPemesan, EmailPemesan, NoTelepon, TitleWisatawan, NamaWisatawan, MetodeBayar, Nominal) VALUES (@NamaPemesan, @EmailPemesan, @NoTelepon, @TitleWisatawan, @NamaWisatawan, @MetodeBayar, @Nominal)";
                 //Membuat SQL Command menggunakan sql dan conn
                 SqlCommand cmd = new SqlCommand(sql, conn);
                 //Membuat parameters untuk mengambil data
                 cmd.Parameters.AddWithValue("@NamaPemesan", c.NamaPemesan);
                 cmd.Parameters.AddWithValue("@EmailPemesan", c.EmailPemesan);
                 cmd.Parameters.AddWithValue("@NoTelepon", c.NoTelepon);
                 cmd.Parameters.AddWithValue("@TitleWisatawan", c.TitleWisatawan);
                 cmd.Parameters.AddWithValue("@NamaWisatawan", c.NamaWisatawan);
                 cmd.Parameters.AddWithValue("@MetodeBayar", c.MetodeBayar);
                 cmd.Parameters.AddWithValue("@Nominal", c.Nominal);

                 //Memanggil/membuka Connection
                 conn.Open();
                 int rows = cmd.ExecuteNonQuery();
                 //If the query runs succesfully then the value of rows will be greater then zero else it value will be 0
                 if(rows > 0)
                 {
                     isSuccess = true;
                 }
                 else
                 {
                     isSuccess = false;
                 }

             }
             catch(Exception e)
             {

             }
             finally
             {
                 conn.Close();
             }
             return isSuccess;
        }
        //Membuat methode update
        public bool Update(bayarclass c)
        {
            //Create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL update database
                string sql = "UPDATE tbl_bayar SET  EmailPemesan=@EmailPemesan, NoTelepon=@NoTelepon, TitleWisatawan=@TitleWisatawan, NamaWisatawan=@NamaWisatawan, MetodeBayar=@MetodeBayar, Nominal=@Nominal WHERE NamaPemesan=@NamaPemesan";
                //Membuat SQL Command menggunakan sql dan conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Membuat parameters untuk mengambil data

                cmd.Parameters.AddWithValue("@NamaPemesan", c.NamaPemesan);
                cmd.Parameters.AddWithValue("@EmailPemesan", c.EmailPemesan);
                cmd.Parameters.AddWithValue("@NoTelepon", c.NoTelepon);
                cmd.Parameters.AddWithValue("@TitleWisatawan", c.TitleWisatawan);
                cmd.Parameters.AddWithValue("@NamaWisatawan", c.NamaWisatawan);
                cmd.Parameters.AddWithValue("@MetodeBayar", c.MetodeBayar);
                cmd.Parameters.AddWithValue("@Nominal", c.Nominal);
                
                //Memanggil/membuka Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs succesfully then the value of rows will be greater then zero else it value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {
              
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //Membuat Method Delete
        public bool Delete(bayarclass c)
        {
            //Create a default return type and set its default value to false
            bool isSuccess = false;
            //membuat koneksi sql
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL Delete database
                string sql = "DELETE FROM tbl_bayar WHERE NamaPemesan=@NamaPemesan";
                //Membuat SQL Command menggunakan sql dan conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Membuat parameters untuk mengambil data
                cmd.Parameters.AddWithValue("@NamaPemesan", c.NamaPemesan);
                //Memanggil/membuka Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs succesfully then the value of rows will be greater then zero else it value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
