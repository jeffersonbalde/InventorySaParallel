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
    public partial class MainForm : Form
    {

        static string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public MainForm()
        {
            InitializeComponent();
        }   

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            InventoryForm frm = new InventoryForm();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.views();
            frm.BringToFront();
            frm.Show();
        }

        private void DefaultDashboard()
        {
            panel1.Controls.Clear();
            DashboardForm frm = new DashboardForm();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DefaultDashboard();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DashboardForm frm = new DashboardForm();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            StockInForm frm = new StockInForm();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            StockOutForm frm = new StockOutForm();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
