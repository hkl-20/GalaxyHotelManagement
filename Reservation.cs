using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace GalaxyHotelManagement
{
    public partial class Reservation : Form
    {
        public string conString = "Data Source=localhost;Initial Catalog=GalaxyHotelManagementSystem;Integrated Security=True";
        public Reservation()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            comboBoxPreference1.Items.Add("Single Room");
            comboBoxPreference1.Items.Add("Double Room");
            comboBoxPreference1.Items.Add("Twin Room");
            comboBoxPreference1.Items.Add("King Size Room");
            comboBoxPreference1.Items.Add("Royal Suite");

            comboBoxPreference2.Items.Add("Single Room");
            comboBoxPreference2.Items.Add("Double Room");
            comboBoxPreference2.Items.Add("Twin Room");
            comboBoxPreference2.Items.Add("King Size Room");
            comboBoxPreference2.Items.Add("Royal Suite");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBoxPreference2.Items.Count; i++)
            {
                if (comboBoxPreference2.Items[i] == comboBoxPreference1.SelectedItem)
                {
                    comboBoxPreference2.Items.Remove(comboBoxPreference2.Items[i]);
                    i--;
                }
            }
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void groupBoxDepartureArrival_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerDepartureDate.Value.Date > dateTimePickerArrivalDate.Value.Date)
            {
                MessageBox.Show("Departure date should be greater or equal to the arrival date");
            }
        }

        private void labelArrivalDate_Click(object sender, EventArgs e)
        {

        }

        SqlConnection constring = new SqlConnection("Data Source=DESKTOP-96RMDEQ;Initial Catalog=GalaxyHotelManagement;Integrated Security=True");
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT reservedUsername FROM Reservations WHERE reservedUsername = '" +textBoxReservedUsername.Text+ "' ",constring);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Username already exists");
            }
            else
            {
                constring.Open();
                string cmdstring = "INSERT INTO Reservations(reservedFirstName, reservedLastName, reservedAddress, reservedEmailAddress, reservedPhoneNumber, reservedTotalRooms, reservedTotalAdults, reservedTotalChildren, reservedPreference1, reservedPreference2, reservedDepartureDate, reservedArrivalDate, questionsComments, reservedUsername, reservedPassword)";
                string values = " VALUES('" +textBoxFirstName.Text+ "', '" +textBoxLastName.Text+ "', '" +textBoxAddress.Text+ "', '" +textBoxEmailAddress.Text+ "', '" +textBoxPhoneNumber.Text+ "', '" +textBoxtotalRooms.Text+ "', '" +textBoxtotalAdults.Text+ "', '" +textBoxtotalChildren.Text+ "', '" +comboBoxPreference1.Text.ToString()+ "', '" +comboBoxPreference2.Text.ToString()+ "', '"+dateTimePickerDepartureDate.Value.ToString("yyyy-MM-dd") + "', '" +dateTimePickerArrivalDate.Value.ToString("yyyy-MM-dd")+ "', '" +richTextBoxQuestionsComments.Text+ "', '"+textBoxReservedUsername.Text+"', '" +textBoxReservedPassword.Text+ "')";
                SqlCommand cmd = new SqlCommand(cmdstring + values, constring);
                cmd.ExecuteNonQuery();
                constring.Close();
                MessageBox.Show("reservation completed");
                CustomerGuide very = new CustomerGuide();
                very.Show();
                this.Close();
            }
            /*
            MailAddress from = new MailAddress("galaxy.reservation.hotel@gmail.com", "Galaxy Hotel Reservation");
            MailAddress to = new MailAddress(textBoxEmailAddress.Text.ToString(), "Galaxy Hotel Reservation");
            List<MailAddress> cc = new List<MailAddress>();
            cc.Add(new MailAddress("ladhaniharis@gmail.com", "Galaxy Hotel Reservation"));
            SendEmail("Hotel Reservation Successful", from, to, cc);
            */

        }
        /*
        protected void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null)
        {
            string Text = "Your Username ='" +textBoxReservedUsername.Text+ "' and your password is = '" +textBoxReservedPassword.Text+ "'" ;
            SmtpClient mailClient = new SmtpClient("Mailhost");
            MailMessage msgMail;
            Text = "Hotel Reservation";
            msgMail = new MailMessage();
            msgMail.From = _from;
            msgMail.To.Add(_to);
            foreach (MailAddress addr in _cc)
            {
                msgMail.CC.Add(addr);
            }
            if (_bcc != null)
            {
                foreach (MailAddress addr in _bcc)
                {
                    msgMail.Bcc.Add(addr);
                }
            }
            msgMail.Subject = _subject;
            msgMail.Body = Text;
            msgMail.IsBodyHtml = true;
            mailClient.Send(msgMail);
            msgMail.Dispose();
        }
        */
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerArrivalDate.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Arrival date should be greater or equal to the current date");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CustomerGuide caccess = new CustomerGuide();
            caccess.Show();
            this.Hide();
        }

        private void groupBoxRoomPreference_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxPreference2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBoxPreference1.Items.Count; i++)
            {
                if (comboBoxPreference1.Items[i] == comboBoxPreference2.SelectedItem)
                {
                    comboBoxPreference1.Items.Remove(comboBoxPreference1.Items[i]);
                    i--;
                }
            }
        }
    }
}
