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
    [RoutePrefix("api/Characters")]
    public class CharacterController : ApiController
    {
        private CharacterService CreateCharacterService()
        {
            var characterService = new CharacterService();
            return characterService;
        }
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
        [HttpGet]
        [Route("List")]
        public IHttpActionResult GetCharacterList()
        {
            var service = CreateCharacterService();
            var characters = service.GetAllCharacters();
            return Ok(characters);
        }
        [HttpGet]
        [Route("{CharacterId:int}")]
        public IHttpActionResult GetCharacterDetailById([FromUri] int characterId)
        {
            var service = CreateCharacterService();
            var characterDetail = service.GetCharacterDetailById(characterId);
            return Ok(characterDetail);
        }
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