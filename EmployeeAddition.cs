using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GalaxyHotelManagement
{
    public partial class EmployeeAddition : Form
    {
        public EmployeeAddition()
        {
            InitializeComponent();
        }

        private void EmployeeAddition_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxPersonalInfo_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            ActivityPortal caccess = new ActivityPortal();
            caccess.Show();
            this.Hide();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-96RMDEQ;Initial Catalog=GalaxyHotelManagement;Integrated Security=True");
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            con.Open();
            string dt = "2050-12-12";
            string cmdString = "INSERT INTO Employee(employeeFirstName, employeeLastName, employeeAddress, employeeOtherAddress, employeeEmailAddress, employeePhoneNumber, employeeEmergencyContact, employeeECNumber, employeeEC1, employeeEC1Number, employeeEC2, employeeEC2Number, employementPosition, employeeJoiningDate, employeeLeavingDate)";
            string values = " VALUES('" + textBoxFirstName.Text + "', '" + textBoxLastName.Text + "', '" + textBoxAddress1.Text + "', '" + textBoxAddress2.Text + "', '" + textBoxEmailAddress.Text + "', '" + textBoxPhoneNumber.Text + "', '" + textBoxEC1.Text + "', '" + textBoxEC1Number.Text + "', '" + textBoxEC2.Text + "', '" + textBoxEC2Number.Text + "', '" + textBoxEC3.Text + "', '" + textBoxEC3Number.Text + "', '" + comboBoxEmployedAs.Text.ToString() + "', '" + dateTimePickerJoiningDate.Value.ToString("yyyy-MM-dd") + "', '" +dt+ "')";
            SqlCommand cmd = new SqlCommand(cmdString + values, con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
        }
    }
}
