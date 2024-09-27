using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EX_7.Data;  // Atualize isso com o namespace correto do seu projeto
using EX_7.Models; // Atualize isso com o namespace correto dos modelos
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EX_7.Pages.Livros
{
    public class IndexModel : PageModel
    {
        private readonly LivroContext _context;

        public IndexModel(LivroContext context)
        {
            _context = context;
        }

        public IList<Livro> Livros { get; set; }

        public async Task OnGetAsync()
        {
            Livros = await _context.Livros.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var livro = await _context.Livros.FindAsync(id);
            if (livro != null)
            {
                _context.Livros.Remove(livro);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage();
        }
    }
}
