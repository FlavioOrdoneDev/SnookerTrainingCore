using Microsoft.EntityFrameworkCore;
using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Entidades.Templates;
using SnookerTrainingCore.Domain.Repositorios.Interfaces;
using SnookerTrainingCore.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SnookerTrainingCore.Infra.Repositorios
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly SnookerContexto _contexto;

        public CategoriaRepositorio(SnookerContexto contexto)
        {
            _contexto = contexto;
        }
        public void Adicionar(Categoria obj)
        {
            _contexto.Categorias.Add(obj);
            Salvar();
        }

        public void Atualizar(Categoria obj)
        {
            _contexto.Entry(obj).State = EntityState.Modified;
            Salvar();
        }

        public IEnumerable<Categoria> Buscar(Expression<Func<Categoria, bool>> predicate)
        {
            return _contexto.Categorias.AsNoTracking().Where(predicate);
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public Categoria ObterPorId(int id)
        {
            return _contexto.Categorias.Include(x => x.RotinasTemplate).AsNoTracking().Where(x => x.IdCategoria == id).FirstOrDefault();
        }

        public IEnumerable<Categoria> ObterTodos()
        {
            return _contexto.Categorias.Include(x => x.RotinasTemplate).ToList();
        }

        public IEnumerable<RotinaTemplate> ObterRotinas(int id)
        {
            return _contexto.RotinasTemplate.AsNoTracking().Where(x => x.IdCategoria == id).ToList();
        }

        public void Remover(Categoria obj)
        {
            _contexto.Categorias.Remove(obj);
            Salvar();
        }

        public void Salvar()
        {
            _contexto.SaveChanges();
        }
    }
}
