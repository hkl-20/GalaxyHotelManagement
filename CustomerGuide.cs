using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GalaxyHotelManagement
{
    public partial class CustomerGuide : Form
    {
        public CustomerGuide()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonReserveRoom_Click(object sender, EventArgs e)
        {
            Reservation caccess = new Reservation();
            caccess.Show();
            this.Hide();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            InitialSignIn caccess = new InitialSignIn();
            caccess.Show();
            this.Hide();
        }

        private void buttonDeleteReservation_Click(object sender, EventArgs e)
        {
            DeleteReservation dlt = new DeleteReservation();
            dlt.Show();
            this.Close();
        }

        private void buttonEditReservation_Click(object sender, EventArgs e)
        {
            EditReservation erv = new EditReservation();
            erv.Show();
            this.Hide();
        }
    }
}
