using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ShipController : ApiController
    {
        private ShipService CreateShipService()
        {
            var shipService = new ShipService();
            return shipService;
        }
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult CreateShip(ShipCreateModel shipToCreate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateShipService();
            service.CreateShip(shipToCreate);
            return Ok();
        }
        [HttpGet]
        [Route("List")]
        public IHttpActionResult GetContractList()
        {
            var service = CreateShipService();
            var ships = service.GetShips();
            return Ok(ships);
        }
        [HttpGet]
        [Route("{ShipId:int}")]
        public IHttpActionResult GetShipDetailById([FromUri] int shipId)
        {
            var service = CreateShipService();
            var shipDetail = service.GetShipDetailById(shipId);
            return Ok(shipDetail);
        }
        [HttpPut]
        [Route("{ShipId:int}")]
        public IHttpActionResult UpdateShip([FromUri] int shipId, ShipUpdateModel shipToUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateShipService();
            service.UpdateShip(shipId, shipToUpdate);
            return Ok();
        }
        [HttpDelete]
        [Route("{ShipId:int}")]
        public IHttpActionResult DeleteShip([FromUri] int shipId)
        {
            var service = CreateShipService();
            service.DeleteShip(shipId);
            return Ok();
        }
    }
}
