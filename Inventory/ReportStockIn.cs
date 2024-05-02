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
            StockInForm frm = new StockInForm();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Itemstockin", mysql.DataSet($"SELECT * from itemstockin WHERE date LIKE '" + frm.date.Value.ToString("yyyy-MM-dd") + "%'", "itemstockin").Tables[0]));
            reportViewer1.LocalReport.ReportPath = $"{Application.StartupPath}/Itemstockin.rdlc";

            ReportParameter pDate = new ReportParameter("pDate", frm.date.Value.ToString("dd/MM/yyyy"));
            this.reportViewer1.LocalReport.SetParameters(pDate);

            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
