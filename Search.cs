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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modelEntities2 context = new modelEntities2();
            int fid = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            var blist = from b in context.bookingdetails
                        join m in context.members on b.memberid equals m.memberid into mb
                        join s in context.sportfacilities on b.equipmentid equals s.equipmentid into sb
                        from m in mb.DefaultIfEmpty()
                        from s in sb.DefaultIfEmpty()
                        where b.equipmentid == (fid)
                        select new { b.bookingid, b.dateofbooking, m.membername, s.equipmentname, b.C8_9_am, b.C9_10_am, b.C10_11_am, b.C11_12_noon, b.C2_3_pm, b.C3_4_pm, b.C_4_5_pm, b.C5_6_pm, b.C6_7_pm, b.C7_8_pm };
            dataGridView1.DataSource = blist.ToList();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            modelEntities2 context = new modelEntities2();
            var eq = (from x in context.sportfacilities
                      orderby x.equipmentid
                      select (x.equipmentid));

            comboBox1.DataSource = eq.ToList();
            var ee = (from x in context.members
                      orderby x.memberid
                      select (x.memberid));
            comboBox2.DataSource = ee.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modelEntities2 context = new modelEntities2();
            int fid = Convert.ToInt32(comboBox2.SelectedValue.ToString());
            var blist = from b in context.bookingdetails
                        join m in context.members on b.memberid equals m.memberid into mb
                        join s in context.sportfacilities on b.equipmentid equals s.equipmentid into sb
                        from m in mb.DefaultIfEmpty()
                        from s in sb.DefaultIfEmpty()
                        where b.equipmentid == (fid)
                        select new { b.bookingid, b.dateofbooking, m.membername, s.equipmentname, b.C8_9_am, b.C9_10_am, b.C10_11_am, b.C11_12_noon, b.C2_3_pm, b.C3_4_pm, b.C_4_5_pm, b.C5_6_pm, b.C6_7_pm, b.C7_8_pm };
            dataGridView1.DataSource = blist.ToList();

        }
    }
}
