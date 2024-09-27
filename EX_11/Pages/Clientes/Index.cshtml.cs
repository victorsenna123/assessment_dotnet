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
    public class IndexModel : PageModel
    {
        private readonly GerenciamentoClientes.Data.ClienteContext _context;

        public IndexModel(GerenciamentoClientes.Data.ClienteContext context)
        {
            _context = context;
        }

        public IList<Cliente> Cliente { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Cliente = await _context.Clientes.ToListAsync();
        }
    }
}
