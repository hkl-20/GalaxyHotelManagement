using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GalaxyHotelManagement
{
    public partial class EmployeeAdditionRemoval : Form
    {
        public EmployeeAdditionRemoval()
        {
            InitializeComponent();
        }

        private void EmployeeAdditionRemoval_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeAddition caccess = new EmployeeAddition();
            caccess.Show();
            this.Hide();
        }

        private void buttonRemoveEmployee_Click(object sender, EventArgs e)
        {
            EmployeeRemoval cas = new EmployeeRemoval();
            cas.Show();
            this.Hide();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            ActivityPortal cass = new ActivityPortal();
            cass.Show();
            this.Hide();
        }
    }
}
