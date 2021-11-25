

namespace BL.Application.Contracts.Article
{
    public class ArticleViewmodel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public bool IsDeleted { get; set; }
        public string CategoryName { get; set; }
        public string CreationDate { get; set; }
    }

}
