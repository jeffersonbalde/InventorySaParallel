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
    public partial class StockInForm : Form
    {

        static string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public StockInForm()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtItem.Text = "";
            txtUnit.Text = "";
            txtQuantity.Text = "";
            txtAddedQuantity.Text = "";
            txtTotal.Text = "";
            txtCareOf.Text = "";
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
                        int addqty = int.Parse(txtAddedQuantity.Text);
                        double result = total + addqty;
                        txtTotal.Text = result.ToString();
                    }
                    catch(Exception ex)
                    {
                        txtAddedQuantity.Text = "";
                    }
                }
                connauj.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        public void LoadItemUnitAndQuantity()
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

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            LoadItemUnitAndQuantity();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn1 = new MySqlConnection(connection);
            MySqlCommand cmd;

            conn1.Open();

            try
            {
                if (txtItem.Text == "" || txtAddedQuantity.Text == "" || txtTotal.Text == "" || txtCareOf.Text == "")
                {
                    MessageBox.Show("Please fill up all fields");
                    return;
                }

                cmd = conn1.CreateCommand();
                cmd.CommandText = "INSERT INTO itemstockin(date,item,unit,quantity,addedquantity,total,careof)VALUES('" + date.Value.ToString("yyyy-MM-dd") + "','" + txtItem.Text + "','" + txtUnit.Text + "','" + txtQuantity.Text + "','" + txtAddedQuantity.Text + "','" + txtTotal.Text + "','" + txtCareOf.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("SAVE");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn1.Close();
            UpdateQuantity();
            views();
            clear();
        }

        public void UpdateQuantity()
        {
            MySqlConnection conzx = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("update iteminventory set quantity = quantity + " + txtAddedQuantity.Text + " WHERE ID = '" + txtID.Text + "'", conzx);
            conzx.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            conzx.Close();
        }

        public void views()
        {
            MySqlConnection connauj = new MySqlConnection(connection);
            connauj.Open();
            try
            {
                int i = 0;
                dataGridView1.Rows.Clear();
                MySqlCommand Comauj = new MySqlCommand() { Connection = connauj, CommandText = "SELECT * from itemstockin" };
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (colName == "select")
            {
                txtItem.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtUnit.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtAddedQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTotal.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCareOf.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtItem.Text == "" || txtAddedQuantity.Text == "")
            {
                MessageBox.Show("Please fill up all fields");
                return;
            }

            try
            {
                MySqlConnection conzx = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand("update itemstockin set item=@item,unit=@unit,quantity=@quantity,addedquantity=@addedquantity,total=@total,careof=@careof WHERE ID = @ID", conzx);
                conzx.Open();
                cmd.Parameters.AddWithValue("@item", txtItem.Text);
                cmd.Parameters.AddWithValue("@unit", txtUnit.Text);
                cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@addedquantity", txtAddedQuantity.Text);
                cmd.Parameters.AddWithValue("@total", txtTotal.Text);
                cmd.Parameters.AddWithValue("@careof", txtCareOf.Text);
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (txtItem.Text == "" || txtAddedQuantity.Text == "")
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
                cmd.CommandText = "DELETE FROM itemstockin where ID='" + txtID.Text + "'";
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

        private void buttonInRpt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("working pa");
        }

        private void StockInForm_Load(object sender, EventArgs e)
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
            
            while(myReader.Read())
            {
                strcol.Add(myReader.GetString(0));
            }
            txtItem.AutoCompleteCustomSource = strcol;
            txtItem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtItem.AutoCompleteMode = AutoCompleteMode.Suggest;
            conn1.Close();
        }

        private void txtAddedQuantity_TextChanged(object sender, EventArgs e)
        {
            LoadTotal();
        }
    }
}