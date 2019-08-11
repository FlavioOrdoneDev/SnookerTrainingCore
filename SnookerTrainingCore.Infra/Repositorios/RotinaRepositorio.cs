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
    public class RotinaRepositorio : IRotinaRepositorio
    {
        private readonly SnookerContexto _contexto;

        public RotinaRepositorio(SnookerContexto contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Rotina rotina)
        {
            _contexto.Rotinas.Add(rotina);
            Salvar();
        }

        public void Atualizar(Rotina rotina)
        {
            _contexto.Entry(rotina).State = EntityState.Modified;
            Salvar();
        }

        public IEnumerable<Rotina> Buscar(Expression<Func<Rotina, bool>> predicate)
        {
            return _contexto.Rotinas.Include(r => r.RotinaTemplate).Where(predicate).AsNoTracking();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public Rotina ObterPorId(int id)
        {
            return _contexto.Rotinas.Include(x => x.Pontos).Include(r => r.RotinaTemplate).Where(x => x.IdRotina == id).FirstOrDefault();
        }

        public IEnumerable<Rotina> ObterTodos()
        {
            return _contexto.Rotinas.Include(x => x.Pontos).AsNoTracking();
        }

        public IEnumerable<Pontuacao> ObterPontuacao(int id)
        {
            return _contexto.Pontuacoes.AsNoTracking().Where(x => x.IdRotina == id).ToList();
        }

        public void Remover(Rotina rotina)
        {
            _contexto.Rotinas.Remove(rotina);
            Salvar();
        }

        public void Salvar()
        {
            _contexto.SaveChanges();
        }
    }
}
