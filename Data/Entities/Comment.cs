using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        [ForeignKey("ApplicationUser")]
        public Guid UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime CreatedAtUtc { get; set; }

        [ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }

        [ForeignKey("Planet")]
        public int PlanetId { get; set; }
        public virtual Planet Planet { get; set; }

        [ForeignKey("Ship")]
        public int ShipId { get; set; }
        public virtual Ship Ship { get; set; }

        [ForeignKey("Weapon")]
        public int WeaponId { get; set; }
        public virtual Weapon Weapon { get; set; }
    }
}
