using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace sorgorg
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "database = sorg; server = 127.0.0.1; user = root; password = ;";
            MySqlConnection conn = new MySqlConnection(connection);

            string name = textBox1.Text;
            string lname = textBox2.Text;
            string email = textBox3.Text;
            string pass = textBox4.Text;

            if (name == "" || lname == "" || email == "" || pass == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }


            string query = "INSERT INTO users (name, lname, email, password) VALUES (@name, @lname, @email, @pass)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pass", pass);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }
    }
}
