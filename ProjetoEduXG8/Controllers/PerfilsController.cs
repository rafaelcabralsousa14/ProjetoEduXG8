using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoEduXG8.Domains;
using ProjetoEduXG8.Interfaces;
using ProjetoEduXG8.Repository;

namespace ProjetoEduXG8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilsController : ControllerBase
    {
        private readonly IPerfil _perfilRepository;

        public PerfilsController()
        {
            _perfilRepository = new PerfilRepository();
        }

        [HttpGet]
        public List<Perfil> Get()
        {
            return _perfilRepository.Listar();
        }

        [HttpGet("{id}")]
        public Perfil Get(Guid id)
        {
            return _perfilRepository.BuscarPorId(id);
        }

        [HttpPost]
        public void Post(Perfil perfil)
        {
            _perfilRepository.Adicionar(perfil);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, Perfil perfil)
        {
            perfil.IdPerfil = id;
            _perfilRepository.Editar(perfil);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _perfilRepository.Remover(id);
        }


    }
}
