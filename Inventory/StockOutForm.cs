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

        int currentQuantity;

        public StockOutForm()
        {
            InitializeComponent();
            views();
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
                MySqlCommand Comauj = new MySqlCommand() { Connection = conn1, CommandText = "SELECT * from iteminventory where  item ='" + txtItem.Text + "'" };
                MySqlDataReader readerauj = Comauj.ExecuteReader();
                while (readerauj.Read())
                {
                    currentQuantity = int.Parse(readerauj["quantity"].ToString());
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn1.Close();

            conn1.Open();
            try
            {
                if (txtItem.Text == "" || txtFrom.Text == "" || txtTo.Text == "")
                {
                    MessageBox.Show("Please fill required fields");
                    return;
                }

                if(int.Parse(txtOutQty.Text) > currentQuantity)
                {
                    MessageBox.Show("The out quantity exceeds the item quantity. Please review the item quantity.", "Quantity Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cmd = conn1.CreateCommand();
                cmd.CommandText = "INSERT INTO itemstockout(date,fromm,too,item,unit,outqty,quantity,total,reqby,driver,plateno,rcvdby,time)VALUES('" + date.Value.ToString("yyyy-MM-dd") + "','" + txtFrom.Text + "','" + txtTo.Text + "','" + txtItem.Text + "','" + txtUnit.Text + "','" + txtOutQty.Text + "','" + txtQuantity.Text + "','" + txtTotal.Text + "','" + txtReqBy.Text + "','" + txtDriver.Text + "','" + txtPlateNo.Text + "','" + txtRcvdBy.Text + "','" + txtTime.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("SAVE");
                views();
                UpdateQuantity();
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
                    dataGridView1.Rows.Add(i, readerauj["item"].ToString(), readerauj["fromm"].ToString(), readerauj["too"].ToString(), readerauj["unit"].ToString(), readerauj["outqty"].ToString(), readerauj["quantity"].ToString(), readerauj["total"].ToString(), readerauj["reqby"].ToString(), readerauj["driver"].ToString(), readerauj["plateno"].ToString(), readerauj["rcvdby"].ToString(), readerauj["time"].ToString(), readerauj["ID"].ToString());
                }

                connauj.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateQuantity()
        {
            MySqlConnection conzx = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("update iteminventory set quantity = quantity - " + txtOutQty.Text + " WHERE ID = '" + txtID.Text + "'", conzx);
            conzx.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            conzx.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text == "" || txtTo.Text == "")
            {
                MessageBox.Show("Please fill up all fields");
                return;
            }

            try
            {
                MySqlConnection conzx = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand("update itemstockout set fromm=@fromm,too=@too,reqby=@reqby,driver=@driver,plateno=@plateno,rcvdby=@rcvdby,time=@time WHERE ID = @ID", conzx);
                conzx.Open();
                cmd.Parameters.AddWithValue("@fromm", txtFrom.Text);
                cmd.Parameters.AddWithValue("@too", txtTo.Text);
                cmd.Parameters.AddWithValue("@reqby", txtReqBy.Text);
                cmd.Parameters.AddWithValue("@driver", txtDriver.Text);
                cmd.Parameters.AddWithValue("@plateno", txtPlateNo.Text);
                cmd.Parameters.AddWithValue("@rcvdby", txtRcvdBy.Text);
                cmd.Parameters.AddWithValue("@time", txtTime.Text);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conzx.Close();
                views();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (colName == "select")
            {
                txtItem.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtFrom.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtUnit.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtOutQty.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtTotal.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtReqBy.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtDriver.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtPlateNo.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtRcvdBy.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtTime.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text == "" || txtTo.Text == "")
            {
                MessageBox.Show("Please fill up all fields");
                return;
            }

            MySqlConnection conn1 = new MySqlConnection(connection);
            MySqlCommand cmd;
            conn1.Open();
            try
            {
                cmd = conn1.CreateCommand();
                cmd.CommandText = "DELETE FROM itemstockout where ID='" + txtID.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn1.Close();
            views();
            clear();
        }

        private void btnInRpt_Click(object sender, EventArgs e)
        {
            ReportStockoutcs frm = new ReportStockoutcs();
            frm.ShowDialog();
        }
    }
}
