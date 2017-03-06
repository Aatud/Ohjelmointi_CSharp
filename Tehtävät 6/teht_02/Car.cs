using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht_02
{
    class Car
    {
        public string Name { get; set; }
        public int Count { get; set; }


        public Car(string name)
        {
            Name = name;
            Count = 0;
        }

        public void Add()
        {
            Count++;
        }
        public void Reset()
        {
            Count = 0;
        }
    }
}
