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
    public partial class DashboardForm : Form
    {
        static string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        int totalItems;
        int totalQuantity;

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        public void getTotalItems()
        {
            MySqlConnection connauj = new MySqlConnection(connection);
            connauj.Open();
            try
            {
                MySqlCommand Comauj = new MySqlCommand() { Connection = connauj, CommandText = "SELECT COUNT(item) AS item from iteminventory" };
                MySqlDataReader readerauj = Comauj.ExecuteReader();
                while (readerauj.Read())
                {
                    totalItems = int.Parse(readerauj["item"].ToString());
                    lblItems.Text = totalItems.ToString();
                }

                connauj.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getTotalQuantity()
        {
            MySqlConnection connauj = new MySqlConnection(connection);
            connauj.Open();
            try
            {
                MySqlCommand Comauj = new MySqlCommand() { Connection = connauj, CommandText = "SELECT SUM(quantity) AS quantity FROM iteminventory" };
                MySqlDataReader readerauj = Comauj.ExecuteReader();
                while (readerauj.Read())
                {
                    totalQuantity = int.Parse(readerauj["quantity"].ToString());
                    lblStocks.Text = totalQuantity.ToString();
                }

                connauj.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            getTotalItems();
            getTotalQuantity();
        }
    }
}
