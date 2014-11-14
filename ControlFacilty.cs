using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sports_Facility
{
    class ControlFacilty
    {
        public List<sportfacility> addsportfacility( string sportname,int number, string remarks)
        {
            using (modelEntities2 context = new modelEntities2())
            {
                sportfacility sf = new sportfacility();
                sf.equipmentname = sportname;
                sf.facilityavailable = (Int16)number;
                sf.remarks = remarks;
                context.AddTosportfacilities(sf);
                context.SaveChanges();
                return context.sportfacilities.ToList();
            }
        }
      
       
    }
}
