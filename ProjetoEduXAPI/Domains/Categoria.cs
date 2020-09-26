﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXAPI.Domains
{
    public class Categoria
    {
        [Key]
        public Guid IdCategoria { get; set; }
        public string Tipo { get; set; }
    }
}
