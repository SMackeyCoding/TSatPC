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
        public int DefaultWeaponId { get; set; }
        public int DefaultShipId { get; set; }

        [ForeignKey("Comment")]
        public virtual Comment Comment { get; set; }
    }
}
