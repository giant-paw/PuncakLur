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


    public partial class Pendaki : Form
    {

        DataTable dt;
        DataRow dr;
        string code;
        int bttn;

        public Pendaki()
        {
            InitializeComponent();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utama utama = new Utama();

            utama.Show();

            this.Hide();
        }

        private void Pendaki_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'suwantingDataSet4.pendaki' table. You can move, or remove it, as needed.
            this.pendakiTableAdapter2.Fill(this.suwantingDataSet4.pendaki);
            btn_simpan.Enabled = false;
            NIK.Enabled = false;
            nama_lengkap.Enabled = false;
            berat_badan.Enabled = false;
            no_hp.Enabled = false;
            kota_domisili.Enabled = false;
            kode_rombongan.Enabled = false;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            bttn = 1;
            tambah();
        }

        public void tambah()
        {
            btn_simpan.Enabled = true;
            NIK.Enabled = true;
            nama_lengkap.Enabled = true;
            berat_badan.Enabled = true;
            no_hp.Enabled = true;
            kota_domisili.Enabled = true;
            kode_rombongan.Enabled = true;

            dt = suwantingDataSet4.Tables["pendaki"];

            NIK.Text = " ";
            nama_lengkap.Text = " ";
            berat_badan.Text = " ";
            no_hp.Text = " ";
            kota_domisili.Text = " ";
            kode_rombongan.Text = " ";



        
            btn_tambah.Enabled = false;
            btn_edit.Enabled = false;
            btn_hapus.Enabled = false;
            btn_batal.Enabled = true;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (bttn == 1)
            {
                dt = suwantingDataSet4.Tables["pendaki"];
                //Menyimpan data kedalam database
                dr = dt.NewRow();
                dr[0] = NIK.Text;
                dr[1] = nama_lengkap.Text;
                dr[2] = berat_badan.Text;
                dr[3] = no_hp.Text;
                dr[4] = kota_domisili.Text;
                dr[5] = kode_rombongan.Text;

                dt.Rows.Add(dr);
            }
            else
            {
                dt = suwantingDataSet4.Tables["pendaki"];
                //mencari primary key yang akan diubah datanya
                dr = dt.Rows.Find(NIK.Text);

                //mengubah data kedalam database
                dr.BeginEdit();
                dr["NIK"] = NIK.Text;
                dr["nama_lengkap"] = nama_lengkap.Text;
                dr["berat_badan"] = berat_badan.Text;
                dr["no_hp"] = no_hp.Text;
                dr["kota_domisili"] = kota_domisili.Text;
                dr["kode_rombongan"] = kode_rombongan.Text;
                dr.EndEdit();
            }

            pendakiTableAdapter2.Update(suwantingDataSet4);


            btn_tambah.Enabled = true;
            btn_edit.Enabled = true;
            btn_hapus.Enabled = true;
            btn_batal.Enabled = false;

            NIK.Enabled = false;
            nama_lengkap.Enabled = false;
            berat_badan.Enabled = false;
            no_hp.Enabled = false;
            kota_domisili.Enabled = false;
            kode_rombongan.Enabled = false;

            this.pendakiTableAdapter2.Fill
                (this.suwantingDataSet4.pendaki);
            btn_simpan.Enabled = true;
            btn_hapus.Enabled=true;
            btn_edit.Enabled=true;
            btn_batal.Enabled=true;
            btn_tambah.Enabled=true;

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
            code = NIK.Text;
            //mencari data yang akan dihapus berdasarkan primary key
            dr = suwantingDataSet4.Tables["pendaki"].Rows.Find(code);
            //menghapus data
            dr.Delete();
            pendakiTableAdapter2.Update(suwantingDataSet4);
        }

        private void bARANGBAWAANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarangBawaan masuk_BarangBawaan = new BarangBawaan();

            masuk_BarangBawaan.Show();
            this.Hide();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            NIK.Enabled = false;
            nama_lengkap.Enabled = false;
            berat_badan.Enabled = false;
            no_hp.Enabled = false;
            kota_domisili.Enabled = false;
            kode_rombongan.Enabled = false;


            this.pendakiTableAdapter2.Fill
                (this.suwantingDataSet4.pendaki);
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
            NIK.Enabled = true;
            nama_lengkap.Enabled = true;
            berat_badan.Enabled = true;
            no_hp.Enabled = true;
            kota_domisili.Enabled = true;
            kode_rombongan.Enabled = true;

            btn_tambah.Enabled = false;
            btn_edit.Enabled = false;
            btn_hapus.Enabled = false;
            btn_batal.Enabled = true;
        }

        private void bARANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Barang masukBarang = new Barang();

            masukBarang.Show();

            this.Hide();
        }
    }
}
