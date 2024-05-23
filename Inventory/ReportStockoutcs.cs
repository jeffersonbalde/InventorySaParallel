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
    public partial class ReportStockoutcs : Form
    {
        public ReportStockoutcs()
        {
            InitializeComponent();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomPercent = 100;
            reportViewer1.ZoomMode = ZoomMode.Percent;
        }

        private void ReportStockoutcs_Load(object sender, EventArgs e)
        {
            LoadItem();
        }

        private void LoadItem()
        {
            StockOutForm frm = new StockOutForm();

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Itemstockout", mysql.DataSet($"SELECT * from itemstockout WHERE date BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'", "itemstockout").Tables[0]));
            reportViewer1.LocalReport.ReportPath = $"{Application.StartupPath}/Itemstockout.rdlc";

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
