using Contracts;
using Data;
using Data.Entities;
using Models.ContractModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ContractService : IContractService
    {
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();

        public void CreateContract(ContractCreateModel contractToCreate)
        {
            var entity = new Contract()
            {
                ContractDescription = contractToCreate.ContractDescription,
                CharacterId = contractToCreate.CharacterId,
                PlanetId = contractToCreate.PlanetId,
                ShipId = contractToCreate.ShipId,
                WeaponId = contractToCreate.WeaponId,
                ContractPrice = contractToCreate.ContractPrice,
            };
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
                CharacterId = i.CharacterId,
                PlanetId = i.PlanetId,
                ShipId = i.ShipId,
                WeaponId = i.WeaponId,
                ContractPrice = i.ContractPrice,
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
            }).ToList();
            return returnList;
        }

        public void UpdateContractById(int contractId, ContractUpdateModel contractToUpdate)
        {
            var entity = _ctx.Contracts.Single(e => e.ContractId == contractToUpdate.ContractId);
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
                _ctx.SaveChanges();
            }
        }

    }
}
