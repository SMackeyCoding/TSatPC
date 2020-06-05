using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Character
    {
        [Key]
        public int CharacterId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Species { get; set; }
        [Required]
        public int Price { get; set; }
        public string Affiliation { get; set; }
        [ForeignKey("DefaultWeapon")]
        public int? DefaultWeaponId { get; set; }
        public virtual Weapon DefaultWeapon { get; set; }
        [ForeignKey("DefaultShip")]
        public int? DefaultShipId { get; set; }
        public virtual Ship DefaultShip { get; set; }

        //[ForeignKey("Comment")]
        //public virtual Comment Comment { get; set; }
    }
}
