using Microsoft.EntityFrameworkCore;
using ProjetoEduXG8.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXG8.Contexts
{
    public class PerfilContext : DbContext
    {
        public DbSet<Perfil> Perfils { get; set; }
        public DbSet<Objetivo> Objetivos { get; set; }
        public DbSet<Curtida> Curtidas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=AMARALSILVANOVO\SQLEXPRESS;User ID=sa;Password=sa132");


            base.OnConfiguring(optionsBuilder);
        }
    }
}
