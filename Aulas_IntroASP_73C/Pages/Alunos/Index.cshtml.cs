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
    public class IndexModel : PageModel
    {
        private readonly Aulas_IntroASP_73C.Data.Aulas_IntroASP_73CContext _context;

        public IndexModel(Aulas_IntroASP_73C.Data.Aulas_IntroASP_73CContext context)
        {
            _context = context;
        }

        public IList<Aluno> Aluno { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Aluno != null)
            {
                Aluno = await _context.Aluno.ToListAsync();
            }
        }
    }
}
