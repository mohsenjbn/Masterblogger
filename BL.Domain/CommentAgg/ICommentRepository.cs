using BL.Application.Contracts.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Domain.CommentAgg
{
    public interface  ICommentRepository
    {
        void AddComment(Comment entity);

        Comment GetCommentby(int id);
        List<CommentViewModel> GetAll();
        void save();
    }
}
