using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Entidades.Templates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.Servicos.Interfaces
{
    public interface ITreinoTemplateServico
    {
        void Adicionar(TreinoTemplate treino);
        void Atualizar(TreinoTemplate treino);
        TreinoTemplate ObterPorId(int id);
        IEnumerable<TreinoTemplate> ObterTodas();
        void Remover(TreinoTemplate treino);
    }
}
