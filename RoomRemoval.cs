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
    public partial class RoomRemoval : Form
    {
        public RoomRemoval()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Rooms where roomID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomAdditionRemoval cess = new RoomAdditionRemoval();
            cess.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClearData()
        {
            textBox1.Text = "";
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-96RMDEQ;Initial Catalog=GalaxyHotelManagement;Integrated Security=True");

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Rooms", con);
            adapt.Fill(dt);
            dataGridViewRoomList.DataSource = dt;
            con.Close();
        }

        private void RoomRemoval_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}
