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
    public class ContractController : ApiController
    {
        private ContractService CreateContractService()
        {
            var contractService = new ContractService();
            return contractService;
        }
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
        [HttpGet]
        [Route("List")]
        public IHttpActionResult GetContractList()
        {
            var service = CreateContractService();
            var contracts = service.GetAllContracts();
            return Ok(contracts);
        }
        [HttpGet]
        [Route("{ContractId:int}")]
        public IHttpActionResult GetContractDetailById([FromUri] int contractId)
        {
            var service = CreateContractService();
            var contractDetail = service.GetContractDetailById(contractId);
            return Ok(contractDetail);
        }
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