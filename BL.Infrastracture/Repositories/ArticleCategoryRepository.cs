using BL.Domain.ArticleCategoryAgg;

namespace BL.Infrastracture.Repositories
{
    public class ArticleCategoryRepository : IArticleCategpryRepository
    {
        private readonly BlogContext _Context;
        public ArticleCategoryRepository(BlogContext context)
        {
            _Context = context;
        }

        public void Add(ArticleCategory entity)
        {
            _Context.ArticleCategories.Add(entity);
            save();
        }

        public bool Exist(string title)
        {
            return _Context.ArticleCategories.Any(c => c.Title == title);
        }

        public List<ArticleCategory> GetAll()
        {
           return _Context.ArticleCategories.ToList();
        }

        public ArticleCategory GetBy(int id)
        {
            return _Context.ArticleCategories.FirstOrDefault(c => c.Id == id);
        }

        public void save()
        {
            _Context.SaveChanges();
        }
    }
}
