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
    public class RotinaTemplateRepositorio : IRotinaTemplateRepositorio
    {
        private readonly SnookerContexto _contexto;

        public RotinaTemplateRepositorio(SnookerContexto contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(RotinaTemplate rotina)
        {
            _contexto.RotinasTemplate.Add(rotina);
            Salvar();
        }

        public void Atualizar(RotinaTemplate rotina)
        {
            _contexto.Entry(rotina).State = EntityState.Modified;
            Salvar();
        }

        public IEnumerable<RotinaTemplate> Buscar(Expression<Func<RotinaTemplate, bool>> predicate)
        {
            return _contexto.RotinasTemplate.AsNoTracking().Include(x => x.Categoria).AsNoTracking().Where(predicate).AsNoTracking();
        }        

        public RotinaTemplate ObterPorId(int id)
        {
            return _contexto.RotinasTemplate.Include(x => x.Categoria).Where(x => x.IdRotina == id).FirstOrDefault();
        }

        public IEnumerable<RotinaTemplate> ObterTodos()
        {
            return _contexto.RotinasTemplate.Include(x => x.Categoria).ToList();
        }

        public void Remover(RotinaTemplate rotina)
        {
            _contexto.RotinasTemplate.Remove(rotina);
            Salvar();
        }

        public void Salvar()
        {
            _contexto.SaveChanges();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
