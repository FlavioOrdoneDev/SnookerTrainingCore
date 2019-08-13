using SnookerTrainingCore.ApplicationService.AppModels;
using SnookerTrainingCore.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppServicos.Interfaces
{
    public interface ITreinoAppServico
    {
        TreinoViewModel ObterPorId(int id);
        IEnumerable<TreinoViewModel> ObterTodos();
        void Adicionar(Treino treino);
        void Atualizar(Treino treino);
        void Remover(Treino treino);


    }
}
