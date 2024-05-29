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
    public partial class Barang : Form
    {

        DataTable dt;
        DataRow dr;
        string code;
        int bttn;

        public Barang()
        {
            InitializeComponent();
        }

        private void Barang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'suwantingDataSet6.barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.suwantingDataSet6.barang);

            btn_simpan.Enabled = false;
            id_barang.Enabled = false;
            nama_barang.Enabled = false;
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utama utama = new Utama();

            utama.Show();

            this.Hide();
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

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            bttn = 1;
            tambah();
        }

        public void tambah()
        {
            btn_simpan.Enabled = true;
            id_barang.Enabled = true;
            nama_barang.Enabled = true;
            

            dt = suwantingDataSet6.Tables["barang"];

            id_barang.Text = " ";
            nama_barang.Text = " ";

            btn_tambah.Enabled = false;
            btn_edit.Enabled = false;
            btn_hapus.Enabled = false;
            btn_batal.Enabled = true;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (bttn == 1)
            {
                dt = suwantingDataSet6.Tables["barang"];
                //Menyimpan data kedalam database
                dr = dt.NewRow();
                dr[0] = id_barang.Text;
                dr[1] = nama_barang.Text;

                dt.Rows.Add(dr);
            }
            else
            {
                dt = suwantingDataSet6.Tables["barang"];
                //mencari primary key yang akan diubah datanya
                dr = dt.Rows.Find(id_barang.Text);

                //mengubah data kedalam database
                dr.BeginEdit();
                dr["nama_barang"] = nama_barang.Text;
                dr.EndEdit();
            }

            barangTableAdapter.Update(suwantingDataSet6);


            btn_tambah.Enabled = true;
            btn_edit.Enabled = true;
            btn_hapus.Enabled = true;
            btn_batal.Enabled = false;

            id_barang.Enabled = false;
            nama_barang.Enabled = false;

            this.barangTableAdapter.Fill
                (this.suwantingDataSet6.barang);
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
            code = id_barang.Text;
            //mencari data yang akan dihapus berdasarkan primary key
            dr = suwantingDataSet6.Tables["barang"].Rows.Find(code);
            //menghapus data
            dr.Delete();
            barangTableAdapter.Update(suwantingDataSet6);
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            id_barang.Enabled = false;
            nama_barang.Enabled = false;

            this.barangTableAdapter.Fill
                (this.suwantingDataSet6.barang);
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
            id_barang.Enabled = true;
            nama_barang.Enabled = true;

            btn_tambah.Enabled = false;
            btn_edit.Enabled = false;
            btn_hapus.Enabled = false;
            btn_batal.Enabled = true;
        }

        private void bARANGBAWAANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarangBawaan masuk_BarangBawaan = new BarangBawaan();

            masuk_BarangBawaan.Show();
            this.Hide();
        }
    }
}
