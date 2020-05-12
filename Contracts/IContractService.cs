using Models.ContractModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IContractService
    {
        void CreateContract(ContractCreateModel contractToCreate);
        IEnumerable<ContractListItem> GetAllContracts();
        IEnumerable<ContractCharacterPlanetHistoryModel> GetCharacterPlanetHistory(int characterId);
        IEnumerable<ContractShipPlanetHistoryModel> GetShipPlanetHistory(int shipId);
        ContractDetailModel GetContractDetailById(int contractId);
        void UpdateContractById(int contractId, ContractUpdateModel contractToUpdate);
        void DeleteContractById(int contractId);
        IEnumerable<ContractListItem> GetContractsByCharacterId(int characterId);
        SuccessRateModel GetSuccessRateByCharacterId(int characterId);
    }
}
