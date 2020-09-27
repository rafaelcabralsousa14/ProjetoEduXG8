using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoEduXAPI.Domains;
using ProjetoEduXAPI.Interfaces;
using ProjetoEduXAPI.Repositories;

namespace ProjetoEduXAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly iCategoria _categoriaRepository;

        public CategoriaController()
        {
            _categoriaRepository = new CategoriaRepository();
        }

        [HttpGet]
        public List<Categoria> Get()
        {
            return _categoriaRepository.ListarTodos();
        }

        [HttpGet("{id}")]
        public Categoria Get(Guid id)
        {
            return _categoriaRepository.BuscarPorID(id);
        }

        [HttpPost]
        public Categoria Post(Categoria a)
        {
            return _categoriaRepository.Cadastrar(a);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, Categoria a)
        {
            a.IdCategoria = id;
            _categoriaRepository.Alterar(a);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _categoriaRepository.Excluir(id);
        }
    }
}
