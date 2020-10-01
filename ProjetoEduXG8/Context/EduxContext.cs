using Microsoft.EntityFrameworkCore;
using ProjetoEduXG8.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXG8.Context
{
    public class EduxContext : DbContext
    {
        public DbSet<ObjetivoAluno> ObjetivosAlunos { get; set; }
        public DbSet<Dica> Dicas { get; set; }
    }
}
