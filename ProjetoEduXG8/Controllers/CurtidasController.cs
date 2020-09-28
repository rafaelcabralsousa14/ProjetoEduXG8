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
    public class CurtidasController : ControllerBase
    {
        private readonly ICurtida _curtidaRepository;

        public CurtidasController()
        {
            _curtidaRepository = new CurtidaRepository();
        }

        [HttpGet]
        public List<Curtida> Get()
        {
            return _curtidaRepository.Listar();
        }

        [HttpGet("{id}")]
        public Curtida Get(Guid id)
        {
            return _curtidaRepository.BuscarPorId(id);
        }

        [HttpPost]
        public void Post(Curtida curtida)
        {
            _curtidaRepository.Adicionar(curtida);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _curtidaRepository.Remover(id);
        }
    }
}
