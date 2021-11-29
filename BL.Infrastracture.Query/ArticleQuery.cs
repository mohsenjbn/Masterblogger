

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
            return _context.Articles.Where(p=>p.IsDeleted==false).Include(p=>p.category).Select(x => new ArticeQueryView {
                Id = x.Id,
            Name = x.Name,
            ShortDescribtion = x.ShortDescribtion,
            Content = x.Content,
            CategoryName=x.category.Title,
            CreationDate = x.CreationDate.ToString(),
            Image=x.Image,
            }).ToList();
        }

        public ArticeQueryView GetBy(int id)
        {
            return _context.Articles.Where(p => p.IsDeleted == false).Include(p => p.category).Select(x => new ArticeQueryView
            {
                Id = x.Id,
                Name = x.Name,
                ShortDescribtion = x.ShortDescribtion,
                Content = x.Content,
                CategoryName = x.category.Title,
                CreationDate = x.CreationDate.ToString(),
                Image = x.Image,
            }).FirstOrDefault(p=>p.Id==id);
        }

       
    }
}
