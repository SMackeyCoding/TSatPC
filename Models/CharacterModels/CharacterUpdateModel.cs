using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CharacterModels
{
    public class CharacterUpdateModel
    {
        public int CharacterId { get; set; }
        public string UpdatedFirstName { get; set; }
        public string UpdatedLastName { get; set; }
        public string UpdatedSpecies { get; set; }
        public int? UpdatedPrice { get; set; }
        public string UpdatedAffiliation { get; set; }
        public int? UpdatedDefaultWeaponId { get; set; }
        public int? UpdatedDefaultShipId { get; set; }
    }
}
