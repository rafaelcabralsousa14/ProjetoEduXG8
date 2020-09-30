using ProjetoEduxG8.Contexts;
using ProjetoEduxG8.Domains;
using ProjetoEduxG8.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduxG8.Repositories
{
  
        public class TurmaRepository : ITurma
        {
            private readonly EduxContext _ctx;

            public TurmaRepository()
            {
                _ctx = new EduxContext();
            }

            public void Adicionar(Turma turma)
            {
                try
                {
                    _ctx.Turmas.Add(turma);
                    _ctx.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            public Turma BuscarPorId(Guid id)
            {
                try
                {
                    Turma turma = _ctx.Turmas.Find(id);

                    return turma;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public List<Turma> Listar()
            {
                try
                {
                    List<Turma> turmas = _ctx.Turmas.ToList();

                    return turmas;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public void Remover(Guid id)
            {
                try
                {
                    Turma turma = BuscarPorId(id);

                    if (turma == null)
                        throw new Exception("Turma não encontrada");

                    _ctx.Turmas.Remove(turma);
                    _ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

          

         }
    
 }
