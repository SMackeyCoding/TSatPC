using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CharacterModels
{
   public class CharacterCreateModel
    {
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }
        [Required]

        public string Species { get; set; }
        [Required]

        public int Price { get; set; }
        public string Affiliation { get; set; }
        public int? DefaultWeaponId { get; set; }
        public int? DefaultShipId { get; set; }
    }
}
