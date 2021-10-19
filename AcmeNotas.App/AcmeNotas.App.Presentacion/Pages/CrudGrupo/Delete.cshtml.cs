using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AcmeNotas.App.Dominio;
using AcmeNotas.App.Persistencia;

namespace AcmeNotas.App.Presentacion.Pages.CrudGrupo
{
    public class DeleteModel : PageModel
    {
        private readonly AcmeNotas.App.Persistencia.Conexion _context;

        public DeleteModel(AcmeNotas.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        [BindProperty]
        public Grupo Grupo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Grupo = await _context.Grupos.FirstOrDefaultAsync(m => m.GrupoId == id);

            if (Grupo == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Grupo = await _context.Grupos.FindAsync(id);

            if (Grupo != null)
            {
                _context.Grupos.Remove(Grupo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
