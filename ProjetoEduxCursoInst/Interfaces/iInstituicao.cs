using ProjetoEduXG8.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXG8.Interfaces
{
    interface iInstituicao
    {
            List<Instituicao> ListarTodos();
            Instituicao BuscarPorID(Guid id);
            Instituicao Cadastrar(Instituicao a);
            void Alterar(Instituicao a);
            void Excluir(Guid id);
    }
}

