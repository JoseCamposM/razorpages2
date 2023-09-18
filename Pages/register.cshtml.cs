using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class registerModel : PageModel
    {
        public string? usuario {set; get;}
        public string? contraseña {set; get;}
        public string? mensage =  "asdasd";
        public IActionResult PostRegister(){
            usuario = Request.Form["usuario"];
            contraseña = Request.Form["contraseña"];
            
            if (!string.IsNullOrEmpty(usuario)){
                TempData["Username"] = usuario;
                TempData["Password"] = contraseña;
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
