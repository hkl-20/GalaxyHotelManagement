using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GalaxyHotelManagement
{
    public partial class EmployeeShifts : Form
    {
        public EmployeeShifts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivityPortal dumb = new ActivityPortal();
            dumb.Show();
            this.Hide();
        }
    }
}
