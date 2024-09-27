using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class UserFormModel : PageModel
{
    [BindProperty]
    [Required(ErrorMessage = "O nome é obrigatório.")]
    public string Name { get; set; }

    [BindProperty]
    [Required(ErrorMessage = "O e-mail é obrigatório.")]
    [EmailAddress(ErrorMessage = "Formato de e-mail inválido.")]
    public string Email { get; set; }

    [BindProperty]
    [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento")]
    [CustomDateAttribute(ErrorMessage = "A data de nascimento não pode ser no futuro.")]
    public DateTime BirthDate { get; set; }

    public void OnGet()
    {
        // Este método é chamado quando a página é acessada pela primeira vez
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page(); // Retorna a página com erros de validação
        }

        // Aqui você pode adicionar lógica para salvar os dados
        // Exemplo: salvar em um banco de dados ou arquivo

        // Redirecionar ou retornar uma mensagem de sucesso
        return RedirectToPage("Success"); // Substitua por sua página de sucesso
    }
}

public class CustomDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime dateTime && dateTime > DateTime.Now)
        {
            return new ValidationResult(ErrorMessage);
        }

        return ValidationResult.Success;
    }
}
