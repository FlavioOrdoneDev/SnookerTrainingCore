using Microsoft.EntityFrameworkCore;
using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Repositorios.Interfaces;
using SnookerTrainingCore.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SnookerTrainingCore.Infra.Repositorios
{
    public class TreinoRepositorio : ITreinoRepositorio
    {
        private readonly SnookerContexto _contexto;

        public TreinoRepositorio(SnookerContexto contexto)
        {
            _contexto = contexto;
        }
        public void Adicionar(Treino obj)
        {
            _contexto.Treinos.Add(obj);
            Salvar();
        }

        public void Atualizar(Treino obj)
        {
            _contexto.Entry(obj).State = EntityState.Modified;
            Salvar();
        }

        public IEnumerable<Treino> Buscar(Expression<Func<Treino, bool>> predicate)
        {
            return _contexto.Treinos.Where(predicate).AsNoTracking();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Treino ObterPorId(int id)
        {
            return _contexto.Treinos.Where(x => x.IdTreino == id).FirstOrDefault();
        }

        public IEnumerable<Treino> ObterTodos()
        {
            return _contexto.Treinos.AsNoTracking();
        }

        public void Remover(Treino obj)
        {
            _contexto.Treinos.Remove(obj);
            Salvar();
        }

        public void Salvar()
        {
            _contexto.SaveChanges();
        }
    }
}
