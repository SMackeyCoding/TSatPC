using Models.FavoriteModels;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("api/favorites")]
    public class FavoritesController : ApiController
    {
        private FavoriteService CreateFavoritesService()
        {
            var favoritesService = new FavoriteService();
            return favoritesService;
        }
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult CreateFavorite(FavoritesCreateModel favoritesToCreate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateFavoritesService();
            service.CreateFavorite(favoritesToCreate);
            return Ok();
        }
        [HttpGet]
        [Route("List")]
        public IHttpActionResult GetContractList()
        {
            var service = CreateFavoritesService();
            var contracts = service.GetAllFavorites();
            return Ok(contracts);
        }
        [HttpGet]
        [Route("{FavoritesId:int}")]
        public IHttpActionResult GetFavoritesDetailById([FromUri] int favoritesId)
        {
            var service = CreateFavoritesService();
            var favoritesDetail = service.GetFavoritesDetailById(favoritesId);
            return Ok(favoritesDetail);
        }
        [HttpPut]
        [Route("{FavoritesId:int}")]
        public IHttpActionResult UpdateFavorites([FromUri] int favoritesId, FavoritesUpdateModel favoritesToUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateFavoritesService();
            service.UpdateFavoritesById(favoritesId, favoritesToUpdate);
            return Ok();
        }
        [HttpDelete]
        [Route("{FavoritesId:int}")]
        public IHttpActionResult DeleteFavorites([FromUri] int favoritesId)
        {
            var service = CreateFavoritesService();
            service.DeleteFavoritesById(favoritesId);
            return Ok();
        }
    }
}
