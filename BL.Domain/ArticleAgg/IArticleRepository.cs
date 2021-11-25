
using BL.Application.Contracts.Article;

namespace BL.Domain.ArticleAgg
{
    public interface IArticleRepository
    {
        List<ArticleViewmodel> GetAll();
        void Create(Article entity);
    }
}
