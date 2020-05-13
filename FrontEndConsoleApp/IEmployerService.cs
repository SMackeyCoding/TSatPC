using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndConsoleApp
{
    public interface IEmployerService
    {
        bool CreateContract();
        void ViewContractsByStatus(string contractStatus);
        void ViewBountyHunters();
        void ViewShips();
        void ViewWeapons();
    }
}
