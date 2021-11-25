

namespace BL.Application.Contracts.Article
{
    public interface IArticleApplication
    {
        List<ArticleViewmodel> GetArticles();

        void CreateArticle(CreateArticle command);
        void EditCategort(EditArticle command);
        EditArticle GetDetails(int id);    

        void DeleteArticle(int id);

        void ActivateArticle(int id);
    }
}
