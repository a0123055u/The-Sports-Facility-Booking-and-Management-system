using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Sports_Facility
{
    public partial class Booking_Facility : Form
    {
       
        public Booking_Facility()
        {
            InitializeComponent();
            modelEntities2 context = new modelEntities2();
            var eq = (from x in context.sportfacilities
                      orderby x.equipmentid
                      select (x.equipmentid));

            comboBox1.DataSource = eq.ToList();
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modelEntities2 context = new modelEntities2();
            DateTime bookingDate = BookingDateDTP.Value.Date;
            int fid = Convert.ToInt32(comboBox1.SelectedValue.ToString());

            var blist = from b in context.bookingdetails
                        join m in context.members on b.memberid equals m.memberid into mb
                        join s in context.sportfacilities on b.equipmentid equals s.equipmentid into sb
                        from m in mb.DefaultIfEmpty()
                        from s in sb.DefaultIfEmpty()
                        where b.equipmentid == (fid) && b.dateofbooking == bookingDate
                        select new { b.bookingid, b.dateofbooking, m.membername, s.equipmentname, b.C8_9_am, b.C9_10_am, b.C10_11_am, b.C11_12_noon, b.C2_3_pm, b.C3_4_pm, b.C_4_5_pm, b.C5_6_pm, b.C6_7_pm, b.C7_8_pm };
            dataGridView1.DataSource = blist.ToList();

            // get the exact list of facility avilable from sportfacility.
             int r = Convert.ToInt16(comboBox1.SelectedValue);
             var q = (from x in context.sportfacilities
                      where x.equipmentid == (r)
                      select (x.facilityavailable));
             String x1 = Convert.ToString(q.First());
             Int16 temp1 = Convert.ToInt16(x1);
            
             int temp2 = (from x in context.bookingdetails
                          where x.equipmentid == (r) && x.dateofbooking == bookingDate
                      select x.memberid).Count();
             if (temp2 <= temp1)
             {
                 int read = temp1 - temp2;
                 MessageBox.Show("Currently have" + "\t"+read + "\t"+ "facility available");
             }
             else
                 MessageBox.Show("Cannot book all Facility are filled");
       
            
        }


        private void Booking_Facility_Load(object sender, EventArgs e)
        {
         string[] a= new string[]{"8-9am","9-10am","10-11am","11-12noon","2-3pm","3-4pm","4-5pm","5-6pm","6-7pm","7-8pm"};
        
   
             comboBox2.Items.AddRange(a);

             modelEntities2 context = new modelEntities2();

             var mList = from x in context.members
                         orderby x.memberid
                         select x;

             foreach (var x in mList.ToList())
             {
                 MemberCombo.Items.Add(x.memberid);
             }                  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modelEntities2 context = new modelEntities2();
            DateTime bookingDate = BookingDateDTP.Value.Date;

            int r = Convert.ToInt16(comboBox1.SelectedValue);

            var q = (from x in context.sportfacilities
                     where x.equipmentid == (r) 
                     select (x.facilityavailable));

            String x1 = Convert.ToString(q.First());
            Int16 temp1 = Convert.ToInt16(x1);

            int temp2 = (from x in context.bookingdetails
                         where x.equipmentid == (r) && x.dateofbooking == bookingDate
                         select x.memberid).Count();



            if (temp2 <= temp1)
            {
                int read = temp1 - temp2;
                MessageBox.Show("Currently have" + "\t" + read + "\t" + "facility available");


                int memId = Convert.ToInt32(MemberCombo.SelectedItem.ToString());
                bookingdetail bk = new bookingdetail();
                int eqId = Convert.ToInt32(comboBox1.SelectedItem.ToString());

                bk.memberid = memId;
                bk.equipmentid = eqId;
                bk.dateofbooking = bookingDate;

                if ((string)comboBox2.SelectedItem == "8-9am")
                {                            //used to set slot , member id,date of playing(date of booking),sports required to play
                    bk.C8_9_am = 1;
                    bk.C9_10_am = 0; bk.C10_11_am = 0; bk.C11_12_noon = 0; bk.C2_3_pm = 0;
                    bk.C3_4_pm = 0; bk.C_4_5_pm = 0; bk.C5_6_pm = 0; bk.C6_7_pm = 0; bk.C7_8_pm = 0;
                    bk.equipmentid = Convert.ToInt16(comboBox1.SelectedItem);
                }
                else if ((string)comboBox2.SelectedItem == "9-10am")
                {
                    bk.C9_10_am = 1;
                    bk.C8_9_am = 0; bk.C10_11_am = 0; bk.C11_12_noon = 0; bk.C2_3_pm = 0;
                    bk.C3_4_pm = 0; bk.C_4_5_pm = 0; bk.C5_6_pm = 0; bk.C6_7_pm = 0; bk.C7_8_pm = 0;
                    bk.equipmentid = Convert.ToInt16(comboBox1.SelectedItem);
                }
                else if ((string)comboBox2.SelectedItem == "10-11am")
                {
                    bk.C10_11_am = 1;
                    bk.C9_10_am = 0; bk.C8_9_am = 0; bk.C11_12_noon = 0; bk.C2_3_pm = 0;
                    bk.C3_4_pm = 0; bk.C_4_5_pm = 0; bk.C5_6_pm = 0; bk.C6_7_pm = 0; bk.C7_8_pm = 0;
                    bk.equipmentid = Convert.ToInt16(comboBox1.SelectedItem);
                }
                else if ((string)comboBox2.SelectedItem == "11-12noon")
                {
                    bk.C11_12_noon = 1;
                    bk.C9_10_am = 0; bk.C10_11_am = 0; bk.C8_9_am = 0; bk.C2_3_pm = 0;
                    bk.C3_4_pm = 0; bk.C_4_5_pm = 0; bk.C5_6_pm = 0; bk.C6_7_pm = 0; bk.C7_8_pm = 0;
                    bk.equipmentid = Convert.ToInt16(comboBox1.SelectedItem);
                }
                else if ((string)comboBox2.SelectedItem == "2-3pm")
                {
                    bk.C2_3_pm = 1;
                    bk.C9_10_am = 0; bk.C10_11_am = 0; bk.C11_12_noon = 0; bk.C8_9_am = 0;
                    bk.C3_4_pm = 0; bk.C_4_5_pm = 0; bk.C5_6_pm = 0; bk.C6_7_pm = 0; bk.C7_8_pm = 0;
                    bk.equipmentid = Convert.ToInt16(comboBox1.SelectedItem);
                }
                else if ((string)comboBox2.SelectedItem == "3-4pm")
                {
                    bk.C3_4_pm = 1;
                    bk.C9_10_am = 0; bk.C10_11_am = 0; bk.C11_12_noon = 0; bk.C2_3_pm = 0;
                    bk.C8_9_am = 0; bk.C_4_5_pm = 0; bk.C5_6_pm = 0; bk.C6_7_pm = 0; bk.C7_8_pm = 0;
                    bk.equipmentid = Convert.ToInt16(comboBox1.SelectedItem);
                }
                else if ((string)comboBox2.SelectedItem == "4-5pm")
                {
                    bk.C_4_5_pm = 1;
                    bk.C9_10_am = 0; bk.C10_11_am = 0; bk.C11_12_noon = 0; bk.C2_3_pm = 0;
                    bk.C3_4_pm = 0; bk.C8_9_am = 0; bk.C5_6_pm = 0; bk.C6_7_pm = 0; bk.C7_8_pm = 0;
                    bk.equipmentid = Convert.ToInt16(comboBox1.SelectedItem);

                }
                else if ((string)comboBox2.SelectedItem == "5-6pm")
                {
                    bk.C5_6_pm = 1;
                    bk.C9_10_am = 0; bk.C10_11_am = 0; bk.C11_12_noon = 0; bk.C2_3_pm = 0;
                    bk.C3_4_pm = 0; bk.C_4_5_pm = 0; bk.C8_9_am = 0; bk.C6_7_pm = 0; bk.C7_8_pm = 0;
                    bk.equipmentid = Convert.ToInt16(comboBox1.SelectedItem);
                }
                else if ((string)comboBox2.SelectedItem == "6-7pm")
                {
                    bk.C6_7_pm = 1;
                    bk.C9_10_am = 0; bk.C10_11_am = 0; bk.C11_12_noon = 0; bk.C2_3_pm = 0;
                    bk.C3_4_pm = 0; bk.C_4_5_pm = 0; bk.C5_6_pm = 0; bk.C8_9_am = 0; bk.C7_8_pm = 0;
                    bk.equipmentid = Convert.ToInt16(comboBox1.SelectedItem);
                }
                else if (Convert.ToString(comboBox2.SelectedItem) == "7-8pm")
                {
                    bk.C7_8_pm = 1;
                    bk.C9_10_am = 0; bk.C10_11_am = 0; bk.C11_12_noon = 0; bk.C2_3_pm = 0;
                    bk.C3_4_pm = 0; bk.C_4_5_pm = 0; bk.C5_6_pm = 0; bk.C6_7_pm = 0; bk.C8_9_am = 0;
                    bk.equipmentid = Convert.ToInt16(comboBox1.SelectedItem);
                }
                else
                {
                    MessageBox.Show("enter valid member or time slot");
                }
                context.AddTobookingdetails(bk);
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Cannot book all Facility are filled");
            }                                            
        }

        
        private void MemberCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelEntities2 context = new modelEntities2();
            int mid = Convert.ToInt32(MemberCombo.SelectedItem.ToString());
            var query = from x in context.members
                        where x.memberid == mid
                        select x;

            member m = query.First<member>();
            MemNameTxtBox.Text = m.membername;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modelEntities2 context = new modelEntities2();
            int bid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            var query = from x in context.bookingdetails
                        where x.bookingid == bid
                        select x;

            bookingdetail bd = query.First<bookingdetail>();
            context.bookingdetails.DeleteObject(bd);
            context.SaveChanges();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            modelEntities2 context = new modelEntities2();
            DateTime bookingDate = BookingDateDTP.Value.Date;
            int fid = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            var gt = (from x in context.bookingdetails
                      where x.equipmentid == (fid) && x.dateofbooking == bookingDate
                      select x);
            dataGridView1.DataSource = gt.ToList();
        }
    }
}
