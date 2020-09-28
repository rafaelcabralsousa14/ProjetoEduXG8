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
    public class ObjetivosController : ControllerBase
    {
        private readonly IObjetivo _objetivoRepository;

        public ObjetivosController()
        {
            _objetivoRepository = new ObjetivoRepository();
        }

        [HttpGet]
        public List<Objetivo> Get()
        {
            return _objetivoRepository.Listar();
        }

        [HttpGet("{id}")]
        public Objetivo Get(Guid id)
        {
            return _objetivoRepository.BuscarPorId(id);
        }

        [HttpPost]
        public void Post(Objetivo objetivo)
        {
            _objetivoRepository.Adicionar(objetivo);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, Objetivo objetivo)
        {
            objetivo.IdObjetivo = id;
            _objetivoRepository.Editar(objetivo);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _objetivoRepository.Remover(id);
        }
    }
}
