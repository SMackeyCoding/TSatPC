using Data.Entities;
using Models.CommentModels;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("api/Comments")]
    public class CommentController : ApiController
    {
        private CommentService CreateCommentService()
        {
            var commentService = new CommentService();
            return commentService;
        }
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult CreateComment([FromBody] CommentCreateModel commentToCreate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateCommentService();
            service.CreateComment(commentToCreate);
            return Ok();
        }
        [HttpGet]
        [Route("{CharacterId:int}")]
        public IHttpActionResult GetCommentList([FromUri] int characterId)
        {
            var service = CreateCommentService();
            var comments = service.GetAllCommentsByCharacterId(characterId);
            return Ok(comments);
        }
        [HttpPut]
        [Route("{CharacterId:int}")]
        public IHttpActionResult UpdateCommentById([FromUri] int characterId, CommentUpdateModel commentToUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateCommentService();
            service.UpdateCommentByCommentId(characterId, commentToUpdate);
                return Ok();
        }
        [HttpDelete]
        [Route("{CommentId:int}")]
        public IHttpActionResult DeleteCommentById([FromUri] int commentId)
        {
            var service = CreateCommentService();
            service.DeleteCommentByCommentId(commentId);
            return Ok();
        }
    }
}