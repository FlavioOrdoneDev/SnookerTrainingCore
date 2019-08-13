using SnookerTrainingCore.ApplicationService.AppModels.Templates;
using SnookerTrainingCore.ApplicationService.AppServicos.Interfaces.Templates;
using SnookerTrainingCore.Domain.Entidades.Templates;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppServicos.Templates
{
    public class TreinoTemplateAppServico : ITreinoTemplateAppServico
    {
        private readonly ITreinoTemplateServico _treinoTemplateServico;
        public TreinoTemplateAppServico(ITreinoTemplateServico treinoTemplateServico)
        {
            _treinoTemplateServico = treinoTemplateServico;
        }

        public void Adicionar(TreinoTemplate treino)
        {
            _treinoTemplateServico.Adicionar(treino);
        }

        public void Atualizar(TreinoTemplate treino)
        {
            _treinoTemplateServico.Atualizar(treino);
        }

        public void Remover(TreinoTemplate treino)
        {
            _treinoTemplateServico.Remover(treino);
        }

        public TreinoTemplateViewModel ObterPorId(int id)
        {
            var treino = _treinoTemplateServico.ObterPorId(id);

            var treinoTemplateViewModel = new TreinoTemplateViewModel
            {
                IdTreino = treino.IdTreino,
                Nome = treino.Nome,
                Descricao = treino.Descricao
            };

            return treinoTemplateViewModel;

        }

        public IEnumerable<TreinoTemplateViewModel> ObterTodos()
        {
            var treinos = _treinoTemplateServico.ObterTodas();

            var treinosViewModel = new List<TreinoTemplateViewModel>();

            foreach (var treino in treinos)
            {
                treinosViewModel.Add(new TreinoTemplateViewModel
                {
                    IdTreino = treino.IdTreino,
                    Nome = treino.Nome,
                    Descricao = treino.Descricao                    
                });
            }

            return treinosViewModel;
        }        
    }
}
