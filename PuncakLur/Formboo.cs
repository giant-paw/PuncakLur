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
        }

    }
}
