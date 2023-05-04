using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aulas_IntroASP_73C.Models;

namespace Aulas_IntroASP_73C.Data
{
    public class Aulas_IntroASP_73CContext : DbContext
    {
        public Aulas_IntroASP_73CContext (DbContextOptions<Aulas_IntroASP_73CContext> options)
            : base(options)
        {
        }

        public DbSet<Aulas_IntroASP_73C.Models.Aluno> Aluno { get; set; } = default!;
    }
}
