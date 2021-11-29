using BL.Application.Contracts.Article;
using BL.Domain.ArticleAgg;
using BL.Domain.ArticleAgg.Services;

namespace BL.Application
{
    public class ArticleApplication: IArticleApplication
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IArticleValidator _articleValidator;
        public ArticleApplication(IArticleRepository articleRepository, IArticleValidator articleValidator)
        {
            _articleRepository = articleRepository;
              _articleValidator = articleValidator;
        }

        public void ActivateArticle(int id)
        {
            var article = _articleRepository.GetBy(id);
            article.Activate();
            _articleRepository.save();
        }

        public void CreateArticle(CreateArticle command)
        {
            var Article=new Article(command.Name,command.ShortDescribtion,command.Content,command.Image,command.ArticleCategoryId,_articleValidator);
            _articleRepository.Create(Article);
        }

        public void DeleteArticle(int id)
        {
            var article = _articleRepository.GetBy(id);
            article.Delete();
            _articleRepository.save();
        }

        public void EditCategort(EditArticle command)
        {
            var article = _articleRepository.GetBy(command.Id);
            article.Edit(command.Name,command.ShortDescribtion,command.Content,command.Image,command.ArticleCategoryId);
            _articleRepository.save();
        }

        public List<ArticleViewmodel> GetArticles()
        {
            return _articleRepository.GetAll();
        }

        public EditArticle GetDetails(int id)
        {
            var Article = _articleRepository.GetBy(id);
            return new EditArticle()
            {
                Id = Article.Id,
                Image = Article.Image,
                ShortDescribtion=Article.ShortDescribtion,
                Content = Article.Content,
                ArticleCategoryId=Article.ArticleCategoryId,
                Name=Article.Name,
            };
        }
    }
}
