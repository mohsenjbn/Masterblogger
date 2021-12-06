
using _01.Framework.Repository;
using BL.Application.Contracts.Article;

namespace BL.Domain.ArticleAgg
{
    public interface IArticleRepository:IRepository<int,Article>
    {
        List<ArticleViewmodel> GetList();
        void save();

    }
}
