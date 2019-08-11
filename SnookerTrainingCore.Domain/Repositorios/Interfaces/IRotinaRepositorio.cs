using SnookerTrainingCore.Domain.Entidades;
using System.Collections.Generic;

namespace SnookerTrainingCore.Domain.Repositorios.Interfaces
{
    public interface IRotinaRepositorio : IRepositorio<Rotina>
    {
        IEnumerable<Pontuacao> ObterPontuacao(int id);
    }
}
