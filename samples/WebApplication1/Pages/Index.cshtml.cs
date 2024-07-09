using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet(string code = "", string state = "")
        {
            ViewData["code"] = code;
            ViewData["state"] = state;
        }
    }
}
