using ProjetoEduxG8.Contexts;
using ProjetoEduxG8.Domains;
using ProjetoEduxG8.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduxG8.Repositories
{
  
     public class AlunoTurmaRepository : IAlunoTurma
        {
            private readonly EduxContext _ctx;

            public AlunoTurmaRepository()
            {
                _ctx = new EduxContext();
            }

            public void Adicionar(AlunoTurma alunoTurma)
            {
                try
                {
                    _ctx.AlunosTurmas.Add(alunoTurma);
                    _ctx.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

    
        public AlunoTurma BuscarPorId(Guid id)
            {
                try
                {
                    AlunoTurma alunosTurmas = _ctx.AlunosTurmas.Find(id);

                    return alunosTurmas;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public List<AlunoTurma> Listar()
            {
                try
                {
                    List<AlunoTurma> alunosTurmas = _ctx.AlunosTurmas.ToList();

                    return alunosTurmas;
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
                    AlunoTurma alunoTurma = BuscarPorId(id);

                    if (alunoTurma == null)
                        throw new Exception("Aluno não encontrado");

                    _ctx.AlunosTurmas.Remove(alunoTurma);
                    _ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

        
    
     }
}
