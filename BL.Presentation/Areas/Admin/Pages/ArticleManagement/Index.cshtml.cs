using BL.Application.Contracts.Article;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BL.Presentation.Areas.Admin.Pages.AricleManagement
{
    public class IndexModel : PageModel
    {
        public List<ArticleViewmodel> Articles { get; set; }
        private readonly IArticleApplication _articleApplication;
        public IndexModel(IArticleApplication articleApplication)
        {
            _articleApplication = articleApplication;
        }
        public void OnGet()
        {
            Articles=_articleApplication.GetArticles();
        }

        public IActionResult OnGetDelete(int Id)
        {
           _articleApplication.DeleteArticle(Id);
            return RedirectToPage("./Index");
        }

        public IActionResult OnGetActivate(int Id)
        {
            _articleApplication.ActivateArticle(Id);
            return RedirectToPage("./Index");
        }
    }
}
