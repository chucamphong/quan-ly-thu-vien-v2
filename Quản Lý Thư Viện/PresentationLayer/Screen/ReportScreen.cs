using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataTransferObject;
using Microsoft.Reporting.WinForms;

namespace PresentationLayer.Screen
{
    public partial class ReportScreen : Form
    {
        private readonly IBookService bookService = new BookService();
        private readonly ICustomerService customerService = new CustomerService();

        public ReportScreen()
        {
            this.InitializeComponent();
        }

        private void ReportScreen_Load(object sender, EventArgs e)
        {
            this.reportViewer.LocalReport.ReportPath = $@"{Application.StartupPath}\Reports\BaoCaoSachDangMuonTrongThang.rdlc";

            List<Book> books = this.customerService.All()
                .ToList()
                .SelectMany(customer => customer.Books)
                .Where(book => book.Date_Returned is null)
                .Select(book => book.Book)
                .Distinct()
                .ToList();

            ReportDataSource reportDataSource = new ReportDataSource("BookDataSet", books);

            this.reportViewer.LocalReport.DataSources.Clear();

            this.reportViewer.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer.RefreshReport();
        }

        private void DtMonth_ValueChanged(object sender, EventArgs e)
        {
            int month = this.dtMonth.Value.Month;
            int year = this.dtMonth.Value.Year;

            List<Book> books = this.customerService.All()
                .ToList()
                .SelectMany(customer => customer.Books)
                .Where(book => book.From.Month == month &&
                               book.From.Year == year &&
                               book.Date_Returned is null)
                .Select(book => book.Book)
                .Distinct()
                .ToList();

            ReportDataSource reportDataSource = new ReportDataSource("BookDataSet", books);

            List<ReportParameter> parameters = new List<ReportParameter>()
            {
                new ReportParameter("Month", $"Trong Tháng {month}"),
            };

            this.reportViewer.LocalReport.DataSources.Clear();

            this.reportViewer.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer.LocalReport.SetParameters(parameters);

            this.reportViewer.RefreshReport();
        }

        private void DtMonth2_ValueChanged(object sender, EventArgs e)
        {
            int month = this.dtMonth2.Value.Month;
            int year = this.dtMonth2.Value.Year;

            var books = this.customerService.All()
                .ToList()
                .SelectMany(customer => customer.Books)
                .Where(book => book.From.Month == month &&
                               book.From.Year == year)
                .GroupBy(book => new { book.Book_Id, book.Book })
                .Select(book => new { book.Key.Book, Count = book.Count() })
                .OrderByDescending(book => book.Count)
                .Select(book => book.Book)
                .ToList();

            ReportDataSource reportDataSource = new ReportDataSource("BookDataSet", books);

            List<ReportParameter> parameters = new List<ReportParameter>()
            {
                new ReportParameter("Title", $"MƯỢN NHIỀU NHẤT"),
                new ReportParameter("Month", $"TRONG THÁNG {month}"),
            };

            this.reportViewer.LocalReport.DataSources.Clear();

            this.reportViewer.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer.LocalReport.SetParameters(parameters);

            this.reportViewer.RefreshReport();
        }

        private void DtYear_ValueChanged(object sender, EventArgs e)
        {
            int year = this.dtYear.Value.Year;

            var books = this.customerService.All()
                .ToList()
                .SelectMany(customer => customer.Books)
                .Where(book => book.From.Year == year)
                .GroupBy(book => new { book.Book_Id, book.Book })
                .Select(book => new { book.Key.Book, Count = book.Count() })
                .OrderByDescending(book => book.Count)
                .Select(book => book.Book)
                .ToList();

            ReportDataSource reportDataSource = new ReportDataSource("BookDataSet", books);

            List<ReportParameter> parameters = new List<ReportParameter>()
            {
                new ReportParameter("Title", $"MƯỢN NHIỀU NHẤT"),
                new ReportParameter("Month", $"TRONG NĂM {year}"),
            };

            this.reportViewer.LocalReport.DataSources.Clear();

            this.reportViewer.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer.LocalReport.SetParameters(parameters);

            this.reportViewer.RefreshReport();
        }
    }
}
