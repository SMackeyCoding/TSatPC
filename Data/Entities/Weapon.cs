using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Weapon
    {
        [Key]
        public int WeaponId { get; set; }
        [Required]
        public string WeaponName { get; set; }
        [Required]
        public string WeaponType { get; set; }
        [Required]
        public string WeaponRange { get; set; }
        [Required]
        public string WeaponColor { get; set; }
        public string BladeOrEnergyColor { get; set; }
        public string WeaponDamage { get; set; }
        public int Price { get; set; }
    }
}
