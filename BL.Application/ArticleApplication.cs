using _01.Framework.Repository;
using BL.Application.Contracts.Article;
using BL.Domain.ArticleAgg;
using BL.Domain.ArticleAgg.Services;

namespace BL.Application
{
    public class ArticleApplication: IArticleApplication
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IArticleRepository _articleRepository;
        private readonly IArticleValidator _articleValidator;
        public ArticleApplication(IArticleRepository articleRepository, IArticleValidator articleValidator,IUnitOfWork unitOfWork)
        {
            _articleRepository = articleRepository;
              _articleValidator = articleValidator;
            _unitOfWork = unitOfWork;
        }

        public void ActivateArticle(int id)
        {
            _unitOfWork.BeginTran();
            var article = _articleRepository.GetBy(id);
            article.Activate();
            _unitOfWork.CommitTran();
        }

        public void CreateArticle(CreateArticle command)
        {
            _unitOfWork.BeginTran();
            var Article=new Article(command.Name,command.ShortDescribtion,command.Content,command.Image,command.ArticleCategoryId,_articleValidator);
            _articleRepository.Create(Article);
            _unitOfWork.CommitTran();
        }

        public void DeleteArticle(int id)
        {
            _unitOfWork.BeginTran();
            var article = _articleRepository.GetBy(id);
            article.Delete();
            _unitOfWork.CommitTran();
        }

        public void EditCategort(EditArticle command)
        {
            _unitOfWork.BeginTran();
            var article = _articleRepository.GetBy(command.Id);
            article.Edit(command.Name,command.ShortDescribtion,command.Content,command.Image,command.ArticleCategoryId);
            _unitOfWork.CommitTran();
        }

        public List<ArticleViewmodel> GetArticles()
        {
            return _articleRepository.GetList();
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
