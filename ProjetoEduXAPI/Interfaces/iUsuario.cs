using ProjetoEduXAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXAPI.Interfaces
{
    interface iUsuario
    {
        List<Usuario> ListarTodos();
        Usuario BuscarPorID(Guid id);
        Usuario Cadastrar(Usuario a);
        void Alterar(Usuario a);
        void Excluir(Guid id);
    }
}
