using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Entidades.Templates;
using System.Collections.Generic;

namespace SnookerTrainingCore.Domain.Repositorios.Interfaces
{
    public interface ICategoriaRepositorio : IRepositorio<Categoria>
    {
        IEnumerable<RotinaTemplate> ObterRotinas(int id);
    }
}
