using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sports_Facility
{
    class ControlMembers
    {
        string value;
        public string addmembers(bool r)
        {
            if (r == true)
            {
                value = "male";
                return value;
            }
            else
                value = "female";
            return value;
        }
    }
}
