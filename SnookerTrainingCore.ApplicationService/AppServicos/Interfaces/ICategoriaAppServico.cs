using SnookerTrainingCore.ApplicationService.AppModels;
using SnookerTrainingCore.ApplicationService.AppModels.Templates;
using SnookerTrainingCore.Domain.Entidades;
using System.Collections.Generic;

namespace SnookerTrainingCore.ApplicationService.AppServicos.Interfaces
{
    public interface ICategoriaAppServico
    {
        void Adicionar(Categoria categoria);
        void Atualizar(Categoria categoria);
        void Remover(Categoria categoria);
        CategoriaViewModel ObterPorId(int id);
        IEnumerable<CategoriaViewModel> ObterTodas();
        IEnumerable<RotinaTemplateViewModel> ObterRotinas(int id);

    }
}
