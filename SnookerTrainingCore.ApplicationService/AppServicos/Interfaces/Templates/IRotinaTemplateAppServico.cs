using SnookerTrainingCore.ApplicationService.AppModels.Templates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppServicos.Interfaces.Templates
{
    public interface IRotinaTemplateAppServico
    {
        RotinaTemplateViewModel ObterPorId(int id);
    }
}
