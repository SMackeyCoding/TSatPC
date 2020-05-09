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
        ContractDetailModel GetContractDetailById(int contractId);
        void UpdateContractById(int contractId, ContractUpdateModel contractToUpdate);
        void DeleteContractById(int contractId);
    }
}
