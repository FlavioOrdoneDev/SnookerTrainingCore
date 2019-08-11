using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Repositorios.Interfaces;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.Servicos
{
    public class TreinoServico : ITreinoServico
    {
        private ITreinoRepositorio _treinoRepositorio;

        public TreinoServico(ITreinoRepositorio treinoRepositorio)
        {
            _treinoRepositorio = treinoRepositorio;
        }

        public void Adicionar(Treino treino)
        {
            _treinoRepositorio.Adicionar(treino);
        }

        public void Atualizar(Treino treino)
        {
            _treinoRepositorio.Atualizar(treino);
        }

        public Treino ObterPorId(int id)
        {
            return _treinoRepositorio.ObterPorId(id);
        }

        public IEnumerable<Treino> ObterTodas()
        {
            return _treinoRepositorio.ObterTodos();
        }

        public void Remover(Treino treino)
        {
            _treinoRepositorio.Remover(treino);
        }
    }
}
