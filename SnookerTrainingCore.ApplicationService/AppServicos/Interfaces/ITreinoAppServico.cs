using SnookerTrainingCore.ApplicationService.AppModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppServicos.Interfaces
{
    public interface ITreinoAppServico
    {
        TreinoViewModel ObterPorId(int id);
        IEnumerable<TreinoViewModel> ObterTodos();
    }
}
