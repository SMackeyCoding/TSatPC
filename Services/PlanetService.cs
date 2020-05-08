using Contracts;
using Data;
using Data.Entities;
using Models.PlanetModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PlanetService : IPlanetService
    {
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();
        public void CreatePlanet(PlanetCreateModel planetToCreate)
        {
            var entity = new Planet()
            {
                PlanetName = planetToCreate.PlanetName,
                PlanetDescription = planetToCreate.PlanetDescription,
                PlanetClimate = planetToCreate.PlanetClimate,
                HoursPerDay = planetToCreate.HoursPerDay,
                DaysPerYear = planetToCreate.DaysPerYear,
                NumberOfSuns = planetToCreate.NumberOfSuns,
                NumberOfMoons = planetToCreate.NumberOfMoons,
                Price = planetToCreate.Price
            };
            _ctx.Planets.Add(entity);
            _ctx.SaveChanges();
        }

        public void DeletePlanetById(int planetId)
        {
            var entity = _ctx.Planets.Single(e => e.PlanetId == planetId);
            _ctx.Planets.Remove(entity);
            _ctx.SaveChanges();
        }

        public IEnumerable<PlanetListItem> GetAllPlanets()
        {
            var returnList = _ctx.Planets.Select(e => new PlanetListItem()
            {
                PlanetId = e.PlanetId,
                PlanetName = e.PlanetName,
                PlanetDescription = e.PlanetDescription,
                Price = e.Price
            }).ToList();
            return returnList;
        }

        public PlanetDetailModel GetPlanetDetailById(int planetId)
        {
            var planet = _ctx.Planets.Single(e => e.PlanetId == planetId);
            return new PlanetDetailModel()
            {
                PlanetId = planet.PlanetId,
                PlanetName = planet.PlanetName,
                PlanetDescription = planet.PlanetDescription,
                PlanetClimate = planet.PlanetClimate,
                HoursPerDay = planet.HoursPerDay,
                DaysPerYear = planet.DaysPerYear,
                NumberOfSuns = planet.NumberOfSuns,
                NumberOfMoons = planet.NumberOfMoons,
                Price = planet.Price
            };
        }

        public void UpdatePlanetById(int planetId, PlanetUpdateModel planetToUpdate)
        {
            var entity = _ctx.Planets.Single(e => e.PlanetId == planetId);
            if (entity!= null)
            {
                if (planetToUpdate.UpdatedPlanetName != null)
                    entity.PlanetName = planetToUpdate.UpdatedPlanetName;
                if (planetToUpdate.UpdatedPlanetDescription != null)
                    entity.PlanetDescription = planetToUpdate.UpdatedPlanetDescription;
                if (planetToUpdate.UpdatedPlanetClimate != null)
                    entity.PlanetClimate = planetToUpdate.UpdatedPlanetClimate;
                if (planetToUpdate.UpdatedHoursPerDay != null)
                    entity.HoursPerDay = (int)planetToUpdate.UpdatedHoursPerDay;
                if (planetToUpdate.UpdatedDaysPerYear != null)
                    entity.DaysPerYear = (int)planetToUpdate.UpdatedDaysPerYear;
                if (planetToUpdate.UpdatedNumberOfSuns != null)
                    entity.NumberOfSuns = (int)planetToUpdate.UpdatedNumberOfSuns;
                if (planetToUpdate.UpdatedNumberOfMoons != null)
                    entity.NumberOfMoons = (int)planetToUpdate.UpdatedNumberOfMoons;
                if (planetToUpdate.UpdatedPrice != null)
                    entity.Price = (int)planetToUpdate.UpdatedPrice;
                _ctx.SaveChanges();
            }
        }
    }
}
