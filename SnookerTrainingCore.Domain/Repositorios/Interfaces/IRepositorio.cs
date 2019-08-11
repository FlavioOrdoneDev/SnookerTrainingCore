using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SnookerTrainingCore.Domain.Repositorios.Interfaces
{
    public interface IRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity obj);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity obj);
        void Remover(TEntity obj);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        void Salvar();
    }
}
