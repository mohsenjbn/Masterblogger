using _01.Framework.Repository;
using BL.Application.Contracts.Article;
using BL.Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore;

namespace BL.Infrastracture.Repositories
{
    public class ArticleRepository: BaseRepository<int,Article>,IArticleRepository
    {
        private readonly BlogContext _context;
        public ArticleRepository(BlogContext context):base(context)
        {
            _context = context;
        }

        public List<ArticleViewmodel> GetList()
        {
           return _context.Articles.Include(p=>p.category).Select(p=>new ArticleViewmodel { 
           Id = p.Id,
           CreationDate=p.CreationDate.ToString(),
           Image=p.Image,
           IsDeleted=p.IsDeleted,
           Name=p.Name,
           CategoryName=p.category.Title
           }).ToList();
        }

      

        public void save()
        {
            _context.SaveChanges();
        }
    }
}
