using BL.Domain.ArticleCategoryAgg;
using BL.Domain.Exeptions;

namespace BL.Domain.Services
{
    public class ArticleCategoryValidator : IArticleCategoryValidator
    {
        private readonly IArticleCategpryRepository _articleCategoryRepository;

        public ArticleCategoryValidator(IArticleCategpryRepository articleCategpryRepository)
        {
            _articleCategoryRepository = articleCategpryRepository;
        }

        public void CkechingNullTitle(string title)
        {
            if (title == null)
                throw new ArgumentNullException("title");
        }

        public void ThisalreadyExistTitle(string title)
        {
            if (_articleCategoryRepository.Exist(title))
                throw new DoblicatedTitleExeption($"this tile {title} aleaReady Exist");
        }
    }
}
