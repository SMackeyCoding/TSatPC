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
<<<<<<< HEAD
        public int ShipId { get; set; }
        public string UpdatedName { get; set; }
        public ShipClass? UpdatedClass { get; set; }
        public string UpdatedModel { get; set; }
        public string UpdatedManufacturer { get; set; }
        public bool? UpdatedHyperdrive { get; set; }
        public int? UpdatedLength { get; set; }
        public int? UpdatedMaxSpeed { get; set; }
        public int? UpdatedPrice { get; set; }
=======
        public string UpdatedShipName { get; set; }
        public string UpdatedShipClass { get; set; }
        public string UpdatedShipModel { get; set; }
        public string UpdatedShipManufacturer { get; set; }
        public bool UpdatedShipHyperdrive { get; set; }
        public int? UpdatedShipLength { get; set; }
        public int? UpdatedShipMaxSpeed { get; set; }
        public int? UpdatedShipPrice { get; set; }
>>>>>>> 169c6e55268ed7acecc17c176419f383fcfc7ac5
    }
}