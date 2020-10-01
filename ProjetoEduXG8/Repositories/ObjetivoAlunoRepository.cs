using ProjetoEduXG8.Context;
using ProjetoEduXG8.Domains;
using ProjetoEduXG8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXG8.Repositories
{
    public class ObjetivoAlunoRepository : iObjetivoAluno   
    {
            private readonly EduxContext _ctx;

            public ObjetivoAlunoRepository()
            {
                _ctx = new EduxContext();
            }
            public ObjetivoAluno BuscarPorId(Guid id)
            {
                try
                {

                    ObjetivoAluno objetivoaluno = _ctx.ObjetivosAlunos.Find(id);

                    return objetivoaluno;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public void Alterar(ObjetivoAluno objetivoaluno)
            {
                try
                {
                    ObjetivoAluno objetivoalunotemp = BuscarPorId(objetivoaluno.IdObjetivoAluno);

                if (objetivoalunotemp == null)
                    throw new Exception("Objetivo não encontrado");

                objetivoalunotemp.Nota = objetivoaluno.Nota;
                objetivoalunotemp.DataEntrega = objetivoaluno.DataEntrega;

                _ctx.ObjetivosAlunos.Update(objetivoalunotemp);
                _ctx.SaveChanges();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Cadastrar(ObjetivoAluno objetivoaluno)
            {
                try
                {
                    _ctx.ObjetivosAlunos.Add(objetivoaluno);
                    _ctx.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }


            public List<ObjetivoAluno> Listar()
            {
                try
                {
                    return _ctx.ObjetivosAlunos.ToList();
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
                    ObjetivoAluno objetivoaluno = BuscarPorId(id);

                    if (objetivoaluno == null)
                        throw new Exception("Objetivo não encontrado");

                    _ctx.ObjetivosAlunos.Remove(objetivoaluno);
                    _ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
}
