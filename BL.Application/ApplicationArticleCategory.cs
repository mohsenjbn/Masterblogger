using _01.Framework.Repository;
using BL.Application.Contracts.ArticleCategory;
using BL.Domain.ArticleCategoryAgg;
using BL.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BL.Application
{
    public class ApplicationArticleCategory : IArticleCategoryApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IArticleCategpryRepository _articleCategoryRepository;
        private readonly IArticleCategoryValidator _articleCategpryValidator;
      
        public ApplicationArticleCategory(IArticleCategpryRepository articleCategpryRepository,IArticleCategoryValidator articleCategoryValidator, IUnitOfWork unitOfWork)
        {
            _articleCategoryRepository = articleCategpryRepository;
            _articleCategpryValidator = articleCategoryValidator;
            _unitOfWork= unitOfWork;
        }

        public void Activate(int id)
        {
            _unitOfWork.BeginTran();
            var ArticleCategory=  _articleCategoryRepository.GetBy(id);
            ArticleCategory.Activate();
            _unitOfWork.CommitTran();
            
        }

        public void CreateCategory(ArticleCategoryCreate command)
        {
            _unitOfWork.BeginTran();
            var category = new ArticleCategory(command.Title,_articleCategpryValidator);

            _articleCategoryRepository.Create(category);
            _unitOfWork.CommitTran();
        }

        public void Delete(int id)
        {
            _unitOfWork.BeginTran();
            var ArticleCategory = _articleCategoryRepository.GetBy(id);
            ArticleCategory.Remove();
            _unitOfWork.CommitTran();
        }

        public void Edit(EditCategory command)
        {
            _unitOfWork.BeginTran();
            var Category = _articleCategoryRepository.GetBy(command.id);
            Category.Edit(command.Title);
            _unitOfWork.CommitTran();
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

       

     
    }
}
