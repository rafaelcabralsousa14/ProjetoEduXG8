using ProjetoEduXG8.Context;
using ProjetoEduXG8.Domains;
using ProjetoEduXG8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXG8.Repositories
{
    public class DicaRepository : iDica
    {
        private readonly EduxContext _ctx;

        public DicaRepository()
        {
            _ctx = new EduxContext();
        }

        public void Alterar(Dica dica)
        {
            try
            {
                Dica dicaTemp = BuscarPorId(dica.IdDica);

                if (dicaTemp == null)
                    throw new Exception("Dica não encontrada");

                dicaTemp.Texto = dica.Texto;
                dicaTemp.Imagem = dica.Imagem;
                dicaTemp.UrlImagem = dica.UrlImagem;


                _ctx.Dicas.Update(dicaTemp);
                _ctx.SaveChanges();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Cadastrar(Dica dica)
        {
            try
            {
                _ctx.Dicas.Add(dica);
                _ctx.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dica BuscarPorId(Guid id)
        {
            try
            {

                Dica dica = _ctx.Dicas.Find(id);

                return dica;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Dica> Listar()
        {
            try
            {
                return _ctx.Dicas.ToList();
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
                Dica dicaTemp = BuscarPorId(id);

                if (dicaTemp == null)
                    throw new Exception("Dica não encontrada");

                _ctx.Dicas.Remove(dicaTemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
