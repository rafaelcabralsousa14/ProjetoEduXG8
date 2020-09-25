using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXG8.Domains
{
    public class Perfil
    {
        public Guid IdPerfil  { get; set; }
        public string Permissao { get; set; }

        public Perfil()
        {
            IdPerfil = Guid.NewGuid();
        }
    }
}
