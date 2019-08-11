using SnookerTrainingCore.Domain.DomainModels.ResultadoModels;
using SnookerTrainingCore.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.Servicos.Interfaces
{
    public interface IResultadoServico
    {
        ResultadoTreinoModel GerarResultado(Resultado resultado, Treino treino, DateTime data);
        void Adicionar(Resultado resultado);
        void Atualizar(Resultado resultado);
        Resultado ObterPorId(int id);
        IEnumerable<Resultado> ObterTodas();        
        void Remover(Resultado resultado);
    }
}
