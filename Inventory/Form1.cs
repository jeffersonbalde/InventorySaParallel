using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form1 : Form
    {

        static string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN();
        }

        private void LOGIN()
        {

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;

            string name = "";

            try
            {
                cmd.CommandText = "SELECT name, username, password FROM accounts WHERE username ='" + textBox1.Text + "'  and password='" + textBox2.Text + "'";
                cmd.CommandTimeout = 3600;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    name = dr["name"].ToString();
                    MainForm h = new MainForm();
                    h.lblName.Text = name;
                    this.Hide();
                    h.Show();
                    h.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
