using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class WeaponController : ApiController
    {
        private WeaponService CreateWeaponService()
            {
                var weaponService = new WeaponService();
                return weaponService;
            }
            [HttpPost]
            [Route("Create")]
            public IHttpActionResult CreateWeapon(WeaponCreateModel weaponToCreate)
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
                var weapons = service.GetWeapons();
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
            [HttpPut]
            [Route("{WeaponId:int}")]
            public IHttpActionResult UpdateWeapon([FromUri] int weaponId, WeaponUpdateModel weaponToUpdate)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                var service = CreateWeaponService();
                service.UpdateWeapon(weaponId, weaponToUpdate);
                return Ok();
            }
            [HttpDelete]
            [Route("{WeaponId:int}")]
            public IHttpActionResult DeleteWeapon([FromUri] int weaponId)
            {
                var service = CreateWeaponService();
                service.DeleteWeapon(weaponId);
                return Ok();
            }
        }
    }