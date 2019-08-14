using SnookerTrainingCore.ApplicationService.AppModels;
using SnookerTrainingCore.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppServicos.Interfaces
{
    public interface IPontuacaoAppServico
    {
        void Adicionar(Pontuacao pontuacao);
        void Atualizar(Pontuacao pontuacao);
        void Remover(Pontuacao pontuacao);
        PontuacaoViewModel ObterPorId(int id);
        IEnumerable<PontuacaoViewModel> ObterTodas();
        RotinaViewModel ObterRotina(int id);
    }
}
