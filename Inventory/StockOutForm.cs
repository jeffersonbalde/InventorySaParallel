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
    public partial class StockOutForm : Form
    {

        static string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public StockOutForm()
        {
            InitializeComponent();
        }

        public void LoadTotal()
        {
            int total;
            MySqlConnection connauj = new MySqlConnection(connection);
            connauj.Open();
            //try
            //{

            MySqlCommand Comauj = new MySqlCommand() { Connection = connauj, CommandText = "SELECT * from iteminventory where  item ='" + txtItem.Text + "'" };
            MySqlDataReader readerauj = Comauj.ExecuteReader();
            while (readerauj.Read())
            {
                try
                {
                    total = int.Parse(readerauj["quantity"].ToString());
                    int outqty = int.Parse(txtOutQty.Text);
                    double result = total - outqty;
                    txtTotal.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    txtOutQty.Text = "";
                }
            }
            connauj.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        public void LoadItemUnitAndQuantityTotal()
        {
            MySqlConnection connauj = new MySqlConnection(connection);
            connauj.Open();
            try
            {

                MySqlCommand Comauj = new MySqlCommand() { Connection = connauj, CommandText = "SELECT * from iteminventory where  item ='" + txtItem.Text + "'" };
                MySqlDataReader readerauj = Comauj.ExecuteReader();
                while (readerauj.Read())
                {
                    txtUnit.Text = readerauj["unit"].ToString();
                    txtQuantity.Text = readerauj["quantity"].ToString();
                    txtID.Text = readerauj["ID"].ToString();
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
            MySqlConnection conn1 = new MySqlConnection(connection);
            MySqlCommand cmd;

            conn1.Open();

            try
            {
                if (txtItem.Text == "" || txtFrom.Text == "" || txtTo.Text == "")
                {
                    MessageBox.Show("Please fill up all fields");
                    return;
                }

                cmd = conn1.CreateCommand();
                cmd.CommandText = "INSERT INTO itemstockout(date,fromm,too,item,unit,outqty,quantity,total,reqby,driver,plateno,rcvdby,time)VALUES('" + date.Value.ToString("yyyy-MM-dd") + "','" + txtFrom.Text + "','" + txtTo.Text + "','" + txtItem.Text + "','" + txtUnit.Text + "','" + txtOutQty.Text + "','" + txtQuantity.Text + "','" + txtTotal.Text + "','" + txtReqBy.Text + "','" + txtDriver.Text + "','" + txtPlateNo.Text + "','" + txtRcvdBy.Text + "','" + txtTime.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("SAVE");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn1.Close();
            clear();
        }

        public void clear()
        {
            txtFrom.Text = "";
            txtTo.Text = "";
            txtItem.Text = "";
            txtUnit.Text = "";
            txtOutQty.Text = "";
            txtQuantity.Text = "";
            txtTotal.Text = "";
            txtReqBy.Text = "";
            txtDriver.Text = "";
            txtPlateNo.Text = "";
            txtRcvdBy.Text = "";
            txtTime.Text = "";
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            LoadItemUnitAndQuantityTotal();
        }

        private void StockOutForm_Load(object sender, EventArgs e)
        {
            auto1();
        }

        public void auto1()
        {
            MySqlConnection conn1 = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT item from iteminventory", conn1);
            conn1.Open();
            AutoCompleteStringCollection strcol = new AutoCompleteStringCollection();
            MySqlDataReader myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {
                strcol.Add(myReader.GetString(0));
            }
            txtItem.AutoCompleteCustomSource = strcol;
            txtItem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtItem.AutoCompleteMode = AutoCompleteMode.Suggest;
            conn1.Close();
        }

        private void txtOutQty_TextChanged(object sender, EventArgs e)
        {
            LoadTotal();
        }

        public void views()
        {
            MySqlConnection connauj = new MySqlConnection(connection);
            connauj.Open();
            try
            {
                int i = 0;
                dataGridView1.Rows.Clear();
                MySqlCommand Comauj = new MySqlCommand() { Connection = connauj, CommandText = "SELECT * from itemstockout WHERE date LIKE '" + date.Value.ToString("yyyy-MM-dd") + "%'" };
                MySqlDataReader readerauj = Comauj.ExecuteReader();
                while (readerauj.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, readerauj["item"].ToString(), readerauj["unit"].ToString(), readerauj["quantity"].ToString(), readerauj["addedquantity"].ToString(), readerauj["total"].ToString(), readerauj["careof"].ToString(), readerauj["ID"].ToString());
                }

                connauj.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
