

namespace BL.Application.Contracts.Article
{
    public interface IArticleApplication
    {
        List<ArticleViewmodel> GetArticles();

        void CreateArticle(CreateArticle command);
    }
}
