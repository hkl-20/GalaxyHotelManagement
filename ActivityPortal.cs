using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace GalaxyHotelManagement
{
    public partial class ActivityPortal : Form
    {
        public ActivityPortal()
        {
            InitializeComponent();
        }

        private void ActivityPortal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeAdditionRemoval caccess = new EmployeeAdditionRemoval();
            caccess.Show();
            this.Hide();
        }

        private void buttonRoomAdditionRemoval_Click(object sender, EventArgs e)
        {
            RoomAdditionRemoval cess = new RoomAdditionRemoval();
            cess.Show();
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            InitialSignIn cess = new InitialSignIn();
            cess.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomBooking esc = new RoomBooking();
            esc.Show();
            this.Hide();
        }

        private void buttonEmployeeShifts_Click(object sender, EventArgs e)
        {
            EmployeeShifts desc = new EmployeeShifts();
            desc.Show();
            this.Hide();
        }

        private void buttonCustomerCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut yess = new CheckOut();
            yess.Show();
            this.Close();
        }
    }
}
