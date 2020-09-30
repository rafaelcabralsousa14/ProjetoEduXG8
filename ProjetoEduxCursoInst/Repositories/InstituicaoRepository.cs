using ProjetoEduXG8.Context;
using ProjetoEduXG8.Domains;
using ProjetoEduXG8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXG8.Repositories
{
    public class InstituicaoRepository : iInstituicao
    {
        private readonly EduXContext _ctx;
        public InstituicaoRepository()
        {
            _ctx = new EduXContext();
        }

        public void Alterar(Instituicao a)
        {
            try
            {
                Instituicao instituicaTemp = BuscarPorID(a.IdInstituicao);

                if (instituicaTemp == null)
                    throw new Exception("Instituição não encontrada");

                instituicaTemp.Nome = a.Nome;
                instituicaTemp.Logradouro = a.Logradouro;
                instituicaTemp.Numero = a.Numero;
                instituicaTemp.Complemento = a.Complemento;
                instituicaTemp.Bairro = a.Bairro;
                instituicaTemp.Cidade = a.Cidade;
                instituicaTemp.UF = a.UF;
                instituicaTemp.CEP = a.CEP;

                _ctx.Instituicoes.Update(instituicaTemp);
                _ctx.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Instituicao BuscarPorID(Guid id)
        {
            try
            {
                return _ctx.Instituicoes.FirstOrDefault(c => c.IdInstituicao == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Instituicao Cadastrar(Instituicao a)
        {
            try
            {
                _ctx.Instituicoes.Add(a);
                _ctx.SaveChanges();
                return a;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Excluir(Guid id)
        {
            try
            {
                Instituicao instituicaTemp = BuscarPorID(id);

                if (instituicaTemp == null)
                    throw new Exception("Instituição não encontrada");

                _ctx.Instituicoes.Remove(instituicaTemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Instituicao> ListarTodos()
        {
            try
            {
                return _ctx.Instituicoes.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
