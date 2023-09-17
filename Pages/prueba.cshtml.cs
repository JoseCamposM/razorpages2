using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class pruebaModel : PageModel
    {

        public double num1 {get; set;}
        public double num2  {get; set;}
        public double resultado {get; set;}
        public string? salida {get; set;}


        public IActionResult OnPostSumar(){
            num1 = double.Parse(Request.Form["num1"]!);
            num2 = double.Parse(Request.Form["num2"]!);
            resultado = num1 + num2;
            salida = $"Sumar {num1} mas {num2} es {resultado}";
            return Page();
        }

        public IActionResult OnPostRestar(){
            num1 = double.Parse(Request.Form["num1"]!);
            num2 = double.Parse(Request.Form["num2"]!);
            resultado = num1 - num2;
            salida = $"Restar {num1} menos {num2} es {resultado}";
            return Page();
        }

        public IActionResult OnPostMultiplicar(){
            
            num1 = double.Parse(Request.Form["num1"]!);
            num2 = double.Parse(Request.Form["num2"]!);
            resultado = num1 * num2;
            salida = $"Multiplicar {num1} por {num2} es {resultado}";
            return Page();
        }

        public IActionResult OnPostDividir(){
            
            num1 = double.Parse(Request.Form["num1"]!);
            num2 = double.Parse(Request.Form["num2"]!);
            resultado = num1 / num2;
            salida = $"Dividir de {num1} entre {num2} es {resultado}";
            return Page();
        }


        public void OnGet()
        {



        }
    }
}
