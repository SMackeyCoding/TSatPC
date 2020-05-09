using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Data.Entities
{
    public class Ship
    {
        [Key]
        public int ShipId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public ShipClass Class { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public bool Hyperdrive { get; set; }
        public int Length { get; set; }
        public int MaxSpeed { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
