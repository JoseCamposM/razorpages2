using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class registerModel : PageModel
    {
        public string? registerUse {get; set;}
        public string? passUse {get; set;}
        public string? mensage =  "asdasd";
        public IActionResult OnPost(){
            registerUse = Request.Form["registerUse"];
            passUse = Request.Form["passUse"];
            TempData["Username"] = registerUse;
            TempData["Password"] = passUse;

            if (!string.IsNullOrWhiteSpace(registerUse)){
               
                return RedirectToPage("/login");
            }
            else{
                return Page();
            }
           
    }
        public void OnGet()
        {
        }
    }
}
