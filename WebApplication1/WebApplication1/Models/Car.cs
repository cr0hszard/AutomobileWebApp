using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{   //Here we give the car class properties
    public class Car
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public int ProductionYear { get; set; }
        public int FuelCapacity { get; set; } // in liters
        public int FuelCompsumption { get; set; }//in liters/100Km
    }
}