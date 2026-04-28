using MySql.Data.MySqlClient;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "database = sorg; server = 127.0.0.1; user = root; password = ;";
            MySqlConnection conn = new MySqlConnection(connection);

            string email = textBox1.Text;
            string pass = textBox2.Text;

            if (email == "firma" || pass == "firma") {
                Firma form = new Firma();
                form.Show();

            }
            

        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register form = new Register();
            form.Show();
            this.Hide();
        }
    }
}
