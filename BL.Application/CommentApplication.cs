
using BL.Application.Contracts.Comment;
using BL.Domain.CommentAgg;

namespace BL.Application
{
    public class CommentApplication: ICommentApplication
    {
        private readonly ICommentRepository _commentRepository;
        public CommentApplication(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public void AddComment(AddComment command)
        {
            var comment = new Comment(command.Name,command.Email,command.Message,command.ArticleId);
            _commentRepository.AddComment(comment);
        }

        public void Cancel(int Id)
        {
            _commentRepository.GetCommentby(Id).Cancel();
            _commentRepository.save();
        }

        public void Confirm(int Id)
        {
            _commentRepository.GetCommentby(Id).Confirm();
            _commentRepository.save();

        }

        public List<CommentViewModel> GetAllComments()
        {
            return _commentRepository.GetAll();
        }
    }
}
