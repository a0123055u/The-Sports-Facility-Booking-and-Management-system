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
    public partial class Add_Member : Form
    {
        string value;
        public Add_Member()
        {
            InitializeComponent();
        }

        private void Add_Member_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlMembers a = new ControlMembers();
          
            using (modelEntities2 am = new modelEntities2())
            {
                string name = textBox2.Text;
                string emailid = textBox5.Text;
                string number = textBox4.Text;
                string adds = textBox6.Text;
                string icno= textBox1.Text;
                bool r = radioButton1.Checked;
                value=a.addmembers(r);
                // Demonstrated via controlmember class (implemented)
                //if (radioButton1.Checked == true)
                //{
                //    value = "male";
                //}
                //else
                //    value = "female";
                member m = new member();
                m.address = adds;
                m.membername = name;
                m.phonenumber = number;
                m.membericno = icno;
                m.Emailid = emailid;
                m.Sex = value;
                am.AddTomembers(m);
                am.SaveChanges();
                MessageBox.Show("Member Created successful");
               

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
