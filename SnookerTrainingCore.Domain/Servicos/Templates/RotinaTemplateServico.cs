using SnookerTrainingCore.Domain.Entidades.Templates;
using SnookerTrainingCore.Domain.Repositorios.Interfaces;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.Servicos.Templates
{
    public class RotinaTemplateServico : IRotinaTemplateServico
    {
        private readonly IRotinaTemplateRepositorio _rotinaTemplateRepositorio;

        public RotinaTemplateServico(IRotinaTemplateRepositorio rotinaTemplateRepositorio)
        {
            _rotinaTemplateRepositorio = rotinaTemplateRepositorio;
        }

        public void Adicionar(RotinaTemplate rotina)
        {
            _rotinaTemplateRepositorio.Adicionar(rotina);
        }

        public void Atualizar(RotinaTemplate rotina)
        {
            _rotinaTemplateRepositorio.Atualizar(rotina);
        }

        public RotinaTemplate ObterPorId(int id)
        {
            return _rotinaTemplateRepositorio.ObterPorId(id);
        }

        public IEnumerable<RotinaTemplate> ObterTodas()
        {
            return _rotinaTemplateRepositorio.ObterTodos();
        }

        public void Remover(RotinaTemplate rotina)
        {
            _rotinaTemplateRepositorio.Remover(rotina);
        }
    }
}
