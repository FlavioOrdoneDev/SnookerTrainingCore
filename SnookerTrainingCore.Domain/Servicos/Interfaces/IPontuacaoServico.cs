using SnookerTrainingCore.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.Servicos.Interfaces
{
    public interface IPontuacaoServico
    {
        void Adicionar(Pontuacao pontuacao);
        void Atualizar(Pontuacao pontuacao);
        Pontuacao ObterPorId(int id);
        IEnumerable<Pontuacao> ObterTodos();
        void Remover(Pontuacao pontuacao);
    }
}
