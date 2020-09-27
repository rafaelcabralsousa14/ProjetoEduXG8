using ProjetoEduXAPI.Context;
using ProjetoEduXAPI.Domains;
using ProjetoEduXAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXAPI.Repositories
{
    public class UsuarioRepository : iUsuario
    {
        private readonly EduXContext _ctx;
        public UsuarioRepository()
        {
            _ctx = new EduXContext();
        }

        public void Alterar(Usuario a)
        {
            try
            {
                Usuario usuarioTemp = BuscarPorID(a.IdUsuario);

                if (usuarioTemp == null)
                    throw new Exception("Usuário não encontrado");

                usuarioTemp.Nome = a.Nome;
                usuarioTemp.Senha = a.Senha;
                usuarioTemp.Email = a.Email;
                usuarioTemp.DataCadastro = a.DataCadastro;
                usuarioTemp.DataUltimoAcesso = a.DataUltimoAcesso;

                _ctx.Usuarios.Update(usuarioTemp);
                _ctx.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Usuario BuscarPorID(Guid id)
        {
            try
            {
                return _ctx.Usuarios.FirstOrDefault(c => c.IdUsuario == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Usuario Cadastrar(Usuario a)
        {
            try
            {
                _ctx.Usuarios.Add(a);
                _ctx.SaveChanges();
                return a;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Excluir(Guid id)
        {
            try
            {
                Usuario usuarioTemp = BuscarPorID(id);

                if (usuarioTemp == null)
                    throw new Exception("Usuário não encontrado");

                _ctx.Usuarios.Remove(usuarioTemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Usuario> ListarTodos()
        {
            try
            {
                return _ctx.Usuarios.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
