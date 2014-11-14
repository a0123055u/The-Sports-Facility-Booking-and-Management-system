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
    public partial class ReportScreen : Form
    {
        public ReportScreen()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BookingReportForm BookReport = new BookingReportForm();
            BookReport.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemberReport MemReport = new MemberReport();
            MemReport.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SportFacilyReport SportReport = new SportFacilyReport();
            SportReport.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BookingChartReport BookChart = new BookingChartReport();
            BookChart.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MemberChartReport MemberChart = new MemberChartReport();
            MemberChart.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SportChartReport SportChart = new SportChartReport();
            SportChart.ShowDialog();
        }
    }
}
