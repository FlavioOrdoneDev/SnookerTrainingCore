using SnookerTrainingCore.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.Servicos.Interfaces
{
    public interface ITreinoServico
    {
        void Adicionar(Treino treino);
        void Atualizar(Treino treino);
        Treino ObterPorId(int id);
        IEnumerable<Treino> ObterTodas();
        void Remover(Treino treino);
    }
}
