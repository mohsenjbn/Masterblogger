

using BL.Domain.ArticleAgg.Services;
using BL.Domain.ArticleCategoryAgg;

namespace BL.Domain.ArticleAgg
{
    public class Article
    {
        public int Id { get; private set; }
        public string Name { get; private set;}
        public string ShortDescribtion { get; private set; }
        public string Content { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }
        public string Image { get; private set; }
        public int ArticleCategoryId { get; private set; }


        public ArticleCategory category { get; private set; }

        protected Article()
        {

        }

        public Article(string name,string shortdescribtion,string content,string image,int articlecategoryid, IArticleValidator articleValidator)
        {
            CkeckNullName(name);
            articleValidator.IsDoblicationName(name);
            Name = name;
            ShortDescribtion = shortdescribtion;
            Content = content;
            Image = image;
            ArticleCategoryId = articlecategoryid;
            IsDeleted = false;
            CreationDate = DateTime.Now;
        }

        private static void CkeckNullName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");
        }

        public void Edit(string name, string shortdescribtion, string content, string image, int articlecategoryid)
        {
            CkeckNullName(name);
            Name = name;
            ShortDescribtion = shortdescribtion;
            Content = content;
            Image = image;
            ArticleCategoryId = articlecategoryid;
        }



        public void Delete()
        {
            IsDeleted=true;
        }

        public void Activate()
        {
            IsDeleted = false;
        }
    }
}
