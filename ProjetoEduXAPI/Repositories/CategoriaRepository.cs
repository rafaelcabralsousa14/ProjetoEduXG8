﻿using ProjetoEduXAPI.Context;
using ProjetoEduXAPI.Domains;
using ProjetoEduXAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduXAPI.Repositories
{
    public class CategoriaRepository : iCategoria
    {
        private readonly EduXContext _ctx;
        public CategoriaRepository()
        {
            _ctx = new EduXContext();
        }
            
        public void Alterar(Categoria a)
        {
            try
            {
                Categoria categoriaTemp = BuscarPorID(a.IdCategoria);

                if (categoriaTemp == null)
                    throw new Exception("Categoria não encontrada");

                categoriaTemp.Tipo = a.Tipo;

                _ctx.Categorias.Update(categoriaTemp);
                _ctx.SaveChanges();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Categoria BuscarPorID(Guid id)
        {
            try
            {
                return _ctx.Categorias.FirstOrDefault(c => c.IdCategoria == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Categoria Cadastrar(Categoria a)
        {
           try
           {
                _ctx.Categorias.Add(a);
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
                Categoria categoriaTemp = BuscarPorID(id);

                if (categoriaTemp == null)
                    throw new Exception("Categoria não encontrada");

                _ctx.Categorias.Remove(categoriaTemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Categoria> ListarTodos()
        {
            try
            {
                return _ctx.Categorias.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
