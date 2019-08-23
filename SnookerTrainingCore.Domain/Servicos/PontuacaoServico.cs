using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Repositorios.Interfaces;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.Servicos
{
    public class PontuacaoServico : IPontuacaoServico
    {
        private readonly IPontuacaoRepositorio _pontuacaoRepositorio;

        public PontuacaoServico(IPontuacaoRepositorio pontuacaoRepositorio)
        {
            _pontuacaoRepositorio = pontuacaoRepositorio;
        }

        public void Adicionar(Pontuacao pontuacao)
        {
            _pontuacaoRepositorio.Adicionar(pontuacao);
        }

        public void Atualizar(Pontuacao pontuacao)
        {
            _pontuacaoRepositorio.Atualizar(pontuacao);
        }

        public Pontuacao ObterPorId(int id)
        {
            return _pontuacaoRepositorio.ObterPorId(id);
        }

        public IEnumerable<Pontuacao> ObterTodos()
        {
            return _pontuacaoRepositorio.ObterTodos();
        }

        public void Remover(Pontuacao pontuacao)
        {
            _pontuacaoRepositorio.Remover(pontuacao);
        }
    }
}
