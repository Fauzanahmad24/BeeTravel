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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_masuk_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\KULIAH\Semester 4\Pemrograman Terstruktur\SETELAH UTS\PRAKTIKUM\TUGAS\Tugas Besar\tugas besar xxx\Revisi\database\login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username = '" + txt_username.Text + "' and password='" + txt_password.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Utama mm = new Utama();
                mm.Show();
            }
            else
                MessageBox.Show("Please masukkan username dan password yang benar", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void link_daftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            daftar mm = new daftar();
            mm.Show();
        }
    }
}
