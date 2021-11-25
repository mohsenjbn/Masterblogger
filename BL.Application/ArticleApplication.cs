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
    }
}
