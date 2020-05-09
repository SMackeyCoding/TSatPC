using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Models.ShipModels
{
    public class ShipUpdateModel
    public class ShipUpdateModel
    {
        public string UpdatedShipName { get; set; }
        public string UpdatedShipClass { get; set; }
        public string UpdatedShipModel { get; set; }
        public string UpdatedShipManufacturer { get; set; }
        public bool UpdatedShipHyperdrive { get; set; }
        public int? UpdatedShipLength { get; set; }
        public int? UpdatedShipMaxSpeed { get; set; }
        public int? UpdatedShipPrice { get; set; }
    }
}