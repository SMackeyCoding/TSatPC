using Models.PlanetModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IPlanetService
    {
        void CreatePlanet(PlanetCreateModel planetToCreate);
        IEnumerable<PlanetListItem> GetAllPlanets();
        PlanetDetailModel GetPlanetDetailById(int planetId);
        void UpdatePlanetById(int planetId, PlanetUpdateModel planetToUpdate);
        void DeletePlanetById(int planetId);
    }
}
