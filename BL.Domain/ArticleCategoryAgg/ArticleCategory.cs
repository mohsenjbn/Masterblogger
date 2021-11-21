using BL.Domain.Services;

namespace BL.Domain.ArticleCategoryAgg
{
    public class ArticleCategory
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public bool IsRemove { get; private set; }
        public DateTime CreationDate { get; private set; }


        protected ArticleCategory()
        {

        }
        public ArticleCategory(string title,IArticleCategoryValidator Validator)
        {
            Validator.ThisalreadyExistTitle(title);
            CkechingNullTitle(title);
            Title = title;
            CreationDate = DateTime.Now;
            IsRemove = false;
        }
        public void CkechingNullTitle(string title)
        {
            if (Title == null)
                throw new ArgumentNullException();
        }
        public void Edit(string title)
        {
            CkechingNullTitle(title);
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
