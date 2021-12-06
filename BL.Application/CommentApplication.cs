
using _01.Framework.Repository;
using BL.Application.Contracts.Comment;
using BL.Domain.CommentAgg;

namespace BL.Application
{
    public class CommentApplication: ICommentApplication
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly ICommentRepository _commentRepository;
        public CommentApplication(ICommentRepository commentRepository,IUnitOfWork unitOfWork)
        {
            _commentRepository = commentRepository;
            _unitOfWork = unitOfWork;
        }

        public void AddComment(AddComment command)
        {
            _unitOfWork.BeginTran();
            var comment = new Comment(command.Name,command.Email,command.Message,command.ArticleId);
            _commentRepository.Create(comment);
            _unitOfWork.CommitTran();
        }

        public void Cancel(int Id)
        {
            _unitOfWork.BeginTran();
            _commentRepository.GetBy(Id).Cancel();
            _unitOfWork.CommitTran();
        }

        public void Confirm(int Id)
        {
            _unitOfWork.BeginTran();
            _commentRepository.GetBy(Id).Confirm();
            _unitOfWork.CommitTran();

        }

        public List<CommentViewModel> GetAllComments()
        {
            return _commentRepository.GetList();
        }
    }
}
