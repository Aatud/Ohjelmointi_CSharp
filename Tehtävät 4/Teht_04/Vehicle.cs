using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_04
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }


        public Vehicle()
        {

        }

        public Vehicle(string name, string model, int modelyear)
        {
            Name = name;
            Model = model;
            ModelYear = modelyear;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Model: " + Model + " Modelyear: " + ModelYear;
        }
    }
}
