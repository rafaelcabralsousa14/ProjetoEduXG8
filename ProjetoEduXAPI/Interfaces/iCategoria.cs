﻿using ProjetoEduXAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXAPI.Interfaces
{
    interface iCategoria
    {
        List<Categoria> ListarTodos();
        Categoria BuscarPorID(Guid id);
        Categoria Cadastrar(Categoria a);
        void Alterar(Categoria a);
        void Excluir(Guid id);
    }
}
