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
    public partial class SportFacilyReport : Form
    {
        public SportFacilyReport()
        {
            InitializeComponent();
        }

        private void SportFacilyReport_Load(object sender, EventArgs e)
        {
            DSSportReport ds = new DSSportReport();
            DSSportReportTableAdapters.sportfacilityTableAdapter ta = new DSSportReportTableAdapters.sportfacilityTableAdapter();

            ta.Fill(ds.sportfacility);

            CRSportReport crpt = new CRSportReport();
            crpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = crpt;
        }
    }
}
