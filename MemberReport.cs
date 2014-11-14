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
    public partial class MemberReport : Form
    {
        public MemberReport()
        {
            InitializeComponent();
        }

        private void MemberReport_Load(object sender, EventArgs e)
        {
            DSMemberReport ds = new DSMemberReport();
            DSMemberReportTableAdapters.membersTableAdapter ta = new DSMemberReportTableAdapters.membersTableAdapter();

            ta.Fill(ds.members);

            CRMemberReport crpt = new CRMemberReport();
            crpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = crpt;
        }
    }
}
