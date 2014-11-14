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
    public partial class Update_Sports_Facility : Form
    {
  
        modelEntities2 context = new modelEntities2();
        private sportfacility sp;
      
        public Update_Sports_Facility()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            // Loads to the txt box
            Int32 a = Convert.ToInt32(textBox1.Text);

            var q = (from x in context.sportfacilities
                     where x.equipmentid == (a)
                     select x);
            sp = q.First<sportfacility>();
            textBox2.Text = sp.equipmentname;
            textBox3.Text = sp.facilityavailable.ToString();
            textBox4.Text = sp.remarks;

        
            
        }

        private void Update_Sports_Facility_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get value from the text box and save changes in db
            sp.equipmentname = textBox2.Text;
            sp.facilityavailable = Convert.ToInt16(textBox3.Text);
            sp.remarks = textBox4.Text;
                       
            context.SaveChanges();  
            
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
