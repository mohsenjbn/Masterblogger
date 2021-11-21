using BL.Domain.ArticleCategoryAgg;


namespace BL.Domain.Services
{
    public class ArticleCategoryValidator : IArticleCategoryValidator
    {
        private readonly IArticleCategpryRepository _articleCategoryRepository;

        public ArticleCategoryValidator(IArticleCategpryRepository articleCategpryRepository)
        {
            _articleCategoryRepository = articleCategpryRepository;
        }
        public void ThisalreadyExistTitle(string title)
        {
            if (_articleCategoryRepository.Exist(title))
                throw new Exception();
           
        }
    }
}
