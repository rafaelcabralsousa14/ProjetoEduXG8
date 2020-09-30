using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoEduXAPI.Domains;
using ProjetoEduXAPI.Interfaces;
using ProjetoEduXAPI.Repositories;
using ProjetoEduXAPI.Utils;

namespace ProjetoEduXAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly iUsuario _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public List<Usuario> Get()
        {
            try
            {
                return _usuarioRepository.ListarTodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        [HttpGet("{id}")]
        public Usuario Get(Guid id)
        {
            try
            {
                return _usuarioRepository.BuscarPorID(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public Usuario Post(Usuario a)
        {
            try
            {
                a.Senha = Crypto.Criptografar(a.Senha, a.Email.Substring(0,4));
                return _usuarioRepository.Cadastrar(a);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public void Put(Guid id, Usuario a)
        {
            try
            {
                a.Senha = Crypto.Criptografar(a.Senha, a.Email.Substring(0, 4));
                a.IdUsuario = id;
                _usuarioRepository.Alterar(a);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            try
            {
                _usuarioRepository.Excluir(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
