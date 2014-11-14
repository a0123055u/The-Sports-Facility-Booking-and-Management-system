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
    public partial class BookingReportForm : Form
    {
        public BookingReportForm()
        {
            InitializeComponent();
        }

        private void BookingReportForm_Load(object sender, EventArgs e)
        {
            DSBookingReport ds = new DSBookingReport();
            DSBookingReportTableAdapters.bookingdetailsTableAdapter ta = new DSBookingReportTableAdapters.bookingdetailsTableAdapter();

            ta.Fill(ds.bookingdetails);

            CRBookingReport crpt = new CRBookingReport();
            crpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = crpt;
        }
    }
}
