using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Data.Entities
{
    public class Contract
    {
        [Key]
        public int ContractId { get; set; }
        public string ContractDescription { get; set; }
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
        public int ContractPrice { get; set; }
        public ContractStatus ContractStatus { get; set;  } = ContractStatus.InProgress;
    }
}
