using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ShipModels
{
    public class ShipListModel
    {
        public int ShipId { get; set; }
        public string ShipName { get; set; }
        public string ShipClass { get; set; }
        public bool ShipHyperdrive { get; set; }
        public int ShipPrice { get; set; }
    }
}
