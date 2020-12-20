using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GalaxyHotelManagement
{
    public partial class EmployeeRemoval : Form
    {
        public EmployeeRemoval()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Employee Removal", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            EmployeeAdditionRemoval cass = new EmployeeAdditionRemoval();
            cass.Show();
            this.Close();
        }
    }
}
