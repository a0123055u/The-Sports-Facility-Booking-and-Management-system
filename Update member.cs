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
    public partial class Update_member : Form
    {
        modelEntities2 context = new modelEntities2();
        public Update_member()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Update_member_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            context.SaveChanges();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            member m = new member();
           Int32 a = Convert.ToInt32(textBox1.Text);
            var q = (from x in context.members
                    where x.memberid==(a)
                    select x);
            
            dataGridView1.DataSource = q;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
