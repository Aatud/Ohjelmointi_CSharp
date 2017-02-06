using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike1 = new Bike();
            bike1.Name = "Helkama";
            bike1.Model = "Offroad";
            bike1.ModelYear = 2100;
            bike1.GearWheels = true;
            bike1.GearName = "Shimano";
            Console.WriteLine(bike1.ToString());

            Bike bike2 = new Bike();
            bike2.Name = "Jopo";
            bike2.Model = "Street";
            bike2.ModelYear = 2000;
            bike2.GearWheels = false;
            bike2.GearName = "";
            Console.WriteLine(bike2.ToString());

            Boat boat1 = new Boat();
            boat1.Name = "Yamaha";
            boat1.Model = "v100";
            boat1.ModelYear = 1990;
            boat1.BoatType = "Motorboat";
            boat1.SeatCount = 6;
            Console.WriteLine(boat1.ToString());

            Boat boat2 = new Boat();
            boat2.Name = "Intian";
            boat2.Model = "K10";
            boat2.ModelYear = 1880;
            boat2.BoatType = "Kayak";
            boat2.SeatCount = 2;
            Console.WriteLine(boat1.ToString());
        }
    }
}
