using SnookerTrainingCore.ApplicationService.AppModels.Templates;
using SnookerTrainingCore.Domain.Entidades.Templates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppServicos.Interfaces.Templates
{
    public interface IRotinaTemplateAppServico
    {
        void Adicionar(RotinaTemplate rotina);
        void Atualizar(RotinaTemplate rotina);
        RotinaTemplateViewModel ObterPorId(int id);
        IEnumerable<RotinaTemplateViewModel> ObterTodas();
        void Remover(RotinaTemplate rotina);
    }
}
