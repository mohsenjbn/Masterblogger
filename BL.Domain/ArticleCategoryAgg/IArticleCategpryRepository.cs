using _01.Framework.Repository;


namespace BL.Domain.ArticleCategoryAgg
{
    public interface IArticleCategpryRepository: IRepository<int, ArticleCategory>
    {

        void save();

    }
}
