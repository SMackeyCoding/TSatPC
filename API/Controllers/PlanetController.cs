using Contracts;
using Models.PlanetModels;
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
    [RoutePrefix("api/Planets")]
    public class PlanetController : ApiController
    {
        private PlanetService CreatePlanetService()
        {
            var planetService = new PlanetService();
            return planetService;
        }
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult CreatePlanet([FromBody] PlanetCreateModel planetToCreate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreatePlanetService();
            service.CreatePlanet(planetToCreate);
            return Ok();
        }
        [HttpGet]
        [Route("List")]
        public IHttpActionResult GetPlanetList()
        {
            var service = CreatePlanetService();
            var planets = service.GetAllPlanets();
            return Ok(planets);
        }
        [HttpGet]
        [Route("{PlanetId:int}")]
        public IHttpActionResult GetPlanetDetailById([FromUri] int planetId)
        {
            var service = CreatePlanetService();
            var planetDetail = service.GetPlanetDetailById(planetId);
            return Ok(planetDetail);
        }
        [HttpPut]
        [Route("{PlanetId:int}")]
        public IHttpActionResult UpdatePlanet([FromUri] int planetId, PlanetUpdateModel planetToUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreatePlanetService();
            service.UpdatePlanetById(planetId, planetToUpdate);
            return Ok();
        }
        [HttpDelete]
        [Route("{PlanetId:int}")]
        public IHttpActionResult DeletePlanet([FromUri] int planetId)
        {
            var service = CreatePlanetService();
            service.DeletePlanetById(planetId);
            return Ok();
        }
    }
}
