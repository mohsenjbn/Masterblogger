namespace BL.Infrastracture.Query
{
    public interface IArticleQuery
    {
        List<ArticeQueryView> GetAll();
        ArticeQueryView GetBy(int id);
    }
}
