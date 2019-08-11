using SnookerTrainingCore.Domain.Entidades.Templates;
using SnookerTrainingCore.Domain.Repositorios.Interfaces;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.Servicos.Templates
{
    public class TreinoTemplateServico : ITreinoTemplateServico
    {
        private readonly ITreinoTemplateRepositorio _treinoTemplateRepositorio;

        public TreinoTemplateServico(ITreinoTemplateRepositorio treinoTemplateRepositorio)
        {
            _treinoTemplateRepositorio = treinoTemplateRepositorio;
        }

        public void Adicionar(TreinoTemplate treino)
        {
            _treinoTemplateRepositorio.Adicionar(treino);
        }

        public void Atualizar(TreinoTemplate treino)
        {
            _treinoTemplateRepositorio.Atualizar(treino);
        }

        public TreinoTemplate ObterPorId(int id)
        {
            return _treinoTemplateRepositorio.ObterPorId(id);
        }

        public IEnumerable<TreinoTemplate> ObterTodas()
        {
            return _treinoTemplateRepositorio.ObterTodos();
        }

        public void Remover(TreinoTemplate treino)
        {
            _treinoTemplateRepositorio.Remover(treino);
        }
    }
}
