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
    public class ResultadoRepositorio : IResultadoRepositorio
    {
        private readonly SnookerContexto _contexto;

        public ResultadoRepositorio(SnookerContexto contexto)
        {
            _contexto = contexto;           
        }

        public void Adicionar(Resultado obj)
        {
            _contexto.Resultados.Add(obj);
            Salvar();
        }

        public void Atualizar(Resultado obj)
        {
            _contexto.Entry(obj).State = EntityState.Modified;
            Salvar();
        }

        public IEnumerable<Resultado> Buscar(Expression<Func<Resultado, bool>> predicate)
        {
            return _contexto.Resultados.Where(predicate).AsNoTracking();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public Resultado ObterPorId(int id)
        {
            return _contexto.Resultados.Where(x => x.IdResultado == id).FirstOrDefault();
        }

        public IEnumerable<Resultado> ObterTodos()
        {
            return _contexto.Resultados.AsNoTracking();
        }

        public void Remover(Resultado obj)
        {
            _contexto.Resultados.Remove(obj);
            Salvar();
        }

        public void Salvar()
        {
            _contexto.SaveChanges();
        }
    }
}
