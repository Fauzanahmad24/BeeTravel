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
    public partial class Pulsa : Form
    {
        public Pulsa()
        {
            InitializeComponent();
        }
        private void Pulsa_Load(object sender, EventArgs e)
        {
            lbl_no_pulsadata.Hide();
            lbl_paketdata.Hide();
            txt_no_data.Hide();
            cmb_pulsadata.Hide();
            lbl_no_pulsa.Hide();
            lbl_pulsa.Hide();
            txt_no_pulsa.Hide();
            cmb_pulsa.Hide();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Pulsa")
            {
                lbl_no_pulsadata.Hide();
                lbl_paketdata.Hide();
                txt_no_data.Hide();
                cmb_pulsadata.Hide();
                tarif_data.Hide();
                lbl_no_pulsa.Show();
                lbl_pulsa.Show();
                txt_no_pulsa.Show();
                cmb_pulsa.Show();
                tarif_pulsa.Show();
            }
            else if(comboBox1.Text == "Pulsa Data")
            {
                lbl_no_pulsa.Hide();
                lbl_pulsa.Hide();
                txt_no_pulsa.Hide();
                cmb_pulsa.Hide();
                tarif_pulsa.Hide();
                lbl_no_pulsadata.Show();
                lbl_paketdata.Show();
                txt_no_data.Show();
                cmb_pulsadata.Show();
                tarif_data.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Utama mm = new Utama();
            mm.Show();
            this.Hide();
        }
        private void cmb_pulsadata_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_pulsadata.Text == "10 GB")
            {
                tarif_data.Text = "Rp.20.000";
            }
            else if (cmb_pulsadata.Text == "15 GB")
            {
                tarif_data.Text = "Rp.30.000";
            }
            else if (cmb_pulsadata.Text == "20 GB")
            {
                tarif_data.Text = "Rp.40.000";
            }
            else if (cmb_pulsadata.Text == "35 GB")
            {
                tarif_data.Text = "Rp.60.000";
            }
            else if (cmb_pulsadata.Text == "50 GB")
            {
                tarif_data.Text = "Rp.80.000";
            }
            else
            {
                MessageBox.Show("Pulsa Tidak Tersedia");
            }
        }

        private void cmb_pulsa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_pulsa.Text == "5")
            {
                tarif_pulsa.Text = "Rp.5.500";
            }
            else if (cmb_pulsa.Text == "10")
            {
                tarif_pulsa.Text = "Rp.10.500";
            }
            else if (cmb_pulsa.Text == "20")
            {
                tarif_pulsa.Text = "Rp.20.500";
            }
            else if (cmb_pulsa.Text == "50")
            {
                tarif_pulsa.Text = "Rp.50.500";
            }
            else if (cmb_pulsa.Text == "100")
            {
                tarif_pulsa.Text = "Rp.100.000";
            }
            else
            {
                MessageBox.Show("Pulsa Tidak Tersedia");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Pulsa Data")
            {
                if (txt_no_data.Text == "" || cmb_pulsadata.Text == "")
                {
                    MessageBox.Show("Lengkapi data anda");
                }
                else
                {
                    MessageBox.Show("Sukses Membeli Pulsa");
                    message_pulsa bb = new message_pulsa();
                    bb.Show();
                }
            }
            else if (comboBox1.Text == "Pulsa")
            {
                if (txt_no_pulsa.Text == "" || cmb_pulsa.Text == "")
                {
                    MessageBox.Show("Lengkapi data anda");
                }
                else
                {
                    MessageBox.Show("Sukses Membeli Pulsa");
                    message_pulsa bb = new message_pulsa();
                    bb.Show();
                }
            }
            else
            {
                MessageBox.Show("Pilih pulsa yang akan anda beli");
            }
        }

        private void txt_no_data_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validString = "0987654321";
            if(validString.IndexOf(e.KeyChar) != -1 || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_no_pulsa_KeyPress(object sender, KeyPressEventArgs e)
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
