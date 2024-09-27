using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class IndexModel : PageModel
{
    public List<string> Products { get; set; } = new List<string>(); // Inicializa a lista de produtos

    [BindProperty]
    public string NewProduct { get; set; }

    public void OnGet()
    {
        // Este método é chamado quando a página é acessada pela primeira vez
    }

    public IActionResult OnPost()
    {
        if (!string.IsNullOrWhiteSpace(NewProduct))
        {
            Products.Add(NewProduct); // Adiciona o novo produto à lista
        }
        
        NewProduct = string.Empty; // Limpa o campo de entrada
        return Page(); // Retorna a mesma página
    }
}
