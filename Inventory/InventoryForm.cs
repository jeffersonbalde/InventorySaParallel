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
    public partial class InventoryForm : Form
    {

        static string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        string item = "";
        string ID = "";

        public InventoryForm()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtProdcode.Text = "";
            txtDescription.Text = "";
            txtItem.Text = "";
            cboClass.Text = "";
            txtSize.Text = "";
            txtCase.Text = "";
            txtPacks.Text = "";
            cboItemClass.Text = "";
            cboPackaging.Text = "";
            txtUnit.Text = "";
            txtPrice.Text = "";
            txtTotal.Text = "";
            txtProdcode.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            if(colName == "select")
            {
                txtProdcode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtItem.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cboClass.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSize.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCase.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtCase.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtPacks.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                cboItemClass.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                cboPackaging.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtUnit.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtTotal.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn1 = new MySqlConnection(connection);
            MySqlCommand cmd;
            MySqlDataReader dr;

            conn1.Open();

            cmd = conn1.CreateCommand();
            cmd.CommandText = "SELECT * FROM iteminventory";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                item = dr["item"].ToString();
            }
            dr.Close();
            conn1.Close();

            conn1.Open();

            if (txtItem.Text == item)
            {
                MessageBox.Show("Item already exist");
                return;
            }

            try
            {
                if(txtItem.Text == "" || txtUnit.Text == "")
                {
                    MessageBox.Show("Please fill up item and unit fields");
                    return;
                }

                cmd = conn1.CreateCommand();
                cmd.CommandText = "INSERT INTO iteminventory(date,prodcode,description,item,class,size,casee,packs,itemclass,packaging,unit,price,total)VALUES('" + date.Value.ToString("yyyy-MM-dd") + "','" + txtProdcode.Text + "','" + txtDescription.Text + "','" + txtItem.Text + "','" + cboClass.Text + "','" + txtSize.Text + "','" + txtCase.Text + "','" + txtPacks.Text + "','" + cboItemClass.Text + "','" + cboPackaging.Text + "','" + txtUnit.Text + "','" + txtPrice.Text + "','" + txtTotal.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("SAVE");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn1.Close();
            views();
            clear();
        }

        public void views()
        {
            MySqlConnection connauj = new MySqlConnection(connection);
            connauj.Open();
            try
            {
                int i = 0;
                dataGridView1.Rows.Clear();
                MySqlCommand Comauj = new MySqlCommand() { Connection = connauj, CommandText = "SELECT * from iteminventory"};
                MySqlDataReader readerauj = Comauj.ExecuteReader();
                while (readerauj.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, readerauj["prodcode"].ToString(), readerauj["description"].ToString(), readerauj["item"].ToString(), readerauj["class"].ToString(), readerauj["size"].ToString(), readerauj["casee"].ToString(), readerauj["packs"].ToString(), readerauj["itemclass"].ToString(), readerauj["packaging"].ToString(), readerauj["unit"].ToString(), readerauj["price"].ToString(), readerauj["total"].ToString(), int.Parse(readerauj["quantity"].ToString()), readerauj["ID"].ToString());
                    ID = readerauj["ID"].ToString();
                }

                connauj.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtItem.Text == "" || txtUnit.Text == "")
            {
                MessageBox.Show("Please fill up all fields");
                return;
            }

            try
            {
                MySqlConnection conzx = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand("update iteminventory set prodcode=@prodcode,description=@description,item=@item,class=@class,size=@size,casee=@casee,packs=@packs,itemclass=@itemclass,packaging=@packaging,unit=@unit,price=@price,total=@total where ID=@ID", conzx);
                conzx.Open();
                cmd.Parameters.AddWithValue("@prodcode", txtProdcode.Text);
                cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@item", txtItem.Text);
                cmd.Parameters.AddWithValue("@class", cboClass.Text);
                cmd.Parameters.AddWithValue("@size", txtSize.Text);
                cmd.Parameters.AddWithValue("@casee", txtCase.Text);
                cmd.Parameters.AddWithValue("@packs", txtPacks.Text);
                cmd.Parameters.AddWithValue("@itemclass", cboClass.Text);
                cmd.Parameters.AddWithValue("@packaging", cboPackaging.Text);
                cmd.Parameters.AddWithValue("@unit", txtUnit.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@total", txtTotal.Text);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conzx.Close();
                views();
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtItem.Text == "" || txtUnit.Text == "")
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
                cmd.CommandText = "DELETE FROM iteminventory where ID='" + txtID.Text + "'";
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

        private void btnCashRpt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("working pa");

        }
    }
}
