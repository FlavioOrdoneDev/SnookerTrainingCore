using SnookerTrainingCore.ApplicationService.AppModels;
using SnookerTrainingCore.Domain.DomainModels.RotinaModels;
using SnookerTrainingCore.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppServicos.Interfaces
{
    public interface IRotinaAppServico
    {
        RotinaViewModel ObterPorId(int id);
        void Adicionar(Rotina rotina);
        void Atualizar(Rotina rotina);
        IEnumerable<RotinaViewModel> ObterTodas();
        IEnumerable<Pontuacao> ObterPontuacao(int id);
        void Remover(Rotina rotina);
        RotinaModel ObterResultadoDaRotina(int id);

    }
}
