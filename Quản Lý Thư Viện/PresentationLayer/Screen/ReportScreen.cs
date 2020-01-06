﻿using System;
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

            List<Book> books = this.customerService.All()
                .ToList()
                .SelectMany(customer => customer.Books)
                .Where(book => book.From.Month == month &&
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
    }
}
