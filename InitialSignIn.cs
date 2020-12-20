using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GalaxyHotelManagement
{
    public partial class InitialSignIn : Form
    {
        public InitialSignIn()
        {
            InitializeComponent();
        }

        private void FormLogInAs_Load(object sender, EventArgs e)
        {

        }

        private void labelSignIn_Click(object sender, EventArgs e)
        {

        }

        private void buttonVisitor_Click(object sender, EventArgs e)
        {
            CustomerGuide caccess = new CustomerGuide();
            caccess.Show();
            this.Hide();
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            SignIn access = new SignIn();
            access.Show();
            this.Hide();
        }
    }
}
