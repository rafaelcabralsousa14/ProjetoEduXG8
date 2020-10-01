using ProjetoEduXG8.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXG8.Interfaces
{
    interface iObjetivoAluno
    {
        List<ObjetivoAluno> Listar();
        ObjetivoAluno BuscarPorId(Guid Id);
        void Cadastrar(ObjetivoAluno objetivoaluno);
        void Alterar(ObjetivoAluno objetivoaluno);
        void Excluir(Guid Id);
    }
}
