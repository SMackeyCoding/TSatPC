using Models.CharacterModels;
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
    [RoutePrefix("api/Characters")]
    public class CharacterController : ApiController
    {
        private CharacterService CreateCharacterService()
        {
            var characterService = new CharacterService();
            return characterService;
        }
        [OverrideAuthorization]
        [Authorize(Roles = "Admin,Hunter")]
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult CreateCharacter([FromBody] CharacterCreateModel characterToCreate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateCharacterService();
            service.CreateCharacter(characterToCreate);
            return Ok();
        }
        [OverrideAuthorization]
        [Authorize(Roles = "Admin,Client,Hunter")]
        [HttpGet]
        [Route("List")]
        public IHttpActionResult GetCharacterList()
        {
            var service = CreateCharacterService();
            var characters = service.GetAllCharacters();
            return Ok(characters);
        }
        [OverrideAuthorization]
        [Authorize(Roles = "Admin,Client,Hunter")]
        [HttpGet]
        [Route("{CharacterId:int}")]
        public IHttpActionResult GetCharacterDetailById([FromUri] int characterId)
        {
            var service = CreateCharacterService();
            var characterDetail = service.GetCharacterDetailById(characterId);
            return Ok(characterDetail);
        }
        [OverrideAuthorization]
        [Authorize(Roles = "Admin,Hunter")]
        [HttpPut]
        [Route("{CharacterId:int}")]
        public IHttpActionResult UpdateCharacterById([FromUri] int characterId, CharacterUpdateModel characterToUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateCharacterService();
            service.UpdateCharacterById(characterId, characterToUpdate);
            return Ok();
        }
        [OverrideAuthorization]
        [Authorize(Roles = "Admin,Hunter")]
        [HttpDelete]
        [Route("{CharacterId:int}")]
        public IHttpActionResult DeleteCharacterById([FromUri] int characterId)
        {
            var service = CreateCharacterService();
            service.DeleteCharacterById(characterId);
            return Ok();
        }
    }
}