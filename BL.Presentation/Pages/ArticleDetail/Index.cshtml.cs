using BL.Infrastracture.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BL.Presentation.Pages.ArticleDetai
{
    public class IndexModel : PageModel
    {
        public ArticeQueryView Article { get; set; }
        private readonly IArticleQuery _articleQuery;
        public IndexModel(IArticleQuery articleQuery)
        {
            _articleQuery=articleQuery;
        }
        public void OnGet(int id)
        {
            Article = _articleQuery.GetBy(id);
        }
    }
}
