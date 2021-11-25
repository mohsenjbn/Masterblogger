

namespace BL.Application.Contracts.Article
{
    public class CreateArticle
    {
        public string Name { get; set; }
        public string ShortDescribtion { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public int ArticleCategoryId { get; set; }

    
    }
}
