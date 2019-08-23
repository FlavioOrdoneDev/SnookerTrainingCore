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
    public class PontuacaoRepositorio : IPontuacaoRepositorio
    {
        private readonly SnookerContexto _contexto;

        public PontuacaoRepositorio(SnookerContexto contexto)
        {
            _contexto = contexto;
        }
        public void Adicionar(Pontuacao pontuacao)
        {
            _contexto.Pontuacoes.Add(pontuacao);
            Salvar();
        }

        public void AdicionarTodos(IEnumerable<Pontuacao> pontuacao)
        {
            foreach (var entity in pontuacao)
                Adicionar(entity);
        }

        public void Atualizar(Pontuacao pontuacao)
        {
            _contexto.Entry(pontuacao).State = EntityState.Modified;
            Salvar();
        }

        public IEnumerable<Pontuacao> Buscar(Expression<Func<Pontuacao, bool>> predicate)
        {
            return _contexto.Pontuacoes.Where(predicate).AsNoTracking();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public Pontuacao ObterPorId(int id)
        {
            return _contexto.Pontuacoes.Where(x => x.IdPontuacao == id).FirstOrDefault();
        }

        public IEnumerable<Pontuacao> ObterTodos()
        {
            return _contexto.Pontuacoes.AsNoTracking();
        }

        public void Remover(Pontuacao pontuacao)
        {
            _contexto.Pontuacoes.Remove(pontuacao);
            Salvar();
        }

        public void Salvar()
        {
            _contexto.SaveChanges();
        }
    }
}
