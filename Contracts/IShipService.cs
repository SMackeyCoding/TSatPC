using Models.ShipModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IShipService
    {
        void CreateShip(ShipCreateModel shipToCreate);
        IEnumerable<ShipListModel> GetShips();
        ShipDetailModel GetShipDetailById(int shipId);
        void UpdateShip(ShipUpdateModel shipToUpdate);
        void DeleteShip(ShipDeleteModel shipToDelete);
    }
}
