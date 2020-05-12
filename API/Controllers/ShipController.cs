using Models.ShipModels;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static Data.Entities.Enums;

namespace API.Controllers
{
    [RoutePrefix("api/Ships")]
    public class ShipController : ApiController
    {
        private ShipService CreateShipService()
        {
            var shipService = new ShipService();
            return shipService;
        }
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult CreateShip([FromBody] ShipCreateModel shipToCreate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateShipService();
            service.CreateShip(shipToCreate);
            return Ok();
        }
        [HttpGet]
        [Route("List")]
        public IHttpActionResult GetShipList()
        {
            var service = CreateShipService();
            var ships = service.GetAllShips();
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
        [HttpGet]
        [Route("{ShipClass: ShipClass")]
        public IHttpActionResult GetShipByClass([FromUri] ShipClass shipType)
        {
            var service = CreateShipService();
            var shipClass = service.GetShipByClass(shipType);
            return Ok(shipClass);
        }
        [HttpPut]
        [Route("{ShipId:int}")]
        public IHttpActionResult UpdateShipById([FromUri] int shipId, ShipUpdateModel shipToUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateShipService();
            service.UpdateShipById(shipId, shipToUpdate);
            return Ok();
        }
        [HttpDelete]
        [Route("{ShipId:int}")]
        public IHttpActionResult DeleteShipById([FromUri] int shipId)
        {
            var service = CreateShipService();
            service.DeleteShipById(shipId);
            return Ok();
        }
    }
}
