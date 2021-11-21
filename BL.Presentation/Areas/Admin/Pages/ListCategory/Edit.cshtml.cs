using BL.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BL.Presentation.Areas.Admin.Pages.ListCategory
{
    public class EditModel : PageModel
    {
       [BindProperty] public EditCategory Category { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;
        public EditModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication= articleCategoryApplication;
        }
        public void OnGet(int id)
        {
            Category = _articleCategoryApplication.Getby(id);
        }

        public IActionResult OnPost()
        {
             _articleCategoryApplication.Edit(Category);
            return RedirectToPage("./Index");
        }
    }
}
