using Contracts;
using Data;
using Data.Entities;
using Models.CommentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CommentService : ICommentService
    {
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();
        public void CreateComment(CommentCreateModel commentToCreate)
        {
            var entity = new Comment()
            {
                //UserId = commentToCreate.UserId,
                Text = commentToCreate.Text,
                CreatedAtUtc = commentToCreate.CreatedAtUtc
            };

            _ctx.Comments.Add(entity);
            _ctx.SaveChanges();
        }

        public void DeleteCommentByCommentId(int commentId)
        {
            var entity = _ctx.Comments.Single(e => e.CommentId == commentId);
            _ctx.Comments.Remove(entity);
            _ctx.SaveChanges();
        }

        public IEnumerable<CommentListModel> GetAllCommentsByCharacterId(int characterId)
        {
            List<Comment> comments = (List<Comment>)_ctx.Comments.Select(e => e.CharacterId == characterId);
            var returnList = comments.Select(e => new CommentListModel()
            {
                Text = e.Text,
            }).ToList();
            return returnList;
        }

        //public CommentDetailModel GetDetailedCommentsByCharacterId(int characterId)
        //{
        //    List<Comment> comments = (List<Comment>)_ctx.Comments.Select(e => e.CharacterId == characterId);
        //    var returnList = comments.Select(e => new CommentDetailModel()
        //    {
        //        Text = e.Text,
        //    }).ToList();
        //    return returnList;
        //}
        // DONT THINK EMPLOYERS WOULD LIKE HUNTERS KNOWING WHO WROTE WHAT AND WHEN, MAKE IT MORE OBSCURE

        public void UpdateCommentByCommentId(int commentId, CommentUpdateModel commentToUpdate)
        {
            var entity = _ctx.Comments.Single(e => e.CommentId == commentId);
            if (entity != null)
            {
                if (commentToUpdate.UpdatedCharacterId != null)
                    entity.CharacterId = (int)commentToUpdate.UpdatedCharacterId;
                if (commentToUpdate.UpdatedText != null)
                    entity.Text = commentToUpdate.UpdatedText;
                if (commentToUpdate.UpdatedPlanetId != null)
                    entity.PlanetId = (int)commentToUpdate.UpdatedPlanetId;
                if (commentToUpdate.UpdatedShipId != null)
                    entity.ShipId = (int)commentToUpdate.UpdatedShipId;
                if (commentToUpdate.UpdatedWeaponId != null)
                    entity.WeaponId = (int)commentToUpdate.UpdatedWeaponId;
                if (commentToUpdate.UpdatedCreatedAtUtc != null)
                    entity.CreatedAtUtc = (DateTime)commentToUpdate.UpdatedCreatedAtUtc;
            }
        }
    }
}
