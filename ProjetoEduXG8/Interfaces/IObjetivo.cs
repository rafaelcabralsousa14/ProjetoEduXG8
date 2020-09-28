using ProjetoEduXG8.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXG8.Interfaces
{
    interface IObjetivo
    {
        List<Objetivo> Listar();
        Objetivo BuscarPorId(Guid id);
        void Adicionar(Objetivo objetivo);
        void Editar(Objetivo objetivo);
        void Remover(Guid id);
    }
}
