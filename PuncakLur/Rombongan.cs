using PuncakLur.suwantingDataSetTableAdapters;
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
    public partial class Rombongan : Form
    {

        DataTable dt;
        DataRow dr;
        string code;
        int bttn;

        public Rombongan()
        {
          

            InitializeComponent();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utama iniHome = new Utama();

            iniHome.Show();

            this.Hide();
        }

        private void bOOKINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formboo masukBooking = new Formboo();

            masukBooking.Show();

            this.Hide();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            bttn = 1;
            tambah();
        }

        public void tambah()
        {
            btn_simpan.Enabled = true;
            kd_rombongan.Enabled = true;
            nm_rombongan.Enabled = true;
            kd_booking.Enabled = true;

            kd_rombongan.Text = " ";
            nm_rombongan.Text = " ";
            kd_booking.Text = " ";

            dt = suwantingDataSet1.Tables["rombongan"];

            btn_tambah.Enabled = false;
            btn_edit.Enabled = false;
            btn_hapus.Enabled = false;
            btn_batal.Enabled = true;
        }

        private void Rombongan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'suwantingDataSet5.booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.suwantingDataSet5.booking);
            // TODO: This line of code loads data into the 'suwantingDataSet1.rombongan' table. You can move, or remove it, as needed.
            this.rombonganTableAdapter.Fill(this.suwantingDataSet1.rombongan);
            btn_simpan.Enabled = false;
            kd_rombongan.Enabled = false;
            nm_rombongan.Enabled = false;
            kd_booking.Enabled = false;

            lihatBooking.Enabled = false;
            lihatJalur.Enabled = false;
            lihatHari.Enabled = false;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (bttn == 1)
            {
                dt = suwantingDataSet1.Tables["rombongan"];
                //Menyimpan data kedalam database
                dr = dt.NewRow();
                dr[0] = kd_rombongan.Text;
                dr[1] = nm_rombongan.Text;
                dr[2] = kd_booking.Text;
                dt.Rows.Add(dr);
            }
            else
            {
                dt = suwantingDataSet1.Tables["rombongan"];
                //mencari primary key yang akan diubah datanya
                dr = dt.Rows.Find(kd_rombongan.Text);

                //mengubah data kedalam database
                dr.BeginEdit();
                dr["kode_rombongan"] = kd_rombongan.Text;
                dr["nama_rombongan"] = nm_rombongan.Text;
                dr["kode_booking"] = kd_booking.Text;
                dr.EndEdit();
            }

            rombonganTableAdapter.Update(suwantingDataSet1);

            btn_tambah.Enabled = true;
            btn_edit.Enabled = true;
            btn_hapus.Enabled = true;
            btn_batal.Enabled = false;

            kd_rombongan.Enabled = false;
            nm_rombongan.Enabled = false;
            kd_booking.Enabled = false;
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            kd_rombongan.Enabled = false;
            nm_rombongan.Enabled = false;
            kd_booking.Enabled = false;

            this.rombonganTableAdapter.Fill
                (this.suwantingDataSet1.rombongan);
            btn_tambah.Enabled = true;
            btn_edit.Enabled = true;
            btn_hapus.Enabled = true;
            btn_simpan.Enabled = false;
            btn_batal.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            bttn = 2;
            btn_simpan.Enabled = true;
            kd_rombongan.Enabled = true;
            nm_rombongan.Enabled = true;
            kd_booking.Enabled = true;

            btn_tambah.Enabled = false;
            btn_edit.Enabled = false;
            btn_hapus.Enabled = false;
            btn_batal.Enabled = true;
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show(this, "Apakah Anda Yakin Ingin Menghapus Data ini??", "Tekan 'Yes' Untuk Menghapus",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                hapus();
            }
        }

        public void hapus()
        {
            string code;
            code = kd_rombongan.Text;
            //mencari data yang akan dihapus berdasarkan primary key
            dr = suwantingDataSet1.Tables["rombongan"].Rows.Find(code);
            //menghapus data
            dr.Delete();
            rombonganTableAdapter.Update(suwantingDataSet1);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void kd_booking_TextChanged(object sender, EventArgs e)
        {

        }

        private void pENDAKIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pendaki masukPendaki = new Pendaki();

            masukPendaki.Show();

            this.Hide();
        }

        private void bARANGBAWAANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarangBawaan masuk_BarangBawaan = new BarangBawaan();

            masuk_BarangBawaan.Show();
            this.Hide();
        }

        private void bARANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Barang masuk_barang = new Barang();

            masuk_barang.Show();
            this.Hide();
        }
    }
}
