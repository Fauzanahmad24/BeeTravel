using Revisi.bayar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisi
{
    public partial class Bayar : Form
    {
        public Bayar()
        {
            InitializeComponent();
        }
        bayarclass c = new bayarclass();

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_bayar_Click(object sender, EventArgs e)
        {
            c.NamaPemesan = txt_datape_nama.Text;
            c.EmailPemesan = txt_datape_email.Text;
            c.NoTelepon = txt_datape_noHp.Text;
            c.TitleWisatawan = cmb_title.Text;
            c.NamaWisatawan = txt_datawis_nama.Text;
            c.MetodeBayar = cmb_bayar_metode.Text;
            c.Nominal = int.Parse(txt_nominal.Text);

            //Insert data ke database menggunakan method yg tadi dibuat

            bool success = c.Insert(c);
            if(success == true)
            {
                //memanggil method clear
                Clear();
                //jika sukses
                MessageBox.Show("Sukses Membayar");
            }
            else
            {
                //jika gagal
                MessageBox.Show("Gagal Membayar, Try Again mas !!");
                //memanggil method clear
                
            }
            //Menampilkan data di datagread view
            DataTable dt = c.Select();
            dgv_bayar.DataSource = dt;


        }
        private void Bayar_Load(object sender, EventArgs e)
        {
            //Menampilkan data di datagread view
            DataTable dt = c.Select();
            dgv_bayar.DataSource = dt;
        }
        //Method untuk clear fields
        public void Clear()
        {
            txt_datape_nama.Text = "";
            txt_datape_email.Text = "";
            txt_datape_noHp.Text = "";
            cmb_title.Text = "";
            txt_datawis_nama.Text = "";
            cmb_bayar_metode.Text = "";
            txt_nominal.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                c.NamaPemesan = txt_datape_nama.Text;
                c.EmailPemesan = txt_datape_email.Text;
                c.NoTelepon = txt_datape_noHp.Text;
                c.TitleWisatawan = cmb_title.Text;
                c.NamaWisatawan = txt_datawis_nama.Text;
                c.MetodeBayar = cmb_bayar_metode.Text;
                c.Nominal = int.Parse(txt_nominal.Text);

                //Update data ke database menggunakan method yg tadi dibuat

                bool success = c.Update(c);
                if (success == true)
                {
                    Clear();
                    //jika sukses
                    MessageBox.Show("Update Sukses");
                }
                else
                {
                    //jika gagal
                    MessageBox.Show("Dilarang Mengganti Nama Pemesan mas !!");
                }
                //Merefresh data di datagread view
                DataTable dt = c.Select();
                dgv_bayar.DataSource = dt;
            }
            catch(Exception)
            {
                MessageBox.Show("Pilih data yang akan di update");
            }
        }

        private void dgv_bayar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //mengambil data dari data grid view dan menampilkan pada text box
            //memilih data dengan klik mouse
            int rowIndex = e.RowIndex;
            txt_datape_nama.Text = dgv_bayar.Rows[rowIndex].Cells[0].Value.ToString();
            txt_datape_email.Text = dgv_bayar.Rows[rowIndex].Cells[1].Value.ToString();
            txt_datape_noHp.Text = dgv_bayar.Rows[rowIndex].Cells[2].Value.ToString();
            cmb_title.Text = dgv_bayar.Rows[rowIndex].Cells[3].Value.ToString();
            txt_datawis_nama.Text = dgv_bayar.Rows[rowIndex].Cells[4].Value.ToString();
            cmb_bayar_metode.Text = dgv_bayar.Rows[rowIndex].Cells[5].Value.ToString();
            txt_nominal.Text = dgv_bayar.Rows[rowIndex].Cells[6].Value.ToString();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                c.NamaPemesan = Convert.ToString(txt_datape_nama.Text);
                bool success = c.Delete(c);
                if (success == true)
                {
                    //Jika Sukses
                    MessageBox.Show("Sukses Delete");
                    DataTable dt = c.Select();
                    dgv_bayar.DataSource = dt;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Delete Gagal");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Pilih data yang akan di delete");
            }
        }

        private void txt_nominal_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validString = "0987654321";
            if (validString.IndexOf(e.KeyChar) != -1 || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_datape_noHp_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validString = "0987654321";
            if (validString.IndexOf(e.KeyChar) != -1 || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
