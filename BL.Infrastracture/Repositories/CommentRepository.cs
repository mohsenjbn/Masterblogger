using _01.Framework.Repository;
using BL.Application.Contracts.Comment;
using BL.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace BL.Infrastracture.Repositories
{
    public class CommentRepository : BaseRepository<int, Comment>,ICommentRepository
    {
        private readonly BlogContext _context;
        public CommentRepository(BlogContext context):base(context)
        {
            _context = context;
        }

     

        public List<CommentViewModel> GetList()
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

       

        public void save()
        {
            _context.SaveChanges();
        }
    }
}
