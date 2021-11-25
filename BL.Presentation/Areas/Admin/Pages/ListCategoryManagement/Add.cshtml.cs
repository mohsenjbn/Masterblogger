using BL.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BL.Presentation.Areas.Admin.Pages.ListCategory
{
    public class AddModel : PageModel
    {
        [TempData]
        public string Error { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;
        public AddModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }
        public void OnGet()
        {

        }


        public IActionResult Onpost(ArticleCategoryCreate command )
        {
            if (_articleCategoryApplication.IsExist(command.Title))
            {
                Error = "[pasid[pia[pd";
            } 

            _articleCategoryApplication.CreateCategory(command);
            return RedirectToPage("./Index");
        }
    }
}
