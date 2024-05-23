using System;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class ReportItemInventory : Form
    {
        public ReportItemInventory()
        {
            InitializeComponent();
            LoadItem();
        }

        private void ReportItemInventory_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            LoadItem();
        }

        private void LoadItem()
        {
            StockOutForm frm = new StockOutForm();

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Iteminventory", mysql.DataSet($"SELECT * from iteminventory WHERE date BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'", "itemstockout").Tables[0]));
            reportViewer1.LocalReport.ReportPath = $"{Application.StartupPath}/Iteminventory.rdlc";

            ReportParameter pDate = new ReportParameter("pDate", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            this.reportViewer1.LocalReport.SetParameters(pDate);

            ReportParameter pDate2 = new ReportParameter("pDate2", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            this.reportViewer1.LocalReport.SetParameters(pDate2);

            reportViewer1.RefreshReport();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadItem();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadItem();
        }
    }
}
