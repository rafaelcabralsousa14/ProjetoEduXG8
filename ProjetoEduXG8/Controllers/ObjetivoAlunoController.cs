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
    public class ObjetivoAlunoController : ControllerBase
    {
        private readonly iObjetivoAluno _objetivoalunoRepository;

        public ObjetivoAlunoController()
        {
            _objetivoalunoRepository = new ObjetivoAlunoRepository();
        }

        [HttpGet]
        public List<ObjetivoAluno> Get()
        {
            try
            {
                return _objetivoalunoRepository.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        [HttpGet("{id}")]
        public ObjetivoAluno Get(Guid id)
        {
            try
            {
                return _objetivoalunoRepository.BuscarPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public void Post(ObjetivoAluno objetivoaluno)
        {
            try
            {
                _objetivoalunoRepository.Cadastrar(objetivoaluno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        [HttpPut("{id}")]
        public void Put(Guid id, ObjetivoAluno objetivoaluno)
        {
            try
            {
                objetivoaluno.IdObjetivoAluno = id;
                _objetivoalunoRepository.Alterar(objetivoaluno);
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
                _objetivoalunoRepository.Excluir(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
