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
            string postion = "";

            try
            {
                cmd.CommandText = "SELECT * FROM accounts WHERE username ='" + textBox1.Text + "'  and password='" + textBox2.Text + "'";
                cmd.CommandTimeout = 3600;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    name = dr["name"].ToString();
                    postion = dr["position"].ToString();
                    MainForm h = new MainForm();
                    if(postion != "System Administrator")
                    {
                        h.btnDashboard.Enabled = false;
                        h.btnStockIn.Enabled = false;
                        h.btnStockOut.Enabled = false;
                        h.btnReport.Enabled = false;
                        h.btnInventory.Enabled = false;
                    }
                    h.lblPosition.Text = postion;
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
