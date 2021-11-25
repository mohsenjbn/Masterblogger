using BL.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BL.Presentation.Areas.Admin.Pages.ListCategory
{
    public class IndexModel : PageModel
    {
        public List<ArticleCategoryViewModel> Categories { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;
        public IndexModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }
        public void OnGet()
        {
            Categories = _articleCategoryApplication.Get();
        }

        public IActionResult OnGetDelete(int Id)
        {
            _articleCategoryApplication.Delete(Id);
            return RedirectToPage("./Index");
        }

        public IActionResult OnGetActivate(int Id)
        {
            _articleCategoryApplication.Activate(Id);
            return RedirectToPage("./Index");
        }


    }
}
