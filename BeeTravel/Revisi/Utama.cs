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
    public partial class Utama : Form
    {
        public Utama()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Kapal mm = new Kapal();
            mm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Bus mm = new Bus();
            mm.Show();
            this.Hide();
        }

        private void btn_kereta_Click(object sender, EventArgs e)
        {
            Kereta mm = new Kereta();
            mm.Show();
            this.Hide();
        }

        private void btn_pesawat_Click(object sender, EventArgs e)
        {
            Pesawat mm = new Pesawat();
            mm.Show();
            this.Hide();
        }

        private void btn_pulsa_Click(object sender, EventArgs e)
        {
            Pulsa mm = new Pulsa();
            mm.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            login mm = new login();
            mm.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
