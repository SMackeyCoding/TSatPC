using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ContractModels
{
    public class ContractListItem
    {
        [Key]
        public int ContractId { get; set; }
        public string ContractDescription { get; set; }
        public int Price { get; set; }
    }
}
