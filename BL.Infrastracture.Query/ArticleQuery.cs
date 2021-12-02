

using BL.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;

namespace BL.Infrastracture.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _context;
        public ArticleQuery(BlogContext context)
        {
            _context = context;
        }
        public List<ArticeQueryView> GetAll()
        {
            return _context.Articles.Where(p=>p.IsDeleted==false).Include(p=>p.category).Include(p=>p.Comments).Select(x => new ArticeQueryView {
                Id = x.Id,
            Name = x.Name,
            ShortDescribtion = x.ShortDescribtion,
            Content = x.Content,
            CategoryName=x.category.Title,
            CreationDate = x.CreationDate.ToString(),
            Image=x.Image,
            Commentcount=x.Comments.Count(p=>p.Status==Statuses.Confirm),
            }).ToList();
        }

        public ArticeQueryView GetBy(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return _context.Articles.Where(p => p.IsDeleted == false).Include(p => p.category).Include(p=>p.Comments).Select(x => new ArticeQueryView
            {
                Id = x.Id,
                Name = x.Name,
                ShortDescribtion = x.ShortDescribtion,
                Content = x.Content,
                CategoryName = x.category.Title,
                CreationDate = x.CreationDate.ToString(),
                Image = x.Image,
                Commentcount=x.Comments.Count(p=>p.Status==Statuses.Confirm),
                Comments=MapComment(x.Comments.Where(p=>p.Status==Statuses.Confirm))
            }).FirstOrDefault(p=>p.Id==id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        private static List<CommentQueryView> MapComment(IEnumerable<Comment> enumerable)
        {
           var result=new List<CommentQueryView>();

            foreach (var comment in enumerable)
            {
                result.Add(new CommentQueryView {CreationDate=comment.CreationDate.ToString(),Name=comment.Name,Message=comment.Message });
            }
            return result;
        }
    }
}
