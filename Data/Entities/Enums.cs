using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Enums
    {
        public enum WeaponType
        {
            OneHandedMelee=1,
            TwoHandedMelee,
            Staff,
            Lightsaber,
            BlasterPistol,
            BlasterRifle,
            HeavyRanged
        }

        public enum ShipClass
        {
            Shuttle=1,
            Transport,
            Freighter,
            Yacht,
            Starfighter,
            Bomber,
            Gunship,
        }
    }
}
