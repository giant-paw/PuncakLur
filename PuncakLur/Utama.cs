using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuncakLur
{
    public partial class Utama : Form
    {
        public Utama()
        {
            InitializeComponent();
        }

        private void bOOKINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formboo masukBooking = new Formboo();

            masukBooking.Show();

            this.Hide();
        }

        private void rOMBONGANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rombongan masukRombongan = new Rombongan();

            masukRombongan.Show();

            this.Hide();
        }

        private void pENDAKIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pendaki masukPendaki = new Pendaki();

            masukPendaki.Show();

            this.Hide();
        }

        private void bARANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Barang masukBarang = new Barang();

            masukBarang.Show();

            this.Hide();
        }

        private void bARANGBAWAANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarangBawaan masuk_BarangBawaan = new BarangBawaan();

            masuk_BarangBawaan.Show();
            this.Hide();
        }
    }
}
