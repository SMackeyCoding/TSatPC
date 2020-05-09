using Contracts;
using Data;
using Data.Entities;
using Models.ShipModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Services
{
    public class ShipService : IShipService
    {
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();

        public void CreateShip(ShipCreateModel shipToCreate)
        {
            var entity = new Ship()
            {
                Name = shipToCreate.Name,
                Class = shipToCreate.Class,
                Model = shipToCreate.Model,
                Manufacturer = shipToCreate.Manufacturer,
                Hyperdrive = shipToCreate.Hyperdrive,
                Length = shipToCreate.Length,
                MaxSpeed = shipToCreate.MaxSpeed,
                Price = shipToCreate.Price
            };

            _ctx.Ships.Add(entity);
            _ctx.SaveChanges();
        }

        public void DeleteShip(int shipId)
        {
            var entity = _ctx.Ships.Single(e => e.ShipId == shipId);
            _ctx.Ships.Remove(entity);
            _ctx.SaveChanges();
        }

        public ShipDetailModel GetShipDetailById(int shipId)
        {
            var i = _ctx.Ships.Single(e => e.ShipId == shipId);
            var entity = new ShipDetailModel()
            {
                ShipId = i.ShipId,
                Name = i.Name,
                Class = i.Class,
                Model = i.Model,
                Manufacturer = i.Manufacturer,
                Hyperdrive = i.Hyperdrive,
                Length = i.Length,
                MaxSpeed = i.MaxSpeed,
                Price = i.Price
            };
            return entity;
        }

        public IEnumerable<ShipListModel> GetShips()
        {
            var returnList = _ctx.Ships.Select(e => new ShipListModel()
            {
                ShipId = e.ShipId,
                Name = e.Name,
                Class = e.Class,
                Price = e.Price
            }).ToList();
            return returnList;
        }

        public void UpdateShip(int shipId, ShipUpdateModel shipToUpdate)
        {
            var entity = _ctx.Ships.Single(e => e.ShipId == shipId);
            if (entity != null)
            {
                if (shipToUpdate.UpdatedName != null)
                    entity.Name = shipToUpdate.UpdatedName;
                if (shipToUpdate.UpdatedClass != null)
                    entity.Class = (ShipClass)shipToUpdate.UpdatedClass;
                if (shipToUpdate.UpdatedModel != null)
                    entity.Model = shipToUpdate.UpdatedModel;
                if (shipToUpdate.UpdatedManufacturer != null)
                    entity.Manufacturer = shipToUpdate.UpdatedManufacturer;
                if (shipToUpdate.UpdatedHyperdrive != null)
                    entity.Hyperdrive = (bool)shipToUpdate.UpdatedHyperdrive;
                if (shipToUpdate.UpdatedLength != null)
                    entity.Length = (int)shipToUpdate.UpdatedLength;
                if (shipToUpdate.UpdatedMaxSpeed != null)
                    entity.MaxSpeed = (int)shipToUpdate.UpdatedMaxSpeed;
                if (shipToUpdate.UpdatedPrice != null)
                    entity.Price = (int)shipToUpdate.UpdatedPrice;
                _ctx.SaveChanges();
            }
        }
    }
}

