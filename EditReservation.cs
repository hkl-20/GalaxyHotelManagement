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
    public partial class EditReservation : Form
    {
        public EditReservation()
        {
            InitializeComponent();
        }

        private void EditReservation_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePickerArrivalDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDepartureDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerGuide CG = new CustomerGuide();
            CG.Show();
            this.Close();
        }

        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-96RMDEQ;Initial Catalog=GalaxyHotelManagement;Integrated Security=True"))
            {
                string cmdString = "SELECT reservedFirstName, reservedLastName, reservedAddress, reservedEmailAddress, reservedPhoneNumber, reservedTotalRooms, reservedTotalAdults, reservedTotalChildren, reservedPreference1, reservedPreference2, reservedDepartureDate, reservedArrivalDate, questionsComments FROM Reservations WHERE reservedUsername = '" + textBoxUsername.Text + "' AND reservedPassword = '" + textBoxPassword.Text + "'";
                using (SqlCommand cmmd = new SqlCommand(cmdString))
                {
                    cmmd.CommandType = CommandType.Text;
                    cmmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmmd.ExecuteReader())
                    {
                        sdr.Read();
                        textBoxFirstName.Text = sdr["reservedFirstName"].ToString();
                        textBoxLastName.Text = sdr["reservedLastName"].ToString();
                        textBoxAddress.Text = sdr["reservedAddress"].ToString();
                        textBoxEmailAddress.Text = sdr["reservedEmailAddress"].ToString();
                        textBoxPhoneNumber.Text = sdr["reservedPhoneNumber"].ToString();
                        textBoxTotalRooms.Text = sdr["reservedTotalRooms"].ToString();
                        textBoxTotalAdults.Text = sdr["reservedTotalAdults"].ToString();
                        textBoxTotalChildren.Text = sdr["reservedTotalChildren"].ToString();
                        comboBoxPreference1.Text = sdr["reservedPreference1"].ToString();
                        comboBoxPreference2.Text = sdr["reservedPreference2"].ToString();
                        dateTimePickerDepartureDate.Text = sdr["reservedDepartureDate"].ToString();
                        dateTimePickerArrivalDate.Text = sdr["reservedArrivalDate"].ToString();
                        richTextBoxQuestionsComments.Text = sdr["questionsComments"].ToString();
                    }
                    con.Close();
                }
            }
        }

        SqlConnection cons = new SqlConnection("Data Source=DESKTOP-96RMDEQ;Initial Catalog=GalaxyHotelManagement;Integrated Security=True");
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && textBoxPassword.Text != "")
            {
                //work on this later
                cons.Open();
                SqlCommand cmd = new SqlCommand("update Reservations SET reservedFirstName=@rfm, reservedLastName=@rlm, reservedAddress=@ra, reservedEmailAddress=@rea, reservedPhoneNumber=@rpn, reservedTotalRooms=@rtm, reservedTotalAdults=@rta, reservedTotalChildren=@rtc, reservedPreference1=@rp1, reservedPreference2=@rp2, reservedDepartureDate=@rdd, reservedArrivalDate=@rad, questionsComments=@qc WHERE reservedUsername = @ru)", cons);
                cmd.Parameters.AddWithValue("@rfm", textBoxFirstName.Text);
                cmd.Parameters.AddWithValue("@rlm", textBoxLastName.Text);
                cmd.Parameters.AddWithValue("@ra", textBoxAddress.Text);
                cmd.Parameters.AddWithValue("@rea", textBoxEmailAddress.Text);
                cmd.Parameters.AddWithValue("@rpn", textBoxPhoneNumber);
                cmd.Parameters.AddWithValue("@rtm", textBoxTotalRooms);
                cmd.Parameters.AddWithValue("@rta", textBoxTotalAdults);
                cmd.Parameters.AddWithValue("@rtc", textBoxTotalChildren);
                cmd.Parameters.AddWithValue("@rp1", comboBoxPreference1.Text);
                cmd.Parameters.AddWithValue("@rp2", comboBoxPreference2.Text);
                cmd.Parameters.AddWithValue("@rdd", dateTimePickerDepartureDate.Value);
                cmd.Parameters.AddWithValue("@rad", dateTimePickerArrivalDate.Value);
                cmd.Parameters.AddWithValue("@qc", richTextBoxQuestionsComments.Text);
                cmd.Parameters.AddWithValue("@ru", textBoxUsername.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                cons.Close();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }
    }
}
