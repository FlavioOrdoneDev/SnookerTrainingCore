using SnookerTrainingCore.ApplicationService.AppModels;
using SnookerTrainingCore.ApplicationService.AppServicos.Interfaces;
using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppServicos
{
    public class PontuacaoAppServico : IPontuacaoAppServico
    {
        private readonly IPontuacaoServico _pontuacaoServico;

        public PontuacaoAppServico(IPontuacaoServico pontuacaoServico)
        {
            _pontuacaoServico = pontuacaoServico;
        }

        public void Adicionar(Pontuacao pontuacao)
        {
            _pontuacaoServico.Adicionar(pontuacao);
        }

        public void Atualizar(Pontuacao pontuacao)
        {
            _pontuacaoServico.Atualizar(pontuacao);
        }

        public void Remover(Pontuacao pontuacao)
        {
            _pontuacaoServico.Remover(pontuacao);
        }

        public PontuacaoViewModel ObterPorId(int id)
        {
            var pontuacao = _pontuacaoServico.ObterPorId(id);

            var pontuacaoViewModel = new PontuacaoViewModel
            {
                IdPontuacao = pontuacao.IdPontuacao,
                MatouTodasAsBolas = pontuacao.MatouTodasAsBolas,
                Pontos = pontuacao.Pontos
            };

            return pontuacaoViewModel;
        }

        public RotinaViewModel ObterRotina(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PontuacaoViewModel> ObterTodas()
        {
            var pontuacoes = _pontuacaoServico.ObterTodos();

            var pontuacoesViewModel = new List<PontuacaoViewModel>();

            foreach (var pontuacao in pontuacoes)
            {
                pontuacoesViewModel.Add(new PontuacaoViewModel
                {
                    IdPontuacao = pontuacao.IdPontuacao,
                    MatouTodasAsBolas = pontuacao.MatouTodasAsBolas,
                    Pontos = pontuacao.Pontos
                    
                });
            }

            return pontuacoesViewModel;
        }
    }
}
