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
    public partial class Kereta : Form
    {
        public Kereta()
        {
            InitializeComponent();
        }
        private void pictureBox1_home_Click(object sender, EventArgs e)
        {
            Utama mm = new Utama();
            mm.Show();
            this.Hide();
        }

        private void btn_cek_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_kasal.Text == "" && cmb_ktujuan.Text == "")
                {
                    MessageBox.Show("Pilih kota asal & tujuan anda");
                }
                else
                {
                    if (cmb_kelaskereta.Text == "Bisnis")
                    {
                        if (cmb_kasal.Text == "makassar" && cmb_ktujuan.Text == "palu" || cmb_kasal.Text == "jakarta" && cmb_ktujuan.Text == "palu" || cmb_kasal.Text == "semarang" && cmb_ktujuan.Text == "palu" || cmb_kasal.Text == "yogyakarta" && cmb_ktujuan.Text == "palu" || cmb_kasal.Text == "medan" && cmb_ktujuan.Text == "palu")
                        {
                            int h = 100000;
                            int jumpen = int.Parse(cmb_jum_penum.SelectedItem.ToString());
                            tarif.Text = (jumpen * h).ToString();
                        }
                        else if (cmb_kasal.Text == "makassar" && cmb_ktujuan.Text == "kendari" || cmb_kasal.Text == "jakarta" && cmb_ktujuan.Text == "kendari" || cmb_kasal.Text == "semarang" && cmb_ktujuan.Text == "kendari" || cmb_kasal.Text == "yogyakarta" && cmb_ktujuan.Text == "kendari" || cmb_kasal.Text == "medan" && cmb_ktujuan.Text == "kendari")
                        {
                            int h = 250000;
                            int jumpen = int.Parse(cmb_jum_penum.SelectedItem.ToString());
                            tarif.Text = (jumpen * h).ToString();
                        }
                        else if (cmb_kasal.Text == "makassar" && cmb_ktujuan.Text == "solo" || cmb_kasal.Text == "jakarta" && cmb_ktujuan.Text == "solo" || cmb_kasal.Text == "semarang" && cmb_ktujuan.Text == "solo" || cmb_kasal.Text == "yogyakarta" && cmb_ktujuan.Text == "solo" || cmb_kasal.Text == "medan" && cmb_ktujuan.Text == "solo")
                        {
                            int h = 188000;
                            int jumpen = int.Parse(cmb_jum_penum.SelectedItem.ToString());
                            tarif.Text = (jumpen * h).ToString();
                        }
                        else if (cmb_kasal.Text == "makassar" && cmb_ktujuan.Text == "merauke" || cmb_kasal.Text == "jakarta" && cmb_ktujuan.Text == "merauke" || cmb_kasal.Text == "semarang" && cmb_ktujuan.Text == "merauke" || cmb_kasal.Text == "yogyakarta" && cmb_ktujuan.Text == "merauke" || cmb_kasal.Text == "medan" && cmb_ktujuan.Text == "merauke")
                        {
                            int h = 408000;
                            int jumpen = int.Parse(cmb_jum_penum.SelectedItem.ToString());
                            tarif.Text = (jumpen * h).ToString();
                        }
                        else if (cmb_kasal.Text == "makassar" && cmb_ktujuan.Text == "pomalaa" || cmb_kasal.Text == "jakarta" && cmb_ktujuan.Text == "pomalaa" || cmb_kasal.Text == "semarang" && cmb_ktujuan.Text == "pomalaa" || cmb_kasal.Text == "yogyakarta" && cmb_ktujuan.Text == "pomalaa" || cmb_kasal.Text == "medan" && cmb_ktujuan.Text == "pomalaa")
                        {
                            int h = 45000;
                            int jumpen = int.Parse(cmb_jum_penum.SelectedItem.ToString());
                            tarif.Text = (jumpen * h).ToString();
                        }
                        else
                        {
                            tarif.Text = "";
                            MessageBox.Show("Kereta tidak tersedia");
                        }
                    }
                    else if (cmb_kelaskereta.Text == "Ekonomi")
                    {
                        if (cmb_kasal.Text == "makassar" && cmb_ktujuan.Text == "palu" || cmb_kasal.Text == "jakarta" && cmb_ktujuan.Text == "palu" || cmb_kasal.Text == "semarang" && cmb_ktujuan.Text == "palu" || cmb_kasal.Text == "yogyakarta" && cmb_ktujuan.Text == "palu" || cmb_kasal.Text == "medan" && cmb_ktujuan.Text == "palu")
                        {
                            int h = 80000;
                            int jumpen = int.Parse(cmb_jum_penum.SelectedItem.ToString());
                            tarif.Text = (jumpen * h).ToString();
                        }
                        else if (cmb_kasal.Text == "makassar" && cmb_ktujuan.Text == "kendari" || cmb_kasal.Text == "jakarta" && cmb_ktujuan.Text == "kendari" || cmb_kasal.Text == "semarang" && cmb_ktujuan.Text == "kendari" || cmb_kasal.Text == "yogyakarta" && cmb_ktujuan.Text == "kendari" || cmb_kasal.Text == "medan" && cmb_ktujuan.Text == "kendari")
                        {
                            int h = 200000;
                            int jumpen = int.Parse(cmb_jum_penum.SelectedItem.ToString());
                            tarif.Text = (jumpen * h).ToString();
                        }
                        else if (cmb_kasal.Text == "makassar" && cmb_ktujuan.Text == "solo" || cmb_kasal.Text == "jakarta" && cmb_ktujuan.Text == "solo" || cmb_kasal.Text == "semarang" && cmb_ktujuan.Text == "solo" || cmb_kasal.Text == "yogyakarta" && cmb_ktujuan.Text == "solo" || cmb_kasal.Text == "medan" && cmb_ktujuan.Text == "solo")
                        {
                            int h = 108000;
                            int jumpen = int.Parse(cmb_jum_penum.SelectedItem.ToString());
                            tarif.Text = (jumpen * h).ToString();
                        }
                        else if (cmb_kasal.Text == "makassar" && cmb_ktujuan.Text == "merauke" || cmb_kasal.Text == "jakarta" && cmb_ktujuan.Text == "merauke" || cmb_kasal.Text == "semarang" && cmb_ktujuan.Text == "merauke" || cmb_kasal.Text == "yogyakarta" && cmb_ktujuan.Text == "merauke" || cmb_kasal.Text == "medan" && cmb_ktujuan.Text == "merauke")
                        {
                            int h = 175000;
                            int jumpen = int.Parse(cmb_jum_penum.SelectedItem.ToString());
                            tarif.Text = (jumpen * h).ToString();
                        }
                        else if (cmb_kasal.Text == "makassar" && cmb_ktujuan.Text == "pomalaa" || cmb_kasal.Text == "jakarta" && cmb_ktujuan.Text == "pomalaa" || cmb_kasal.Text == "semarang" && cmb_ktujuan.Text == "pomalaa" || cmb_kasal.Text == "yogyakarta" && cmb_ktujuan.Text == "pomalaa" || cmb_kasal.Text == "medan" && cmb_ktujuan.Text == "pomalaa")
                        {
                            int h = 15000;
                            int jumpen = int.Parse(cmb_jum_penum.SelectedItem.ToString());
                            tarif.Text = (jumpen * h).ToString();
                        }
                        else
                        {
                            tarif.Text = "";
                            MessageBox.Show("Kereta tidak tersedia");
                        }
                    }
                    else if (cmb_kelaskereta.Text == "Eksekutif")
                    {
                        if (cmb_kasal.Text == "makassar" && cmb_ktujuan.Text == "palu" || cmb_kasal.Text == "jakarta" && cmb_ktujuan.Text == "palu" || cmb_kasal.Text == "semarang" && cmb_ktujuan.Text == "palu" || cmb_kasal.Text == "yogyakarta" && cmb_ktujuan.Text == "palu" || cmb_kasal.Text == "medan" && cmb_ktujuan.Text == "palu")
                        {
                            int h = 800000;
                            int jumpen = int.Parse(cmb_jum_penum.SelectedItem.ToString());
                            tarif.Text = (jumpen * h).ToString();
                        }
                        else if (cmb_kasal.Text == "makassar" && cmb_ktujuan.Text == "kendari" || cmb_kasal.Text == "jakarta" && cmb_ktujuan.Text == "kendari" || cmb_kasal.Text == "semarang" && cmb_ktujuan.Text == "kendari" || cmb_kasal.Text == "yogyakarta" && cmb_ktujuan.Text == "kendari" || cmb_kasal.Text == "medan" && cmb_ktujuan.Text == "kendari")
                        {
                            int h = 2000000;
                            int jumpen = int.Parse(cmb_jum_penum.SelectedItem.ToString());
                            tarif.Text = (jumpen * h).ToString();
                        }
                        else if (cmb_kasal.Text == "makassar" && cmb_ktujuan.Text == "solo" || cmb_kasal.Text == "jakarta" && cmb_ktujuan.Text == "solo" || cmb_kasal.Text == "semarang" && cmb_ktujuan.Text == "solo" || cmb_kasal.Text == "yogyakarta" && cmb_ktujuan.Text == "solo" || cmb_kasal.Text == "medan" && cmb_ktujuan.Text == "solo")
                        {
                            int h = 1108000;
                            int jumpen = int.Parse(cmb_jum_penum.SelectedItem.ToString());
                            tarif.Text = (jumpen * h).ToString();
                        }
                        else if (cmb_kasal.Text == "makassar" && cmb_ktujuan.Text == "merauke" || cmb_kasal.Text == "jakarta" && cmb_ktujuan.Text == "merauke" || cmb_kasal.Text == "semarang" && cmb_ktujuan.Text == "merauke" || cmb_kasal.Text == "yogyakarta" && cmb_ktujuan.Text == "merauke" || cmb_kasal.Text == "medan" && cmb_ktujuan.Text == "merauke")
                        {
                            int h = 198000;
                            int jumpen = int.Parse(cmb_jum_penum.SelectedItem.ToString());
                            tarif.Text = (jumpen * h).ToString();
                        }
                        else if (cmb_kasal.Text == "makassar" && cmb_ktujuan.Text == "pomalaa" || cmb_kasal.Text == "jakarta" && cmb_ktujuan.Text == "pomalaa" || cmb_kasal.Text == "semarang" && cmb_ktujuan.Text == "pomalaa" || cmb_kasal.Text == "yogyakarta" && cmb_ktujuan.Text == "pomalaa" || cmb_kasal.Text == "medan" && cmb_ktujuan.Text == "pomalaa")
                        {
                            int h = 500000;
                            int jumpen = int.Parse(cmb_jum_penum.SelectedItem.ToString());
                            tarif.Text = (jumpen * h).ToString();
                        }
                        else
                        {
                            tarif.Text = "";
                            MessageBox.Show("Kereta tidak tersedia");
                        }
                    }
                    else
                    {
                        tarif.Text = "";
                        MessageBox.Show("Pilih kelas bus !!!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lengkapi Data Anda");
            }
        }

        private void btn_bayar_Click(object sender, EventArgs e)
        {
            if (cmb_kasal.Text == "" || cmb_ktujuan.Text == "" || cmb_jum_penum.Text == "" || cmb_kelaskereta.Text == "" || cmb_penumpang.Text == "" || dtp_tanggal.Text == "")
            {
                MessageBox.Show("Lengkapi Data Anda");
            }
            else
            {
                MessageBox.Show("Lanjutkan Ke Pembayaran");
                Bayar mm = new Bayar();
                mm.Show();
                this.Close();
            }
        }
    }
}
