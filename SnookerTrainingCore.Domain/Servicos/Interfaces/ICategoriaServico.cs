using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Entidades.Templates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.Servicos.Interfaces
{
    public interface ICategoriaServico
    {
        void Adicionar(Categoria categoria);
        void Atualizar(Categoria categoria);
        Categoria ObterPorId(int id);
        IEnumerable<Categoria> ObterTodas();
        IEnumerable<RotinaTemplate> ObterRotinas(int id);
        void Remover(Categoria categoria);
    }
}
