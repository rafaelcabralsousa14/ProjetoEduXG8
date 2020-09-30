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
    public class ProfessorTurmasController : ControllerBase
    {
        private readonly IProfessorTurma _professorTurmaRepository;

        public ProfessorTurmasController()
        {
            _professorTurmaRepository = new ProfessorTurmaRepository();
        }

        [HttpGet("{Id}")]
        public IActionResult Get(Guid Id)
        {
            try
            {

                ProfessorTurma professorTurma = _professorTurmaRepository.BuscarPorId(Id);


                if (professorTurma == null)
                    return NotFound();

                return Ok(professorTurma);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromForm] ProfessorTurma professorTurma)
        {
            try
            {

                _professorTurmaRepository.Adicionar(professorTurma);

                return Ok(professorTurma);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        [HttpPut("{id}")]
        public IActionResult Put(Guid Id, ProfessorTurma professorTurma)
        {
            try
            {
                var ProfessorTurma = _professorTurmaRepository.BuscarPorId(Id);

                if (ProfessorTurma == null)
                    return NotFound();

                professorTurma.IdProfessorTurma = Id;
                _professorTurmaRepository.Editar(professorTurma);

                return Ok(professorTurma);
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
                _professorTurmaRepository.Remover(Id);
                return Ok(Id);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }

}


