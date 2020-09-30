using ProjetoEduXG8.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXG8.Interfaces
{
    interface iCurso
    {
        List<Curso> ListarTodos();
        Curso BuscarPorID(Guid id);
        Curso Cadastrar(Curso a);
        void Alterar(Curso a);
        void Excluir(Guid id);
    }
}
