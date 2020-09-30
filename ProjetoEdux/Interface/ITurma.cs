using ProjetoEduxG8.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduxG8.Interface
{
    interface ITurma
    {
        List<Turma> Listar();
        Turma BuscarPorId(Guid id);
        void Adicionar(Turma Turma);
        void Remover(Guid id);
        void Editar(Turma turma);
    }
}
