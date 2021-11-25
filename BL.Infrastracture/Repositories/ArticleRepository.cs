using BL.Application.Contracts.Article;
using BL.Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore;

namespace BL.Infrastracture.Repositories
{
    public class ArticleRepository:IArticleRepository
    {
        private readonly BlogContext _context;
        public ArticleRepository(BlogContext context)
        {
            _context = context;
        }

        public void Create(Article entity)
        {
            _context.Articles.Add(entity);
            _context.SaveChanges();
        }

        public List<ArticleViewmodel> GetAll()
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
    }
}
