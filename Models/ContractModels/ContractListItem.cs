using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Models.ContractModels
{
    public class ContractListItem
    {
        public int ContractId { get; set; }
        public string ContractDescription { get; set; }
        public int ContractPrice { get; set; }
        public string ContractStatus { get; set; }
    }
}
