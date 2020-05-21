using Models.WeaponFolder;
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
    [RoutePrefix("api/Weapons")]
    public class WeaponController : ApiController
    {
        private WeaponService CreateWeaponService()
        {
            var weaponService = new WeaponService();
            return weaponService;
        }
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult CreateWeapon([FromBody] WeaponCreateModel weaponToCreate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateWeaponService();
            service.CreateWeapon(weaponToCreate);
            return Ok();
        }
        [HttpGet]
        [Route("List")]
        public IHttpActionResult GetWeaponList()
        {
            var service = CreateWeaponService();
            var weapons = service.GetAllWeapons();
            return Ok(weapons);
        }
        [HttpGet]
        [Route("{WeaponId:int}")]
        public IHttpActionResult GetWeaponDetailById([FromUri] int weaponId)
        {
            var service = CreateWeaponService();
            var weaponDetail = service.GetWeaponDetailById(weaponId);
            return Ok(weaponDetail);
        }
        [HttpGet]
        [Route("{Type}")]
        public IHttpActionResult GetWeaponByType([FromUri] WeaponType type)
        {
            var service = CreateWeaponService();
            var weaponType = service.GetWeaponByType(type);
            return Ok(weaponType);
        }
        [HttpPut]
        [Route("{WeaponId:int}")]
        public IHttpActionResult UpdateWeaponById([FromUri] int weaponId, WeaponUpdateModel weaponToUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateWeaponService();
            service.UpdateWeaponById(weaponId, weaponToUpdate);
            return Ok();
        }
        [HttpDelete]
        [Route("{WeaponId:int}")]
        public IHttpActionResult DeleteWeaponById([FromUri] int weaponId)
        {
            var service = CreateWeaponService();
            service.DeleteWeaponById(weaponId);
            return Ok();
        }
    }
}