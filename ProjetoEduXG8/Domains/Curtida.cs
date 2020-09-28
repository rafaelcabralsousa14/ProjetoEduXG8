using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXG8.Domains
{
    public class Curtida
    {
        [Key]
        
        public Guid IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        //public Guid IdDica { get; set; }
        //[ForeignKey("IdDica")]
        //public string Dica { get; set; }
        
        public Guid IdCurtida { get; set; }



        public Curtida()
        {
            IdUsuario = Guid.NewGuid();
            //IdDica = Guid.NewGuid();
            IdCurtida = Guid.NewGuid();

        }

        
    }
} 
