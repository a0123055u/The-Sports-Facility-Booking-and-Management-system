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
    public partial class SportChartReport : Form
    {
        public SportChartReport()
        {
            InitializeComponent();
        }

        private void SportChartReport_Load(object sender, EventArgs e)
        {
            DSSportReport ds = new DSSportReport();
            DSSportReportTableAdapters.sportfacilityTableAdapter ta = new DSSportReportTableAdapters.sportfacilityTableAdapter();

            ta.Fill(ds.sportfacility);

            CRSportChart crpt = new CRSportChart();
            crpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = crpt;
        }
    }
}
