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
    public partial class FormBooking : Form
    {
        public FormBooking()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void FormBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'suwantingDataSet.booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.suwantingDataSet.booking);

        }
    }
}
