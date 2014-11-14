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
    public partial class HomeScreen1 : Form
    {
        public HomeScreen1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Member addmem = new Add_Member();
            addmem.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update_member updMem = new Update_member();
            updMem.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddSportFacility addFact = new AddSportFacility();
            addFact.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Update_Sports_Facility updFact = new Update_Sports_Facility();
            updFact.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Search srcFact = new Search();
            srcFact.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booking_Facility bkFact = new Booking_Facility();
            bkFact.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ReportScreen rs = new ReportScreen();
            rs.ShowDialog();
        }



    }
}
