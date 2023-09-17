using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class formularioModel : PageModel
    {
        public string? producto;
        public int cantidad;
        public double precio, total;

        public IActionResult OnPost()
        {

            producto = Request.Form["producto"];
            cantidad = int.Parse(Request.Form["cantidad"]!);
            precio = double.Parse(Request.Form["precio"]!);
    
            total = cantidad * precio;

            return Page();
        }

        public void OnGet()
        {

        }
    }
}
