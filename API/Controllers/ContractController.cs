using Models.ContractModels;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [Authorize(Roles = "Admin")]
    [RoutePrefix("api/contracts")]
    public class ContractController : ApiController
    {
        private ContractService CreateContractService()
        {
            var contractService = new ContractService();
            return contractService;
        }
        [OverrideAuthorization]
        [Authorize(Roles = "Admin,Client")]
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult CreateContract(ContractCreateModel contractToCreate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateContractService();
            service.CreateContract(contractToCreate);
            return Ok();
        }
        [OverrideAuthorization]
        [Authorize(Roles = "Admin,Client,Hunter")]
        [HttpGet]
        [Route("List")]
        public IHttpActionResult GetContractList()
        {
            var service = CreateContractService();
            var contracts = service.GetAllContracts();
            return Ok(contracts);
        }
        [OverrideAuthorization]
        [Authorize(Roles = "Admin,Client,Hunter")]
        [HttpGet]
        [Route("{ContractId:int}")]
        public IHttpActionResult GetContractDetailById([FromUri] int contractId)
        {
            var service = CreateContractService();
            var contractDetail = service.GetContractDetailById(contractId);
            return Ok(contractDetail);
        }
        [OverrideAuthorization]
        [Authorize(Roles = "Admin,Client")]
        [HttpGet]
        [Route("ByCharacter/{CharacterId:int}")]
        public IHttpActionResult GetCharacterPlanetHistory([FromUri] int characterId)
        {
            var service = CreateContractService();
            var characterHistory = service.GetCharacterPlanetHistory(characterId);
            return Ok(characterHistory);
        }
        [OverrideAuthorization]
        [Authorize(Roles = "Admin,Client")]
        [HttpGet]
        [Route("ByShip/{ShipId:int}")]
        public IHttpActionResult GetShipPlanetHistory([FromUri] int shipId)
        {
            var service = CreateContractService();
            var shipHistory = service.GetShipPlanetHistory(shipId);
            return Ok(shipHistory);
        }
        [OverrideAuthorization]
        [Authorize(Roles = "Admin,Client,Hunter")]
        [HttpPut]
        [Route("{ContractId:int}")]
        public IHttpActionResult UpdateContract([FromUri] int contractId, ContractUpdateModel contractToUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateContractService();
            service.UpdateContractById(contractId, contractToUpdate);
            return Ok();
        }
        [OverrideAuthorization]
        [Authorize(Roles = "Admin,Client")]
        [HttpDelete]
        [Route("{ContractId:int}")]
        public IHttpActionResult DeleteContract([FromUri] int contractId)
        {
            var service = CreateContractService();
            service.DeleteContractById(contractId);
            return Ok();
        }
    }
}