using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuncakLur
{
    public partial class BarangBawaan : Form
    {

        DataTable dt;
        DataRow dr;
        string code;
        int bttn;

        public BarangBawaan()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BarangBawaan_Load(object sender, EventArgs e)
        {
            this.barang_bawaanTableAdapter.Fill(this.suwantingDataSet7.barang_bawaan);

        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {

            bttn = 1;
            tambah();
        }

        public void tambah()
        {
            btn_simpan.Enabled = true;
            kode_rombongan.Enabled = true;
            id_barang.Enabled = true;
            jumlah.Enabled = true;

            dt = suwantingDataSet7.Tables["barang_bawaan"];

            kode_rombongan.Text = " ";
            id_barang.Text = " ";
            jumlah.Text = " ";


            btn_tambah.Enabled = false;
            btn_edit.Enabled = false;
            btn_hapus.Enabled = false;
            btn_batal.Enabled = true;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (bttn == 1)
            {
                dt = suwantingDataSet7.Tables["barang_bawaan"];
                //Menyimpan data kedalam database
                dr = dt.NewRow();
                dr[0] = kode_rombongan.Text;
                dr[1] = id_barang.Text;
                dr[2] = jumlah.Text;

                dt.Rows.Add(dr);
            }
            else
            {
                dt = suwantingDataSet7.Tables["barang_bawaan"];
                //mencari primary key yang akan diubah datanya
                dr = dt.Rows.Find(kode_rombongan.Text);

                //mengubah data kedalam database
                dr.BeginEdit();
                dr["kode_rombongan"] = kode_rombongan.Text;
                dr["id_barang"] = id_barang.Text;
                dr["jumlah"] = jumlah.Text;

                dr.EndEdit();
            }

            barang_bawaanTableAdapter.Update(suwantingDataSet7);


            btn_tambah.Enabled = true;
            btn_edit.Enabled = true;
            btn_hapus.Enabled = true;
            btn_batal.Enabled = false;

            kode_rombongan.Enabled = false;
            id_barang.Enabled = false;
            jumlah.Enabled = false;

            this.barang_bawaanTableAdapter.Fill
                (this.suwantingDataSet7.barang_bawaan);
            btn_simpan.Enabled = true;
            btn_hapus.Enabled = true;
            btn_edit.Enabled = true;
            btn_batal.Enabled = true;
            btn_tambah.Enabled = true;
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show(this, "Apakah anda ingin menghapus data ini?", "Konfirmasi anda ingin menghapus data ini?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                hapus();
            }
        }

        public void hapus()
        {
            string code;
            code = kode_rombongan.Text;
            //mencari data yang akan dihapus berdasarkan primary key
            dr = suwantingDataSet7.Tables["barang_bawaan"].Rows.Find(code);
            //menghapus data
            dr.Delete();
            barang_bawaanTableAdapter.Update(suwantingDataSet7);
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            kode_rombongan.Enabled = false;
            id_barang.Enabled = false;
            jumlah.Enabled = false;

            this.barang_bawaanTableAdapter.Fill
                (this.suwantingDataSet7.barang_bawaan);
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
            kode_rombongan.Enabled = true;
            id_barang.Enabled = true;
            jumlah.Enabled = true;

            btn_tambah.Enabled = false;
            btn_edit.Enabled = false;
            btn_hapus.Enabled = false;
            btn_batal.Enabled = true;
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utama masuk_utama = new Utama();

            masuk_utama.Show();
            this.Hide();
        }

        private void bARANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Barang masuk_barang = new Barang();

            masuk_barang.Show();
            this.Hide();
        }

        private void pENDAKIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pendaki masuk_pendaki = new Pendaki();

            masuk_pendaki.Show();
            this.Hide();
        }

        private void rOMBONGANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rombongan masuk_rombongan = new Rombongan();

            masuk_rombongan.Show();
            this.Hide();
        }

        private void bOOKINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formboo masuk_booking = new Formboo();

            masuk_booking.Show();
            this.Hide();
        }
    }
}
