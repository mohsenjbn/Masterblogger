using BL.Application.Contracts.Comment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BL.Presentation.Areas.Admin.Pages.CommentManagment
{
    public class IndexModel : PageModel
    {
        public List<CommentViewModel> Comments { get; set; }
        private readonly ICommentApplication _commentApplication;
        public IndexModel(ICommentApplication commentApplication)
        {
            _commentApplication= commentApplication;
        }

        public void OnGet()
        {
            Comments=_commentApplication.GetAllComments();
        }

        public IActionResult OnGetConfirm(int Id)
        {
            _commentApplication.Confirm(Id);
            return RedirectToPage("./Index");
        }

        public IActionResult OnGetCancel(int Id)
        {
            _commentApplication.Cancel(Id);
            return RedirectToPage("./Index");
        }
    }
}
