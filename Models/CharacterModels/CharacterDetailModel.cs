using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CharacterModels
{
    public class CharacterDetailModel
    {
        public int CharacterId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Species { get; set; }
        public int Price { get; set; }
        public string Affiliation { get; set; }
        public string DefaultWeaponName { get; set; }
        public string DefaultShipName { get; set; }
    }
}
