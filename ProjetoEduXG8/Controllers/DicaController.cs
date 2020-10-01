using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoEduXG8.Domains;
using ProjetoEduXG8.Interfaces;
using ProjetoEduXG8.Repositories;
using ProjetoEduXG8.Utils;

namespace ProjetoEduXG8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DicaController : ControllerBase
    {
        private readonly iDica _dicaRepository;

        public DicaController()
        {
            _dicaRepository = new DicaRepository();
        }

        [HttpGet]
        public List<Dica> Get()
        {
            try
            {
                return _dicaRepository.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        [HttpGet("{id}")]
        public Dica Get(Guid id)
        {
            try
            {
                return _dicaRepository.BuscarPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public void Post([FromForm] Dica dica)
        {
            try
            {
                if(dica.Imagem != null)
                {
                    var urlImagem = Upload.Local(dica.Imagem);

                    dica.UrlImagem = urlImagem;
                }

                _dicaRepository.Cadastrar(dica);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        [HttpPut("{id}")]
        public void Put(Guid id, Dica dica)
        {
            try
            {
                dica.IdDica = id;
                _dicaRepository.Alterar(dica);
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
                _dicaRepository.Excluir(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
