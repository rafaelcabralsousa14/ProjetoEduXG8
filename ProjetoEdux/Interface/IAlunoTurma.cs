using ProjetoEduxG8.Controllers;
using ProjetoEduxG8.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduxG8.Interface
{
    interface IAlunoTurma
    {
        List<AlunoTurma> Listar();
        AlunoTurma BuscarPorId(Guid id);
        void Adicionar( AlunoTurma alunoTurma);
        void Remover(Guid id);
        AlunoTurma Adicionar(List<AlunosTurmasController> alunosTurmas);
        void Editar(AlunoTurma alunoTurma);
    }
}
