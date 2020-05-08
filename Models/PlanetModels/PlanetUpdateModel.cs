using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.PlanetModels
{
    public class PlanetUpdateModel
    {
        public string UpdatedPlanetName { get; set; }
        public string UpdatedPlanetDescription { get; set; }
        public string UpdatedPlanetClimate { get; set; }
        public int? UpdatedHoursPerDay { get; set; }
        public int? UpdatedDaysPerYear { get; set; }
        public int? UpdatedNumberOfSuns { get; set; }
        public int? UpdatedNumberOfMoons { get; set; }
        public int? UpdatedPrice { get; set; }
    }
}
