using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Revisi
{
    public partial class daftar : Form
    {
        public daftar()
        {
            InitializeComponent();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\KULIAH\Semester 4\Pemrograman Terstruktur\SETELAH UTS\PRAKTIKUM\TUGAS\Tugas Besar\tugas besar xxx\Revisi\database\login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username ='" + txt_username.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (int.Parse(dt.Rows[0][0].ToString()) == 0)
            {
                label2.Text = txt_username.Text + "is Available";
                this.label2.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                label2.Text = txt_username.Text + "is Available";
                this.label2.BackColor = System.Drawing.Color.Red;
            }
        }

        private void btn_masuk_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\KULIAH\Semester 4\Pemrograman Terstruktur\SETELAH UTS\PRAKTIKUM\TUGAS\Tugas Besar\tugas besar xxx\Revisi\database\login.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            if (label2.BackColor == System.Drawing.Color.Green)
            {
                if (txt_password.Text == txt_konfirmasipass.Text)
                {
                    SqlCommand cmd = new SqlCommand("Insert into Login(username,password) Values('" + txt_username.Text + "','" + txt_konfirmasipass.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sukses");
                    conn.Close();
                    this.Hide();
                    login mm = new login();
                    mm.Show();
                }
                else
                {
                    MessageBox.Show("Password kamu salah . . .");
                }
            }
            else
            {
                MessageBox.Show("Masukkan username yang tepat");
            }
        }
        private void btn_cek_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\KULIAH\Semester 4\Pemrograman Terstruktur\SETELAH UTS\PRAKTIKUM\TUGAS\Tugas Besar\tugas besar xxx\Revisi\database\login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username ='" + txt_username.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (int.Parse(dt.Rows[0][0].ToString()) == 0)
            {
                label2.Text = txt_username.Text + "is Available";
                this.label2.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                label2.Text = txt_username.Text + "is Available";
                this.label2.BackColor = System.Drawing.Color.Red;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
