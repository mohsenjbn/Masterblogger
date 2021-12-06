using _01.Framework.Repository;
using BL.Domain.ArticleCategoryAgg;

namespace BL.Infrastracture.Repositories
{
    public class ArticleCategoryRepository : BaseRepository<int,ArticleCategory>,IArticleCategpryRepository
    {
        private readonly BlogContext _Context;
        public ArticleCategoryRepository(BlogContext context):base(context)
        {
            _Context = context;
        }

        public void save()
        {
            _Context.SaveChanges();
        }
    }
}
