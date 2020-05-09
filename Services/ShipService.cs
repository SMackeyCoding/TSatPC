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
                ShipName = shipToCreate.ShipName,
                ShipClass = shipToCreate.ShipClass,
                ShipModel = shipToCreate.ShipModel,
                ShipManufacturer = shipToCreate.ShipManufacturer,
                ShipHyperdrive = shipToCreate.ShipHyperdrive,
                ShipLength = shipToCreate.ShipLength,
                ShipMaxSpeed = shipToCreate.ShipMaxSpeed,
                ShipPrice = shipToCreate.ShipPrice
            };

            _ctx.Ships.Add(entity);
            _ctx.SaveChanges();
        }

        public void DeleteShipById(int shipId)
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
                ShipName = i.ShipName,
                ShipClass = i.ShipClass,
                ShipModel = i.ShipModel,
                ShipManufacturer = i.ShipManufacturer,
                ShipHyperdrive = i.ShipHyperdrive,
                ShipLength = i.ShipLength,
                ShipMaxSpeed = i.ShipMaxSpeed,
                ShipPrice = i.ShipPrice
            };
            return entity;
        }

        public IEnumerable<ShipListModel> GetAllShips()
        {
            var returnList = _ctx.Ships.Select(e => new ShipListModel()
            {
                ShipId = e.ShipId,
                ShipName = e.ShipName,
                ShipClass = e.ShipClass,
                ShipPrice = e.ShipPrice
            }).ToList();
            return returnList;
        }

        public void UpdateShipById(int shipId, ShipUpdateModel shipToUpdate)
        {
            var entity = _ctx.Ships.Single(e => e.ShipId == shipId);
            if (entity != null)
                if (shipToUpdate.UpdatedShipName != null)
                    entity.ShipName = shipToUpdate.UpdatedShipName;
                if (shipToUpdate.UpdatedShipClass != null)
                    entity.ShipClass = shipToUpdate.UpdatedShipClass;
                if (shipToUpdate.UpdatedShipModel != null)
                    entity.ShipModel = shipToUpdate.UpdatedShipModel;
                if (shipToUpdate.UpdatedShipManufacturer != null)
                    entity.ShipManufacturer = shipToUpdate.UpdatedShipManufacturer;
                if (shipToUpdate.UpdatedShipHyperdrive != null)
                entity.ShipHyperdrive = (bool)shipToUpdate.UpdatedShipHyperdrive;
                if (shipToUpdate.UpdatedShipLength != null)
                    entity.ShipLength = (int)shipToUpdate.UpdatedShipLength;
                if (shipToUpdate.UpdatedShipMaxSpeed != null)
                    entity.ShipMaxSpeed = (int)shipToUpdate.UpdatedShipMaxSpeed;
                if (shipToUpdate.UpdatedShipPrice != null)
                    entity.ShipPrice = (int)shipToUpdate.UpdatedShipPrice;
                _ctx.SaveChanges();
            }
        }
    }


