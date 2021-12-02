using BL.Application.Contracts.Comment;
using BL.Infrastracture.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BL.Presentation.Pages.ArticleDetai
{
    public class IndexModel : PageModel
    {
        public ArticeQueryView Article { get; set; }
        
        private readonly ICommentApplication _commentApplication;
        private readonly IArticleQuery _articleQuery;
        public IndexModel(IArticleQuery articleQuery, ICommentApplication commentApplication)
        {
            _articleQuery=articleQuery;
            _commentApplication=commentApplication;
        }
        public void OnGet(int id)
        {
            Article = _articleQuery.GetBy(id);
        }

        public IActionResult OnPost(AddComment command)
        {
            _commentApplication.AddComment(command);
            return RedirectToPage("./Index", new { id=command.ArticleId }) ;
        }
    }
}
