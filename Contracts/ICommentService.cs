using Models.CommentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICommentService
    {
        void CreateComment(CommentCreateModel commentToCreate);
        IEnumerable<CommentListModel> GetAllCommentsByCharacterId(int characterId);
        void UpdateCommentByCommentId(int commentId, CommentUpdateModel commentToUpdate);
        void DeleteCommentByCommentId(int commentId);
    }
}
