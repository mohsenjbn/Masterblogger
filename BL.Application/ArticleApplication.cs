using BL.Application.Contracts.Article;
using BL.Domain.ArticleAgg;

namespace BL.Application
{
    public class ArticleApplication: IArticleApplication
    {
        private readonly IArticleRepository _articleRepository;
        public ArticleApplication(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void CreateArticle(CreateArticle command)
        {
            var Article=new Article(command.Name,command.ShortDescribtion,command.Content,command.Image,command.ArticleCategoryId);
            _articleRepository.Create(Article);
        }

        public List<ArticleViewmodel> GetArticles()
        {
            return _articleRepository.GetAll();
        }
    }
}
