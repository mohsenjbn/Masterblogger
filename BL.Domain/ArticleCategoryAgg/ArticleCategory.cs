using _01.Framework.Domain;
using BL.Domain.ArticleAgg;
using BL.Domain.Services;

namespace BL.Domain.ArticleCategoryAgg
{
    public class ArticleCategory:DomainBase<int>
    {
        public string Title { get; private set; }
        public bool IsRemove { get; private set; }

        public ICollection<Article> Articles { get;private  set; }

        protected ArticleCategory()
        {

        }
        public ArticleCategory(string title,IArticleCategoryValidator Validator)
        {
            Validator.ThisalreadyExistTitle(title);
            Validator.CkechingNullTitle(title);
            Title = title;
            IsRemove = false;
            Articles=new List<Article>();
        }
      
        public void Edit(string title)
        {
            
            Title = title;
        }

        public void Remove()
        {
            IsRemove = true;
        }
        public void Activate()
        {
            IsRemove = false;
        }
        

    }
}
