using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoEduXG8.Domains;
using ProjetoEduXG8.Interfaces;
using ProjetoEduXG8.Repositories;

namespace ProjetoEduXG8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly iCurso _cursoRepository;

        public CursoController()
        {
            _cursoRepository = new CursoRepository();
        }

        [HttpGet]
        public List<Curso> Get()
        {
            return _cursoRepository.ListarTodos();
        }

        [HttpGet("{id}")]
        public Curso Get(Guid id)
        {
            return _cursoRepository.BuscarPorID(id);
        }

        [HttpPost]
        public Curso Post(Curso a)
        {
            return _cursoRepository.Cadastrar(a);
        }   

        [HttpPut("{id}")]
        public void Put(Guid id, Curso a)
        {
            a.IdCurso = id;
            _cursoRepository.Alterar(a);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _cursoRepository.Excluir(id);
        }
    }
}

