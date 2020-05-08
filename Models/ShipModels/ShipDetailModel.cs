using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ShipModels
{
    public class ShipDetailModel
    {
        public int ShipId { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public bool Hyperdrive { get; set; }
        public int Length { get; set; }
        public int MaxSpeed { get; set; }
        public int Price { get; set; }
    }
}
