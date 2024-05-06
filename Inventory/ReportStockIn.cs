using Microsoft.Reporting.WinForms;
using System;
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
    public partial class ReportStockIn : Form
    {
        
        public ReportStockIn()
        {
            InitializeComponent();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomPercent = 100;
            reportViewer1.ZoomMode = ZoomMode.Percent;
        }

        private void ReportStockIn_Load(object sender, EventArgs e)
        {
            LoadItem();
        }

        private void LoadItem()
        {
            StockInForm frm = new StockInForm();

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Itemstockin", mysql.DataSet($"SELECT * from itemstockin WHERE date BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'", "itemstockin").Tables[0]));
            reportViewer1.LocalReport.ReportPath = $"{Application.StartupPath}/Itemstockin.rdlc";

            ReportParameter pDate = new ReportParameter("pDate", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            this.reportViewer1.LocalReport.SetParameters(pDate);

            ReportParameter pDate2 = new ReportParameter("pDate2", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            this.reportViewer1.LocalReport.SetParameters(pDate2);

            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

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
