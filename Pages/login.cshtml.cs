using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{       
   
    
    
    public class loginModel : PageModel
    {
        string user = "jose", password = "123456";
        public string mensage;
        public string? usuario {get;set;}
        public string? contraseña {get;set;}

        public IActionResult OnPost(){

            usuario = Request.Form["usuario"];
            contraseña = Request.Form["contraseña"];
            TempData["Username"] = usuario;

            if (user == usuario && password == contraseña){

                return RedirectToPage("/inicio");
            }
            else{
                mensage = "Error en usuario o contraseña, intente de nuevo.";
            }


            return Page();

        }


        public void OnGet()
        {
        }
    }
}
