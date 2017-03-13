using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_04
{
    class kiuas
    {
        private readonly double MaxTemp = 120.00;
        private readonly double MinTemp = 0.00;
        private readonly double MaxHum = 100.0;
        private readonly double MinHum = 0.0;
        private double temperature;
        private double humidity;
        public double Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                
                if (value <= MaxTemp && value >= MinTemp)
                {
                    temperature = value;
                }
                else
                {
                    temperature = MinTemp;
                }
            }
            
        }
        public double Humidity
        {
            get
            {
                return humidity;
            }
            set
            {
                if (value <= MaxHum && value >= MinHum) humidity = value;
                else
                {
                    humidity = MinHum;
                }
            }
        }
    }
}
