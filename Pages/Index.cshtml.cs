using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzzWeb.Forms;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? Name { get; set; }

        public string? Message { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }
        }

        public IActionResult OnPost()
        {
            Message = FizzBuzz.CheckNumber(FizzBuzz.Number);
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }
            return Page();

            /*if (ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToPage("./Privacy");*/
        }
    }
}