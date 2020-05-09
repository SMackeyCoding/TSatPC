using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Models.ShipModels
{
    public class ShipCreateModel
{
    public class ShipCreateModel
    {
        [Required]
        public string ShipName { get; set; }
        [Required]
        public string ShipClass { get; set; }
        [Required]
        public string ShipModel { get; set; }
        [Required]
        public string ShipManufacturer { get; set; }
        [Required]
        public bool ShipHyperdrive { get; set; }
        public int ShipLength { get; set; }
        public int ShipMaxSpeed { get; set; }
        [Required]
        public int ShipPrice { get; set; }
    }
}