using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Models.ShipModels
{
    public class ShipDetailModel
    {
        public int ShipId { get; set; }
        public string ShipName { get; set; }
        public string ShipClass { get; set; }
        public string ShipModel { get; set; }
        public string ShipManufacturer { get; set; }
        public bool ShipHyperdrive { get; set; }
        public int ShipLength { get; set; }
        public int ShipMaxSpeed { get; set; }
        public int ShipPrice { get; set; }
    }
}
