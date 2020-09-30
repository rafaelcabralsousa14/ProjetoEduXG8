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
        public class TurmasController : ControllerBase
        {
            private readonly ITurma _turmaRepository;

            public TurmasController()
            {
                _turmaRepository = new TurmaRepository();
            }
        [HttpGet("{Id}")]
        public IActionResult Get(Guid Id)
        {
            try
            {

                Turma turma = _turmaRepository.BuscarPorId(Id);


                if (turma == null)
                    return NotFound();

                return Ok(turma);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromForm] Turma turma)
        {
            try
            {

                _turmaRepository.Adicionar(turma);

                return Ok(turma);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        [HttpPut("{id}")]
        public IActionResult Put(Guid Id, Turma turma)
        {
            try
            {
                var Turma = _turmaRepository.BuscarPorId(Id);

                if (Turma == null)
                    return NotFound();

                turma.IdTurma = Id;
                _turmaRepository.Editar(turma);

                return Ok(turma);
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
                _turmaRepository.Remover(Id);
                return Ok(Id);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
