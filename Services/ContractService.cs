using Contracts;
using Data;
using Data.Entities;
using Models.ContractModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Services
{
    public class ContractService : IContractService
    {
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();

        public void CreateContract(ContractCreateModel contractToCreate)
        {
            int weaponPrice;
            int shipPrice;

            var entity = new Contract()
            {
                ContractDescription = contractToCreate.ContractDescription,
                CharacterId = contractToCreate.CharacterId,
                PlanetId = contractToCreate.PlanetId,
            };
            Character character = _ctx.Characters.Single(e => e.CharacterId == contractToCreate.CharacterId);
            if (contractToCreate.ShipId != null)
            {
                entity.ShipId = (int)contractToCreate.ShipId;
                shipPrice = _ctx.Ships.Find(contractToCreate.ShipId).ShipPrice;
            }
            else 
            {
                entity.ShipId = (int)character.DefaultShipId;
                shipPrice = _ctx.Ships.Find(character.DefaultShipId).ShipPrice;
            }
            if (contractToCreate.WeaponId != null)
            {
                entity.WeaponId = (int)contractToCreate.WeaponId;
                weaponPrice = _ctx.Weapons.Find(contractToCreate.WeaponId).Price;
            }
            else
            { 
                entity.WeaponId = (int)character.DefaultWeaponId;
                weaponPrice = _ctx.Weapons.Find(character.DefaultWeaponId).Price;
            }
            var characterPrice = _ctx.Characters.Find(contractToCreate.CharacterId).Price;
            var planetPrice = _ctx.Planets.Find(contractToCreate.PlanetId).Price;
            entity.ContractPrice = characterPrice + planetPrice + shipPrice + weaponPrice;
            _ctx.Contracts.Add(entity);
            _ctx.SaveChanges();
        }

        public void DeleteContractById(int contractId)
        {
            var entity = _ctx.Contracts.Single(e => e.ContractId == contractId);
            _ctx.Contracts.Remove(entity);
            _ctx.SaveChanges();
        }

        public ContractDetailModel GetContractDetailById(int contractId)
        {
            var i = _ctx.Contracts.Single(e => e.ContractId == contractId);
            var entity = new ContractDetailModel()
            {
                ContractId = i.ContractId,
                ContractDescription = i.ContractDescription,
                Character = $"{i.Character.FirstName} {i.Character.LastName}",
                Planet = i.Planet.PlanetName,
                Ship = i.Ship.ShipName,
                Weapon = i.Weapon.Name,
                ContractPrice = i.ContractPrice,
                ContractStatus = i.ContractStatus.ToString()
            };
            return entity;
        }

        public IEnumerable<ContractListItem> GetAllContracts()
        {
            var returnList = _ctx.Contracts.Select(e => new ContractListItem()
            {
                ContractId = e.ContractId,
                ContractDescription = e.ContractDescription,
                ContractPrice = e.ContractPrice,
                ContractStatus = e.ContractStatus.ToString()
            }).ToList();
            return returnList;
        }

        public IEnumerable<ContractCharacterPlanetHistoryModel> GetCharacterPlanetHistory(int characterId)
        {
            var characterHistory = _ctx.Contracts.Where(e => e.CharacterId == characterId);
            var returnList = characterHistory.Select(e => new ContractCharacterPlanetHistoryModel()
            {
                Planet = e.Planet.PlanetName
            }).ToList();
            return returnList;
        }

        public IEnumerable<ContractShipPlanetHistoryModel> GetShipPlanetHistory(int shipId)
        {
            var shipHistory = _ctx.Contracts.Where(e => e.ShipId == shipId);
            var returnList = shipHistory.Select(e => new ContractShipPlanetHistoryModel()
            {
                Planet = e.Planet.PlanetName
            }).ToList();
            return returnList;
        }

        public void UpdateContractById(int contractId, ContractUpdateModel contractToUpdate)
        {
            var entity = _ctx.Contracts.Single(e => e.ContractId == contractId);
            if (entity != null)
            {
                if (contractToUpdate.ContractDescription != null)
                    entity.ContractDescription = contractToUpdate.ContractDescription;
                if (contractToUpdate.CharacterId != null)
                    entity.CharacterId = (int)contractToUpdate.CharacterId;
                if (contractToUpdate.PlanetId != null)
                    entity.PlanetId = (int)contractToUpdate.PlanetId;
                if (contractToUpdate.ShipId != null)
                    entity.ShipId = (int)contractToUpdate.ShipId;
                if (contractToUpdate.WeaponId != null)
                    entity.ShipId = (int)contractToUpdate.WeaponId;
                if (contractToUpdate.ContractStatus != null)
                    entity.ContractStatus = (ContractStatus)contractToUpdate.ContractStatus;
                entity.ContractPrice = entity.Character.Price + entity.Planet.Price + entity.Ship.ShipPrice + entity.Weapon.Price;
                _ctx.SaveChanges();
            }
        }
        public IEnumerable<ContractListItem> GetContractsByCharacterId(int characterId)
        {
            var returnList = _ctx.Contracts.Where(i => i.CharacterId == characterId).Select(e => new ContractListItem()
            {
                ContractId = e.ContractId,
                ContractDescription = e.ContractDescription,
                ContractPrice = e.ContractPrice,
                ContractStatus = e.ContractStatus.ToString()
            }).ToList();
            return returnList;
        }
        public SuccessRateModel GetSuccessRateByCharacterId(int characterId)
        {
            SuccessRateModel entity = new SuccessRateModel();
            List<ContractListItem> listOfContracts = (List<ContractListItem>)GetContractsByCharacterId(characterId);
            double completedContracts = 0;
            double failedContracts = 0;
            for(int i = 0; i < listOfContracts.Count(); i++)
            {
                var nextContract = listOfContracts[i];
                if (nextContract.ContractStatus == ContractStatus.Completed.ToString())
                    completedContracts++;
                else if (nextContract.ContractStatus == ContractStatus.Failed.ToString())
                    failedContracts++;
            }
            double finalizedContracts = completedContracts + failedContracts;
            int successRate = Convert.ToInt32((completedContracts / finalizedContracts) * 100);
            entity.SuccessRate = $"{successRate}%";
            return entity;
        }
    }
}
