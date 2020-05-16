using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Models.ContractModels
{
    public class ContractDetailModel
    {
        public int ContractId { get; set; }
        public string ContractDescription { get; set; }
        public int CharacterId { get; set; }
        public int PlanetId { get; set; }
        public int ShipId { get; set; }
        public int WeaponId { get; set; }
        public int ContractPrice { get; set; }
        public ContractStatus ContractStatus { get; set; }
    }
}
