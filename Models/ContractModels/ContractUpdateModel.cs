using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ContractModels
{
    public class ContractUpdateModel
    {
        [Key]
        public int ContractId { get; set; }
        public string ContractDescription { get; set; }
        [ForeignKey("Character")]
        public int? CharacterId { get; set; }
        [ForeignKey("Planet")]
        public int? PlanetId { get; set; }
        [ForeignKey("Ship")]
        public int? ShipId { get; set; }
        [ForeignKey("Weapon")]
        public int? WeaponId { get; set; }
        public int? ContractPrice { get; set; }
    }
}
