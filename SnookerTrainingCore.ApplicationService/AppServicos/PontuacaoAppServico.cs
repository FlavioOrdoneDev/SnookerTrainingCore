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

        public PontuacaoViewModel ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public RotinaViewModel ObterRotina(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PontuacaoViewModel> ObterTodas()
        {
            throw new NotImplementedException();
        }

        public void Remover(Pontuacao pontuacao)
        {
            _pontuacaoServico.Remover(pontuacao);
        }
    }
}
