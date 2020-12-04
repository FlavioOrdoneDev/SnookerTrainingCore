using Microsoft.EntityFrameworkCore;
using SnookerTrainingCore.Domain.Entidades.Templates;
using SnookerTrainingCore.Domain.Repositorios.Interfaces;
using SnookerTrainingCore.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SnookerTrainingCore.Infra.Repositorios.Templates
{
    public class TreinoTemplateRepositorio : ITreinoTemplateRepositorio
    {
        private readonly SnookerContexto _contexto;

        public TreinoTemplateRepositorio(SnookerContexto contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(TreinoTemplate obj)
        {
            _contexto.TreinosTemplate.Add(obj);
            Salvar();
        }

        public void Atualizar(TreinoTemplate obj)
        {
            _contexto.Entry(obj).State = EntityState.Modified;
            Salvar();
        }

        public IEnumerable<TreinoTemplate> Buscar(Expression<Func<TreinoTemplate, bool>> predicate)
        {
            return _contexto.TreinosTemplate.Where(predicate).AsNoTracking();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public TreinoTemplate ObterPorId(int id)
        {
            return _contexto.TreinosTemplate.Where(x => x.IdTreino == id).Include(x => x.RotinasTemplate).FirstOrDefault();
        }

        public IEnumerable<TreinoTemplate> ObterTodos()
        {
            return _contexto.TreinosTemplate.Include(x => x.RotinasTemplate).ToList();
        }

        public void Remover(TreinoTemplate obj)
        {
            _contexto.TreinosTemplate.Remove(obj);
            Salvar();
        }

        public void Salvar()
        {
            _contexto.SaveChanges();
        }
    }
}
