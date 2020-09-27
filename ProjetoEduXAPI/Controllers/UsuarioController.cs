using System;
using System.Collections.Generic;
using System.Linq;
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
            return _usuarioRepository.ListarTodos();
        }

        [HttpGet("{id}")]
        public Usuario Get(Guid id)
        {
            return _usuarioRepository.BuscarPorID(id);
        }

        [HttpPost]
        public Usuario Post(Usuario a)
        {
            a.Senha = Crypto.Criptografar(a.Senha, a.Email.Substring(0,4));
            return _usuarioRepository.Cadastrar(a);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, Usuario a)
        {
            a.Senha = Crypto.Criptografar(a.Senha, a.Email.Substring(0, 4));
            a.IdUsuario = id;
            _usuarioRepository.Alterar(a);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _usuarioRepository.Excluir(id);
        }
    }
}
