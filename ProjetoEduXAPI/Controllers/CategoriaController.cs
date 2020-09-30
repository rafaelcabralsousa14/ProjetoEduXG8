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
            try
            {
                return _categoriaRepository.ListarTodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        [HttpGet("{id}")]
        public Categoria Get(Guid id)
        {
            try
            {
                return _categoriaRepository.BuscarPorID(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public Categoria Post(Categoria a)
        {
            try
            {
                return _categoriaRepository.Cadastrar(a);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        [HttpPut("{id}")]
        public void Put(Guid id, Categoria a)
        {
            try
            {
                a.IdCategoria = id;
                _categoriaRepository.Alterar(a);
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
                _categoriaRepository.Excluir(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
