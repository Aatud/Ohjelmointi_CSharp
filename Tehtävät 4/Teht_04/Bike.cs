using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_04
{
    class Bike : Vehicle
    {
        public bool GearWheels { get; set; }
        public string GearName { get; set; }

        public Bike()
        {

        }

        public Bike(string name, string model, int modelyear, bool gearswheels, string gearname)
            : base(name, model, modelyear)
        {
            GearWheels = gearswheels;
            GearName = gearname;
        }

        public override string ToString()
        {
            return base.ToString() + " Gearwheels: " + GearWheels +" Gearname: " + GearName;
        }
    }
}
