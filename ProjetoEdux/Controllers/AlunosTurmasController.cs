using Microsoft.AspNetCore.Mvc;
using ProjetoEduxG8.Domains;
using ProjetoEduxG8.Interface;
using ProjetoEduxG8.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduxG8.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]
        public class AlunosTurmasController : ControllerBase
        {
            private readonly IAlunoTurma _alunoTurmaRepository;

            public AlunosTurmasController()
            {
                _alunoTurmaRepository = new AlunoTurmaRepository();
            }

                
     
         [HttpGet("{Id}")]
        public IActionResult Get(Guid Id)
        {
            try
            {
               
                AlunoTurma alunoTurma = _alunoTurmaRepository.BuscarPorId(Id);

                
                if (alunoTurma == null)
                    return NotFound();

                return Ok(alunoTurma);
            }
            catch (Exception ex)
            {
               
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromForm] AlunoTurma alunoTurma)
        {
            try
            {
                
                _alunoTurmaRepository.Adicionar(alunoTurma);

                return Ok(alunoTurma);
            }
            catch (Exception ex)
            {
               
                return BadRequest(ex.Message);
            }
        }

        
        [HttpPut("{id}")]
        public IActionResult Put(Guid Id, AlunoTurma alunoTurma)
        {
            try
            {
                var AlunoTurma = _alunoTurmaRepository.BuscarPorId(Id);

                if (AlunoTurma == null)
                    return NotFound();

                alunoTurma.IdAlunoTurma = Id;
                _alunoTurmaRepository.Editar(alunoTurma);

                return Ok(alunoTurma);
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
        }

        
        [HttpDelete("{Id}")]
        public IActionResult Delete(Guid Id)
        {
            try
            {
                _alunoTurmaRepository.Remover(Id);
                return Ok(Id);
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
        }
    }
}


