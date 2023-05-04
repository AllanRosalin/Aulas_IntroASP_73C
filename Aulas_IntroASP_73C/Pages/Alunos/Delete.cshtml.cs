using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Aulas_IntroASP_73C.Data;
using Aulas_IntroASP_73C.Models;

namespace Aulas_IntroASP_73C.Pages.Alunos
{
    public class DeleteModel : PageModel
    {
        private readonly Aulas_IntroASP_73C.Data.Aulas_IntroASP_73CContext _context;

        public DeleteModel(Aulas_IntroASP_73C.Data.Aulas_IntroASP_73CContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Aluno Aluno { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Aluno == null)
            {
                return NotFound();
            }

            var aluno = await _context.Aluno.FirstOrDefaultAsync(m => m.ID == id);

            if (aluno == null)
            {
                return NotFound();
            }
            else 
            {
                Aluno = aluno;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Aluno == null)
            {
                return NotFound();
            }
            var aluno = await _context.Aluno.FindAsync(id);

            if (aluno != null)
            {
                Aluno = aluno;
                _context.Aluno.Remove(Aluno);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
