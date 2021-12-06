namespace BL.Application.Contracts.ArticleCategory
{
    public interface IArticleCategoryApplication
    {
        List<ArticleCategoryViewModel> Get();

        void CreateCategory(ArticleCategoryCreate command);

        void Edit(EditCategory command);

        EditCategory Getby(int id);

        void Delete(int id);

        void Activate(int id);

        
    }
}
