using Data;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CommentModels
{
    public class CommentCreateModel
    {
        [ForeignKey("ApplicationUser")]
        public string Name { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string Text { get; set; }
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
