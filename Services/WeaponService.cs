﻿using Contracts;
using Data;
using Data.Entities;
using Models.WeaponFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class WeaponService : IWeaponService
    {
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();

        public void CreateWeapon(WeaponCreateModel weaponToCreate)
        {
            var entity = new Weapon()
            {
                Name = weaponToCreate.Name,
                Type = weaponToCreate.Type,
                Range = weaponToCreate.Range,
                WeaponColor = weaponToCreate.WeaponColor,
                BladeOrEnergyColor = weaponToCreate.BladeOrEnergyColor,
                Damage = weaponToCreate.Damage,
                Price = weaponToCreate.Price
            };

            _ctx.Weapons.Add(entity);
            _ctx.SaveChanges();
        }

        public void DeleteWeapon(WeaponDeleteModel weaponToDelete)
        {
            var entity = _ctx.Weapons.Single(e => e.WeaponId == weaponToDelete.WeaponId);
            _ctx.Weapons.Remove(entity);
            _ctx.SaveChanges();
        }

        public WeaponDetailModel GetWeaponDetailById(int weaponId)
        {
            var i = _ctx.Weapons.Single(e => e.WeaponId == weaponId);
            var entity = new WeaponDetailModel()
            {
                WeaponId = i.WeaponId,
                Name = i.Name,
                Type = i.Type,
                Range = i.Range,
                WeaponColor = i.WeaponColor,
                BladeOrEnergyColor = i.BladeOrEnergyColor,
                Damage = i.Damage,
                Price = i.Price
            };
            return entity;
        }

        public IEnumerable<WeaponListModel> GetWeapons()
        {
            var returnList = _ctx.Weapons.Select(e => new WeaponListModel()
            {
                WeaponId = e.WeaponId,
                Name = e.Name,
                Type = e.Type,
                Price = e.Price
            }).ToList();
            return returnList;
        }

        public void UpdateWeapon(WeaponUpdateModel weaponToUpdate)
        {
            var entity = _ctx.Weapons.Single(e => e.WeaponId == weaponToUpdate.WeaponId);
            if (entity != null)
            {
                if (weaponToUpdate.UpdatedName != null)
                    entity.Name = weaponToUpdate.UpdatedName;
                if (weaponToUpdate.UpdatedType != null)
                    entity.Type = weaponToUpdate.UpdatedType;
                if (weaponToUpdate.UpdatedRange != null)
                    entity.Range = weaponToUpdate.UpdatedRange;
                if (weaponToUpdate.UpdatedWeaponColor != null)
                    entity.WeaponColor = weaponToUpdate.UpdatedWeaponColor;
                if (weaponToUpdate.UpdatedBladeOrEnergyColor != null)
                    entity.BladeOrEnergyColor = weaponToUpdate.UpdatedBladeOrEnergyColor;
                if (weaponToUpdate.UpdatedDamage != null)
                    entity.Damage = weaponToUpdate.UpdatedDamage;
                if (weaponToUpdate.UpdatedPrice != null)
                    entity.Price = (int)weaponToUpdate.UpdatedPrice;
            }
        }
    }
}