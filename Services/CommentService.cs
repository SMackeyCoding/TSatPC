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
                CharacterId = commentToCreate.CharacterId,
                Character = 
            }
        }

        public void DeleteCommentByCommentId(int commentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommentListModel> GetAllCommentsByCharacterId()
        {
            throw new NotImplementedException();
        }

        public CommentDetailModel GetDetailedCommentsByCharacterId()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommentByCommentId(int commentId, CommentUpdateModel commentToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
