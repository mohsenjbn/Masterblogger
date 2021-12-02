using BL.Application.Contracts.Comment;
using BL.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace BL.Infrastracture.Repositories
{
    public class CommentRepository:ICommentRepository
    {
        private readonly BlogContext _context;
        public CommentRepository(BlogContext context)
        {
            _context = context;
        }

        public void AddComment(Comment entity)
        {
            
        _context.Comments.Add(entity);
            save();
        }

        public List<CommentViewModel> GetAll()
        {
          return  _context.Comments.Include(c=>c.Article).Select(p=>new CommentViewModel()
          {
              Name=p.Name,
              Email=p.Email,
              Message=p.Message,
              ArticleName=p.Article.Name,
              Id=p.Id,
              CreationDate=p.CreationDate.ToString(CultureInfo .InvariantCulture),
              Status=p.Status
             
          
          }).ToList();
        }

        public Comment GetCommentby(int id)
        {
           return _context.Comments.FirstOrDefault(p=>p.Id==id);
        }

        public void save()
        {
            _context.SaveChanges();
        }
    }
}
