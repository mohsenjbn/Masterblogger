

namespace BL.Application.Contracts.Comment
{
    public interface  ICommentApplication
    {
        void AddComment(AddComment command);

        void Confirm(int Id);
        void Cancel(int Id);
        List<CommentViewModel> GetAllComments();
    }
}
