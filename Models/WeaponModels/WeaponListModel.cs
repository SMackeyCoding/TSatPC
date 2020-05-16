using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Models.WeaponFolder
{
    public class WeaponListModel
    {
        public int WeaponId { get; set; }
        public string Name { get; set; }
        public WeaponType Type { get; set; }
        public string Damage { get; set; }
        public int Price { get; set; }
    }
}
