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
using MySql.Data.MySqlClient;

namespace Inventory
{
    public partial class Report : Form
    {

        static string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public Report()
        {
            InitializeComponent();

        }

        public void viewsItem()
        {
            MySqlConnection connauj = new MySqlConnection(connection);
            connauj.Open();
            try
            {
                int i = 0;
                dataGridView1.Rows.Clear();
                MySqlCommand Comauj = new MySqlCommand() { Connection = connauj, CommandText = "SELECT * from iteminventory" };
                MySqlDataReader readerauj = Comauj.ExecuteReader();
                while (readerauj.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, readerauj["prodcode"].ToString(), readerauj["description"].ToString(), readerauj["item"].ToString(), readerauj["class"].ToString(), readerauj["size"].ToString(), readerauj["casee"].ToString(), readerauj["packs"].ToString(), readerauj["itemclass"].ToString(), readerauj["packaging"].ToString(), readerauj["unit"].ToString(), readerauj["price"].ToString(), readerauj["total"].ToString(), int.Parse(readerauj["quantity"].ToString()), readerauj["ID"].ToString());
                }

                connauj.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void viewsStockIn()
        {
            MySqlConnection connauj = new MySqlConnection(connection);
            connauj.Open();
            try
            {
                int i = 0;
                dataGridView2.Rows.Clear();
                //MySqlCommand Comauj = new MySqlCommand() { Connection = connauj, CommandText = "SELECT * from itemstockin WHERE date LIKE '" + date.Value.ToString("yyyy-MM-dd") + "%'" };
                MySqlCommand Comauj = new MySqlCommand() { Connection = connauj, CommandText = "SELECT * from itemstockin" };
                MySqlDataReader readerauj = Comauj.ExecuteReader();
                while (readerauj.Read())
                {
                    i++;
                    dataGridView2.Rows.Add(i, readerauj["item"].ToString(), readerauj["unit"].ToString(), readerauj["quantity"].ToString(), readerauj["addedquantity"].ToString(), readerauj["total"].ToString(), readerauj["careof"].ToString(), readerauj["ID"].ToString());
                }

                connauj.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void viewsStockOut()
        {
            MySqlConnection connauj = new MySqlConnection(connection);
            connauj.Open();
            try
            {
                int i = 0;
                dataGridView3.Rows.Clear();
                //MySqlCommand Comauj = new MySqlCommand() { Connection = connauj, CommandText = "SELECT * from itemstockout WHERE date LIKE '" + date.Value.ToString("yyyy-MM-dd") + "%'" };
                MySqlCommand Comauj = new MySqlCommand() { Connection = connauj, CommandText = "SELECT * from itemstockout" };
                MySqlDataReader readerauj = Comauj.ExecuteReader();
                while (readerauj.Read())
                {
                    i++;
                    dataGridView3.Rows.Add(i, readerauj["item"].ToString(), readerauj["fromm"].ToString(), readerauj["too"].ToString(), readerauj["unit"].ToString(), readerauj["outqty"].ToString(), readerauj["quantity"].ToString(), readerauj["total"].ToString(), readerauj["reqby"].ToString(), readerauj["driver"].ToString(), readerauj["plateno"].ToString(), readerauj["rcvdby"].ToString(), readerauj["time"].ToString(), readerauj["ID"].ToString());
                }

                connauj.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ReportItemInventory frm = new ReportItemInventory();
            frm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ReportStockIn frm = new ReportStockIn();
            frm.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ReportStockoutcs frm = new ReportStockoutcs();
            frm.ShowDialog();
        }
    }
}
