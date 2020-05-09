using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Models.ShipModels
{
    public class ShipListModel
    {
        public int ShipId { get; set; }
        public string Name { get; set; }
        public ShipClass Class { get; set; }
        public bool Hyperdrive { get; set; }
        public int Price { get; set; }
    }
}
