using ProjetoEduXG8.Context;
using ProjetoEduXG8.Domains;
using ProjetoEduXG8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXG8.Repositories
{
    public class CursoRepository : iCurso
    {
        private readonly EduXContext _ctx;
        public CursoRepository()
        {
            _ctx = new EduXContext();
        }

        public void Alterar(Curso a)
        {
            try
            {
                Curso cursoTemp = BuscarPorID(a.IdCurso);

                if (cursoTemp == null)
                    throw new Exception("Curso não encontrado");

                cursoTemp.Titulo = a.Titulo;


                _ctx.Cursos.Update(cursoTemp);
                _ctx.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Curso BuscarPorID(Guid id)
        {
            try
            {
                return _ctx.Cursos.FirstOrDefault(c => c.IdCurso == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Curso Cadastrar(Curso a)
        {
            try
            {
                _ctx.Cursos.Add(a);
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
                Curso cursoTemp = BuscarPorID(id);

                if (cursoTemp == null)
                    throw new Exception("Curso não encontrado");

                _ctx.Cursos.Remove(cursoTemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Curso> ListarTodos()
        {
            try
            {
                return _ctx.Cursos.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
