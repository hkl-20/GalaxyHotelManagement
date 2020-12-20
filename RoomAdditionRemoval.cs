using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GalaxyHotelManagement
{
    public partial class RoomAdditionRemoval : Form
    {
        public RoomAdditionRemoval()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoomRemoval trick = new RoomRemoval();
            trick.Show();
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ActivityPortal cass = new ActivityPortal();
            cass.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomAddition yess = new RoomAddition();
            yess.Show();
            this.Close();
        }
    }
}
