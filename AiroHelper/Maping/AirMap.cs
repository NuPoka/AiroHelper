using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiroHelper
{
    public class AirMap
    {
        public int Id_Airoport { get; set; }
        public string Airoport_Name { get; set; }
        public string Airoport_Code { get; set; }
        public string Airoport_City { get; set; }
        public string Airoport_Аddress { get; set; }
        public double Airoport_Location_x { get; set; }
        public double Airoport_Location_y { get; set; }
        public string Airoport_Description { get; set; }
        public string Airoport_Company { get; set; }
        public byte[] Airoport_Map_Image { get; set; }
        public string Airoport_Description_Max { get; set; }

    }
}
