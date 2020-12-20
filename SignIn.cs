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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        public string conString = "Data Source=DESKTOP-96RMDEQ;Initial Catalog=GalaxyHotelManagement;Integrated Security=True";
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand("Select * from logIn where Username=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", textBoxUserName.Text);
                cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    this.Hide();
                    ActivityPortal caccess = new ActivityPortal();
                    caccess.Show();
                }
                else
                {
                    MessageBox.Show("Signin Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            InitialSignIn caccess = new InitialSignIn();
            caccess.Show();
            this.Hide();
        }
    }
}
