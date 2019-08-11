using SnookerTrainingCore.Domain.DomainModels.RotinaModels;
using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Entidades.Templates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.Servicos.Interfaces
{
    public interface IRotinaTemplateServico
    {
        void Adicionar(RotinaTemplate rotina);
        void Atualizar(RotinaTemplate rotina);
        RotinaTemplate ObterPorId(int id);
        IEnumerable<RotinaTemplate> ObterTodas();
        void Remover(RotinaTemplate rotina);             
    }
}