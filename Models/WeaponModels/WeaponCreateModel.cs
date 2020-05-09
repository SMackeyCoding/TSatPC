using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.WeaponFolder
{
    public class WeaponCreateModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Range { get; set; }
        [Required]
        public string WeaponColor { get; set; }
        public string BladeOrEnergyColor { get; set; }
        public string Damage { get; set; }
        public int Price { get; set; }
    }
}
