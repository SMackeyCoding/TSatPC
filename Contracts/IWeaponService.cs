using Models.WeaponFolder;
using Models.WeaponModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Contracts
{
    public interface IWeaponService
    {
        void CreateWeapon(WeaponCreateModel weaponToCreate);
        IEnumerable<WeaponListModel> GetAllWeapons();
        IEnumerable<WeaponGetByType> GetWeaponByType(WeaponType type);
        WeaponDetailModel GetWeaponDetailById(int weaponId);
        void UpdateWeaponById(int weaponId, WeaponUpdateModel weaponToUpdate);
        void DeleteWeaponById(int weaponId);
    }
}
