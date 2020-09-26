using ProjetoEduXG8.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXG8.Interfaces
{
    public interface IPerfil
    {
        List<Perfil> Listar();
        List<Perfil> BuscarPorNome(string nome);
        Perfil BuscarPorId(Guid id);
        void Adicionar(Perfil perfil);
        void Editar(Perfil perfil);
        void Remover(Guid id);
    }
}
