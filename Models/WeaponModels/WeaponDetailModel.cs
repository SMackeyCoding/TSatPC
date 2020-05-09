using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Models.WeaponFolder
{
    public class WeaponDetailModel
    {
        public int WeaponId { get; set; }
        public string Name { get; set; }
        public WeaponType Type { get; set; }
        public string Range { get; set; }
        public string WeaponColor { get; set; }
        public string BladeOrEnergyColor { get; set; }
        public string Damage { get; set; }
        public int Price { get; set; }
    }
}
