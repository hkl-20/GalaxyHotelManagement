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
    public partial class DeleteReservation : Form
    {
        public DeleteReservation()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-96RMDEQ;Initial Catalog=GalaxyHotelManagement;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM Reservations WHERE reservedUsername = '" +textBoxReserveeUsername.Text+ "' AND reservedPassword = '" +textBoxPassword.Text+ "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation deleted");
            con.Close();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            CustomerGuide yolo = new CustomerGuide();
            yolo.Show();
            this.Close();
        }
    }
}
