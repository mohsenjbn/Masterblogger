using BL.Application.Contracts.Article;
using BL.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BL.Presentation.Areas.Admin.Pages.ArticleManagement
{
    public class EditModel : PageModel
    {
    
     [BindProperty] public EditArticle Article { get; set; }

        public List<SelectListItem> Categories { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;
        private readonly IArticleApplication _articleApplication;
        public EditModel(IArticleCategoryApplication articleCategoryApplication, IArticleApplication articleApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
            _articleApplication = articleApplication;
        }
        public void OnGet(int Id)
        {
            Article = _articleApplication.GetDetails(Id);
            Categories = _articleCategoryApplication.Get().Select(p => new SelectListItem(p.Title, p.Id.ToString())).ToList();
        }

        public IActionResult OnPost()
        {
            _articleApplication.EditCategort(Article);
            return RedirectToPage("./Index");
        }
    }
}
