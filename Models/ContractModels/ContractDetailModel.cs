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
        public string Character { get; set; }
        public string Planet { get; set; }
        public string Ship { get; set; }
        public string Weapon { get; set; }
        public int ContractPrice { get; set; }
        public string ContractStatus { get; set; }
    }
}
