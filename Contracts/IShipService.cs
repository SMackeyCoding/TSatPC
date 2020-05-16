using Models.ShipModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Contracts
{
    public interface IShipService
    {
        void CreateShip(ShipCreateModel shipToCreate);
        IEnumerable<ShipListModel> GetAllShips();
        IEnumerable<ShipGetByType> GetShipByClass(ShipClass shipClass);
        ShipDetailModel GetShipDetailById(int shipId);
        void UpdateShipById(int shipId, ShipUpdateModel shipToUpdate);
        void DeleteShipById(int shipId);
    }
}
