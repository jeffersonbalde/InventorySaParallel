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

        public InventoryForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItem.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtUnit.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn1 = new MySqlConnection(connection);
            MySqlCommand cmd;
            conn1.Open();
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

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn1.Close();
            views();
        }

        public void views()
        {
            MySqlConnection connauj = new MySqlConnection(connection);
            connauj.Open();
            try
            {
                int i = 0;
                dataGridView1.Rows.Clear();
                MySqlCommand Comauj = new MySqlCommand() { Connection = connauj, CommandText = "SELECT item,unit,quantity from iteminventory"};
                MySqlDataReader readerauj = Comauj.ExecuteReader();
                while (readerauj.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, readerauj["item"].ToString(), readerauj["unit"].ToString(), int.Parse(readerauj["quantity"].ToString()));
                }

                connauj.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MySqlConnection conzx = new MySqlConnection(connection);
            //MySqlCommand cmd = new MySqlCommand("update estimate set htag=@name,qty=@state,item=@item where iop=@id", conzx);
            //conzx.Open();
            //cmd.Parameters.AddWithValue("@id", label3.Text);
            //cmd.Parameters.AddWithValue("@name", pname.Text);
            //cmd.Parameters.AddWithValue("@state", xqty.Text);
            //cmd.Parameters.AddWithValue("@item", xitem.Text);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Record Updated Successfully");
            //conzx.Close();
            //views();
            //pname.Text = "";
            //xitem.Text = "";
            //xqty.Text = "";
            //label3.Text = "000";

        }
    }
}
