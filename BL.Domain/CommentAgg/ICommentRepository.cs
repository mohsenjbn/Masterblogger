using _01.Framework.Repository;
using BL.Application.Contracts.Comment;


namespace BL.Domain.CommentAgg
{
    public interface  ICommentRepository: IRepository<int, Comment>
    {

        List<CommentViewModel> GetList();
        void save();
    }
}
