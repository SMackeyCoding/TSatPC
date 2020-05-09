using Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.ContractModels
{
    public class ContractCreateModel
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
    }
}
