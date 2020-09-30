using ProjetoEduxG8.Contexts;
using ProjetoEduxG8.Domains;
using ProjetoEduxG8.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduxG8.Repositories
{
   
        public class ProfessorTurmaRepository : IProfessorTurma
        {
            private readonly EduxContext _ctx;

            public ProfessorTurmaRepository()
            {
                _ctx = new EduxContext();
            }

            public void Adicionar(ProfessorTurma professorTurma)
            {
                try
                {
                    _ctx.ProfessorTurmas.Add(professorTurma);
                    _ctx.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }


            public ProfessorTurma BuscarPorId(Guid id)
            {
                try
                {
                    ProfessorTurma professorTurma = _ctx.ProfessorTurmas.Find(id);

                    return professorTurma;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public List<ProfessorTurma> Listar()
            {
                try
                {
                    List<ProfessorTurma> professorTurmas = _ctx.ProfessorTurmas.ToList();

                    return professorTurmas;
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
                    ProfessorTurma professorTurma = BuscarPorId(id);

                    if (professorTurma == null)
                        throw new Exception("Professor não encontrado");

                    _ctx.ProfessorTurmas.Remove(professorTurma);
                    _ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

          
        }
    
}
