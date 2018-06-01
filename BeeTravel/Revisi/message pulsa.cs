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
    public partial class message_pulsa : Form
    {
        public message_pulsa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pulsa p = new Pulsa();
            p.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utama u = new Utama();
            Pulsa p = new Pulsa();
            p.Close();
            u.Show();
            this.Hide();
        }
    }
}
