using Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.ContractModels
{
    public class ContractCreateModel
    {
        public string ContractDescription { get; set; }
        public int CharacterId { get; set; }
        public int PlanetId { get; set; }
        public int? ShipId { get; set; }
        public int? WeaponId { get; set; }
    }
}
