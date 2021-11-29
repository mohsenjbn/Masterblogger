using BL.Infrastracture.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BL.Presentation.Pages
{
    public class IndexModel : PageModel
    {

        public List<ArticeQueryView> Articles { get; set; }

        private readonly IArticleQuery _articleQuery;
        public IndexModel(IArticleQuery articleQuery)
        {
            _articleQuery= articleQuery;
        }
        public void OnGet()
        {
           Articles=_articleQuery.GetAll();
        }
    }
}