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
                    txtTotal.Text = readerauj["total"].ToString();
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
                cmd.CommandText = "INSERT INTO itemstockout(date,from,to,item,unit,outqty,quantity,total,reqby,driver,plateno,rcvdby,time)VALUES('" + date.Value.ToString("yyyy-MM-dd") + "','" + txtFrom.Text + "','" + txtTo.Text + "','" + txtItem.Text + "','" + txtUnit.Text + "','" + txtOutQty.Text + "','" + txtQuantity.Text + "','" + txtTotal.Text + "','" + txtReqBy.Text + "','" + txtDriver.Text + "','" + txtPlateNo.Text + "','" + txtRcvdBy.Text + "','" + txtTime.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("SAVE");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn1.Close();
        }

        //public void clear()
        //{
        //    txtItem.Text = "";
        //    txtUnit.Text = "";
        //    txtQuantity.Text = "";
        //    txtAddedQuantity.Text = "";
        //    txtTotal.Text = "";
        //    txtCareOf.Text = "";
        //}

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            LoadItemUnitAndQuantityTotal();
        }
    }
}
