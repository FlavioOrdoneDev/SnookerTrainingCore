using SnookerTrainingCore.ApplicationService.AppModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppServicos.Interfaces
{
    public interface IRotinaAppServico
    {
        RotinaViewModel ObterPorId(int id);
    }
}
