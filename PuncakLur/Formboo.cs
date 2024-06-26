﻿using System;
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
    public partial class Formboo : Form
    {

        DataTable dt;
        DataRow dr;
        string code;
        int bttn;

        public Formboo()
        {

            InitializeComponent();
        }

        private void Formboo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'suwantingDataSet.booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.suwantingDataSet.booking);
            btn_simpan.Enabled = false;
            kode_booking.Enabled = false;
            jlr_turun.Enabled = false;
            jml_hari.Enabled = false;

        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            bttn = 1;
            tambah();
        }

        public void tambah()
        {
            btn_simpan.Enabled = true;
            kode_booking.Enabled = true;
            jlr_turun.Enabled = true;
            jml_hari.Enabled = true;

            kode_booking.Text= " ";
            jlr_turun.Text = " ";
            jml_hari.Text = " ";

            dt = suwantingDataSet.Tables["booking"];

            btn_tambah.Enabled = false;
            btn_edit.Enabled = false;
            btn_hapus.Enabled = false;
            btn_batal.Enabled = true;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (bttn == 1)
            {
                dt = suwantingDataSet.Tables["booking"];
                //Menyimpan data kedalam database
                dr = dt.NewRow();
                dr[0] = kode_booking.Text;
                dr[1] = jlr_turun.Text;
                dr[2] = jml_hari.Text;
                dt.Rows.Add(dr);
            }
            else
            {
                dt = suwantingDataSet.Tables["booking"];
                //mencari primary key yang akan diubah datanya
                dr = dt.Rows.Find(kode_booking.Text);

                //mengubah data kedalam database
                dr.BeginEdit();
                dr["jalur_turun"] = jlr_turun.Text;
                dr["jumlah_hari"] = jml_hari.Text;
                dr.EndEdit();
            }

            bookingTableAdapter.Update(suwantingDataSet);

            btn_tambah.Enabled = true;
            btn_edit.Enabled = true;
            btn_hapus.Enabled = true;
            btn_batal.Enabled = false;

            kode_booking.Enabled = false;
            jlr_turun.Enabled = false;
            jml_hari.Enabled = false;
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
            code = kode_booking.Text;
            //mencari data yang akan dihapus berdasarkan primary key
            dr = suwantingDataSet.Tables["booking"].Rows.Find(code);
            //menghapus data
            dr.Delete();
            bookingTableAdapter.Update(suwantingDataSet);
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            kode_booking.Enabled = false;
            jlr_turun.Enabled = false;
            jml_hari.Enabled = false;

            this.bookingTableAdapter.Fill
                (this.suwantingDataSet.booking);
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
            kode_booking.Enabled = true;
            jlr_turun.Enabled = true;
            jml_hari.Enabled = true;

            btn_tambah.Enabled = false;
            btn_edit.Enabled = false;
            btn_hapus.Enabled = false;
            btn_batal.Enabled = true;
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utama iniHome = new Utama();

            iniHome.Show();

            this.Hide();
        }

        private void rOMBONGANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rombongan masukRombongan = new Rombongan();

            masukRombongan.Show();

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
