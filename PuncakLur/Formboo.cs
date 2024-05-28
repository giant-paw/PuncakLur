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
                dr["jlr_turun"] = jlr_turun.Text;
                dr["jumlah_hari"] = jml_hari.Text;
                dr.EndEdit();
            }

            bookingTableAdapter.Update(suwantingDataSet);

            btn_tambah.Enabled = false;
            btn_edit.Enabled = false;
            btn_hapus.Enabled = false;
            btn_batal.Enabled = true;
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            kode_booking.Enabled = false;
            jalur_turun.Enabled = false;
            jml_hari.Enabled = false;

            this.bookingTableAdapter.Fill
                (this.suwantingDataSet.booking);
            btn_tambah.Enabled = true;
            btn_edit.Enabled = true;
            btn_hapus.Enabled = true;
            btn_simpan.Enabled = false;
            btn_batal.Enabled = false;
        }
    }
}
