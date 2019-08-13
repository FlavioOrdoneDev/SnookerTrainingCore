using SnookerTrainingCore.ApplicationService.AppModels.Templates;
using SnookerTrainingCore.Domain.Entidades.Templates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppServicos.Interfaces.Templates
{
    public interface ITreinoTemplateAppServico
    {
        void Adicionar(TreinoTemplate treino);
        void Atualizar(TreinoTemplate treino);
        void Remover(TreinoTemplate treino);
        TreinoTemplateViewModel ObterPorId(int id);
        IEnumerable<TreinoTemplateViewModel> ObterTodos();
        
    }
}
