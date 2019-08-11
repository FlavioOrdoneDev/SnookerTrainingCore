using SnookerTrainingCore.ApplicationService.AppModels;
using SnookerTrainingCore.ApplicationService.AppModels.Templates;
using System.Collections.Generic;

namespace SnookerTrainingCore.ApplicationService.AppServicos.Interfaces
{
    public interface ICategoriaAppServico
    {
        CategoriaViewModel ObterPorId(int id);
        IEnumerable<CategoriaViewModel> ObterTodas();
        IEnumerable<RotinaTemplateViewModel> ObterRotinas(int id);
    }
}
