using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Models.ShipModels
{
    public class ShipUpdateModel
    {
        public int ShipId { get; set; }
        public string UpdatedName { get; set; }
        public ShipClass? UpdatedClass { get; set; }
        public string UpdatedModel { get; set; }
        public string UpdatedManufacturer { get; set; }
        public bool? UpdatedHyperdrive { get; set; }
        public int? UpdatedLength { get; set; }
        public int? UpdatedMaxSpeed { get; set; }
        public int? UpdatedPrice { get; set; }
    }
}
