using AiroHelper;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AiroHelper
{
    internal class AirMapRepos
    {
        private readonly DataBase _db;

        public AirMapRepos() : this(new DataBase()) 
        { 

        }

        public AirMapRepos(DataBase db)
        {
            this._db = db;
        }

        public List<AirMap> GetAir()
        {
            using (var db = _db.GetConnection())
            {
                var Air = db.Query<AirMap>("SELECT Id_Airoport, Airoport_Name, Airoport_Code, Airoport_City, Airoport_Аddress, Airoport_Location_x, Airoport_Location_y, Airoport_Description, Airoport_Company, Airoport_Map_Image, Airoport_Description_Max FROM Airoports").ToList();
                return Air;
            }
        }
    }
}
