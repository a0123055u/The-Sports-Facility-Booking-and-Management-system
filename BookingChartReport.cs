using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sports_Facility
{
    public partial class BookingChartReport : Form
    {
        public BookingChartReport()
        {
            InitializeComponent();
        }

        private void BookingChartReport_Load(object sender, EventArgs e)
        {
            DSBookingReport ds = new DSBookingReport();
            DSBookingReportTableAdapters.bookingdetailsTableAdapter ta = new DSBookingReportTableAdapters.bookingdetailsTableAdapter();

            ta.Fill(ds.bookingdetails);

            CRBookingChart crpt = new CRBookingChart();
            crpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = crpt;
        }
    }
}
