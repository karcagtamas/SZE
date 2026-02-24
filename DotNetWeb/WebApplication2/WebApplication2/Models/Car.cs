using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Car
    {
        public long Id { get; set; }
        public string NumberPlate { get; set; }
        public string VIN { get; set; }
        public string EngineNo { get; set; }
        public string Color { get; set; }
        public string PassengerNo { get; set; }
    }
}
