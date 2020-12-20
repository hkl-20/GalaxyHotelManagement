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
    public partial class RoomAddition : Form
    {
        public RoomAddition()
        {
            InitializeComponent();
        }

        private void RoomAddition_Load(object sender, EventArgs e)
        {
            comboBoxFloorNo.Items.Add("Floor 1");
            comboBoxFloorNo.Items.Add("Floor 2");
            comboBoxFloorNo.Items.Add("Floor 3");
            comboBoxFloorNo.Items.Add("Floor 4");
            comboBoxFloorNo.Items.Add("Floor 5");

            comboBoxRoomType.Items.Add("Single Room");
            comboBoxRoomType.Items.Add("Double Room");
            comboBoxRoomType.Items.Add("Twin Room");
            comboBoxRoomType.Items.Add("King Size Room");
            comboBoxRoomType.Items.Add("Royal Suite");

            comboBoxNoOfBeds.Items.Add(1);
            comboBoxNoOfBeds.Items.Add(2);
            comboBoxNoOfBeds.Items.Add(3);
            comboBoxNoOfBeds.Items.Add(4);
            comboBoxNoOfBeds.Items.Add(5);

            comboBoxComplimentaryBenefits1.Items.Add("(None)");
            comboBoxComplimentaryBenefits1.Items.Add("Free Lunch");
            comboBoxComplimentaryBenefits1.Items.Add("Free Breakfast");
            comboBoxComplimentaryBenefits1.Items.Add("Free Dinner");
            comboBoxComplimentaryBenefits1.Items.Add("Additional Mattress");
            comboBoxComplimentaryBenefits1.Items.Add("Access to Pool and Gym");

            comboBoxComplimentaryBenefits2.Items.Add("(None)");
            comboBoxComplimentaryBenefits2.Items.Add("Free Lunch");
            comboBoxComplimentaryBenefits2.Items.Add("Free Breakfast");
            comboBoxComplimentaryBenefits2.Items.Add("Free Dinner");
            comboBoxComplimentaryBenefits2.Items.Add("Additional Mattress");
            comboBoxComplimentaryBenefits2.Items.Add("Access to Pool and Gym");

            comboBoxComplimentaryBenefits3.Items.Add("(None)");
            comboBoxComplimentaryBenefits3.Items.Add("Free Lunch");
            comboBoxComplimentaryBenefits3.Items.Add("Free Breakfast");
            comboBoxComplimentaryBenefits3.Items.Add("Free Dinner");
            comboBoxComplimentaryBenefits3.Items.Add("Additional Mattress");
            comboBoxComplimentaryBenefits3.Items.Add("Access to Pool and Gym");
        }

        private void labelComplimentaryBenefits_Click(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-96RMDEQ;Initial Catalog=GalaxyHotelManagement;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            if (comboBoxComplimentaryBenefits1.SelectedItem == null || comboBoxFloorNo.SelectedItem == null || comboBoxNoOfBeds.SelectedItem == null || comboBoxRoomType.SelectedItem == null || textBoxRoomNumber.Text.Trim() == string.Empty || textBoxRoomPrice.Text.Trim() == string.Empty || richTextBoxRooomDescription.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter all required values!");
            }
            else
            {
                con.Open();
                string cmdString = "INSERT INTO Rooms(roomNumber, floorNumber, roomType, numberOfBeds, complimentaryBenefits1, complimentaryBenefits2, complimentaryBenefits3, roomDescription, roomPrice)";
                string values = " VALUES('" + textBoxRoomNumber.Text + "', '" + comboBoxFloorNo.Text.ToString() + "', '" + comboBoxRoomType.Text.ToString() + "', '" + comboBoxNoOfBeds.Text.ToString() + "', '" + comboBoxComplimentaryBenefits1.Text.ToString() + "', '" + comboBoxComplimentaryBenefits2.Text.ToString() + "', '" + comboBoxComplimentaryBenefits3.Text.ToString() + "', '" + richTextBoxRooomDescription.Text + "', '" + textBoxRoomPrice.Text + "')";
                SqlCommand cmd = new SqlCommand(cmdString + values, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Room Added!");
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            RoomAdditionRemoval really = new RoomAdditionRemoval();
            really.Show();
            this.Close();
        }
    }
}
