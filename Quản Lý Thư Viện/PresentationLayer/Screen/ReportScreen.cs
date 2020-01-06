using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataTransferObject;
using Microsoft.Reporting.WinForms;

namespace PresentationLayer.Screen
{
    public partial class ReportScreen : Form
    {
        public ReportScreen()
        {
            this.InitializeComponent();
        }

        private void ReportScreen_Load(object sender, EventArgs e)
        {
            this.reportViewer.LocalReport.ReportPath = $@"{Application.StartupPath}\Reports\BaoCaoSachDangMuonTrongThang.rdlc";

            //ReportDataSource reportDataSource = new ReportDataSource("DataSet1", data);

            //DataTable dataTable = new DataTable();

            ////ReportDataSource reportDataSource2 = new ReportDataSource("BookDataSet", await this.bookService.All());

            //this.reportViewer.LocalReport.DataSources.Clear();
            //this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
            //this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer.RefreshReport();
        }
    }
}
