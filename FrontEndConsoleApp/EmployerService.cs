using Contracts;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndConsoleApp
{

    public class EmployerService : IEmployerService
    {
        private IContractService _contractService;
        public bool CreateContract()
        {
            _contractService = new ContractService();
            return true;
        }

        public void ViewBountyHunters()
        {
            throw new NotImplementedException();
        }

        public void ViewContractsByStatus(string contractStatus)
        {
            throw new NotImplementedException();
        }

        public void ViewShips()
        {
            throw new NotImplementedException();
        }

        public void ViewWeapons()
        {
            throw new NotImplementedException();
        }
    }
}
