using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXG8.Domains
{
    public class Objetivo
    {
        [Key]
        public Guid IdObjetivo { get; set; }
        public Guid IdCategoria { get; set; }
        [ForeignKey("IdCategoria")]
        public string Descricao { get; set; }

        public Objetivo()
        {
            IdObjetivo = Guid.NewGuid();
            IdCategoria = Guid.NewGuid();
        }

        //tem Fk
    }
}
