using Microsoft.EntityFrameworkCore;
using ProjetoEduxG8.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduxG8.Contexts
{
    public class EduxContext : DbContext
    {
        internal object professorTurmas;

        public DbSet<Turma> Turmas { get; set; }

        public DbSet<AlunoTurma> AlunosTurmas { get; set; }

        public DbSet<ProfessorTurma> ProfessorTurmas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"data Source=DESKTOP-LJ2FRJ8\SQLEXPRESS;Initial Catalog=ProjetoEdux;User ID=sa;Password=sa132");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
