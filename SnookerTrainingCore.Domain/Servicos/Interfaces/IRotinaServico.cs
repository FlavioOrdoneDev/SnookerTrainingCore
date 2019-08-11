using SnookerTrainingCore.Domain.DomainModels.RotinaModels;
using SnookerTrainingCore.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.Servicos.Interfaces
{
    public interface IRotinaServico
    {
        void Adicionar(Rotina rotina);
        void Atualizar(Rotina rotina);
        Rotina ObterPorId(int id);
        IEnumerable<Rotina> ObterTodas();
        IEnumerable<Pontuacao> ObterPontuacao(int id);
        void Remover(Rotina rotina);
        RotinaModel ObterResultadoDaRotina(int id);                
    }
}