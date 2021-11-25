using BL.Application.Contracts.ArticleCategory;
using BL.Domain.ArticleCategoryAgg;
using BL.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Application
{
    public class ApplicationArticleCategory : IArticleCategoryApplication
    {
        private readonly IArticleCategpryRepository _articleCategoryRepository;
        private readonly IArticleCategoryValidator _articleCategpryValidator;
        public ApplicationArticleCategory(IArticleCategpryRepository articleCategpryRepository,IArticleCategoryValidator articleCategoryValidator)
        {
            _articleCategoryRepository = articleCategpryRepository;
            _articleCategpryValidator = articleCategoryValidator;
        }

        public void Activate(int id)
        {
            var ArticleCategory=  _articleCategoryRepository.GetBy(id);
            ArticleCategory.Activate();
            _articleCategoryRepository.save();
        }

        public void CreateCategory(ArticleCategoryCreate command)
        {
            var category = new ArticleCategory(command.Title,_articleCategpryValidator);

            _articleCategoryRepository.Add(category);

        }

        public void Delete(int id)
        {
            var ArticleCategory = _articleCategoryRepository.GetBy(id);
            ArticleCategory.Remove();
            _articleCategoryRepository.save();
        }

        public void Edit(EditCategory command)
        {
            var Category = _articleCategoryRepository.GetBy(command.id);
            Category.Edit(command.Title);
            _articleCategoryRepository.save();
        }

        public List<ArticleCategoryViewModel> Get()
        {
            var articleCategories = _articleCategoryRepository.GetAll();
            var result=new List<ArticleCategoryViewModel>();

            foreach (var articleCategory in articleCategories)
            {
                result.Add(new ArticleCategoryViewModel()
                {
                    Title=articleCategory.Title,
                    Id = articleCategory.Id,
                    
                    CreationDate = articleCategory.CreationDate.ToString(),
                    IsRemove= articleCategory.IsRemove,
                }) ;
            }
            return result;
        }

        public EditCategory Getby(int id)
        {
            var GetCategory= _articleCategoryRepository.GetBy(id);

            var Category = new EditCategory()
            {
                id = GetCategory.Id,
                Title = GetCategory.Title,
            };

            return Category;

        }

       

        public bool IsExist(string title)
        {
            return _articleCategoryRepository.Exist(title);
        }
    }
}
