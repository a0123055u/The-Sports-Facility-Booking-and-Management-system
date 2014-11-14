using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sports_Facility
{
    public partial class AddSportFacility : Form

    {
        modelEntities2 context = new modelEntities2();
        
        
        public AddSportFacility()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (modelEntities2 context = new modelEntities2())
            {
                string sportname = textBox1.Text;
                int number = Convert.ToInt16(textBox2.Text);
                string remarks = textBox3.Text;
                ControlFacilty cf = new ControlFacilty();
                
                  
                //Implemented using Controlfacility Class
                //sportfacility sf = new sportfacility();
                //sf.equipmentname = sportname;
                //sf.facilityavailable = (Int16)number;
                //sf.remarks = remarks;
                //context.AddTosportfacilities(sf);
                //context.SaveChanges();
                dataGridView1.DataSource = cf.addsportfacility(sportname, number, remarks);
                
            }
            // First brushed up the coading

            //string conS = "data source=(local);initial catalog=model;integrated security=SSPI";
            //SqlConnection cn = new SqlConnection(conS);

            //SqlCommand cm = new SqlCommand();
            //string cmtext = "Insert into sportfacility (equipmentname,facilityavailable,remarks) Values(@SF,@NA,@RM)";
            //cm.CommandText = cmtext;
            //cm.Connection = cn;

            //SqlParameter pSF = new SqlParameter("@SF", SqlDbType.NVarChar, 20);
            //SqlParameter pNA = new SqlParameter("@NA", SqlDbType.SmallInt, 2);
            //SqlParameter pRM = new SqlParameter("@RM", SqlDbType.NVarChar, 20);
            //cm.Parameters.Add(pSF);
            //cm.Parameters.Add(pNA);
            //cm.Parameters.Add(pRM);


            //cn.Open();
            //pSF.Value = textBox1.Text;
            //pNA.Value = Convert.ToString(textBox2.Text);
            //pRM.Value = textBox3.Text;


            //cm.ExecuteNonQuery();
            //cn.Close();
                
        }
          
        private void AddSportFacility_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.sportfacilities.ToList();
        }
    }
}
