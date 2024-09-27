using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EX_11.Models;
using GerenciamentoClientes.Data;

namespace EX_11.Pages_Clientes
{
    public class DetailsModel : PageModel
    {
        private readonly GerenciamentoClientes.Data.ClienteContext _context;

        public DetailsModel(GerenciamentoClientes.Data.ClienteContext context)
        {
            _context = context;
        }

        public Cliente Cliente { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }
            else
            {
                Cliente = cliente;
            }
            return Page();
        }
    }
}
