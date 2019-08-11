using SnookerTrainingCore.ApplicationService.AppModels.Templates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppServicos.Interfaces.Templates
{
    public interface ITreinoTemplateAppServico
    {
        TreinoTemplateViewModel ObterPorId(int id);
        IEnumerable<TreinoTemplateViewModel> ObterTodos();
    }
}
