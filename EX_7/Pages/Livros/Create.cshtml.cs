using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EX_7.Data;
using EX_7.Models;

namespace EX_7.Pages.Livros
{
    public class CreateModel : PageModel
    {
        private readonly LivroContext _context;

        public CreateModel(LivroContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Livro Livro { get; set; }

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Livros.Add(Livro);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
