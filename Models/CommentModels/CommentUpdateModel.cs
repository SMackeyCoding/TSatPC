using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CommentModels
{
    public class CommentUpdateModel
    {
        public string UpdatedText { get; set; }
        public DateTime? UpdatedCreatedAtUtc { get; set; }

        [ForeignKey("Character")]
        public int? UpdatedCharacterId { get; set; }
        public virtual Character Character { get; set; }

        [ForeignKey("Planet")]
        public int? UpdatedPlanetId { get; set; }
        public virtual Planet Planet { get; set; }

        [ForeignKey("Ship")]
        public int? UpdatedShipId { get; set; }
        public virtual Ship Ship { get; set; }

        [ForeignKey("Weapon")]
        public int? UpdatedWeaponId { get; set; }
        public virtual Weapon Weapon { get; set; }
    }
}
