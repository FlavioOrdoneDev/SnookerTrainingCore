using SnookerTrainingCore.Domain.DomainModels.RotinaModels;
using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using SnookerTrainingCore.Domain.Repositorios.Interfaces;

namespace SnookerTrainingCore.Domain.Servicos
{
    public class RotinaServico : IRotinaServico
    {
        private readonly IRotinaRepositorio _rotinaRepositorio;        

        public RotinaServico(IRotinaRepositorio rotinaRepositorio)
        {
            _rotinaRepositorio = rotinaRepositorio;
        }

        public void Adicionar(Rotina rotina)
        {
            _rotinaRepositorio.Adicionar(rotina);
        }        

        public void Atualizar(Rotina rotina)
        {
            _rotinaRepositorio.Atualizar(rotina);
        }

        public Rotina ObterPorId(int id)
        {
            return _rotinaRepositorio.ObterPorId(id);
        }

        public RotinaModel ObterResultadoDaRotina(int id)
        {
            var rotina = _rotinaRepositorio.ObterPorId(id);
            var rotinaModel = new RotinaModel
            {
                IdRotina = rotina.IdRotina,
                Nome = rotina.RotinaTemplate.Nome,
                NomeCategoria = rotina.RotinaTemplate.Categoria.Nome,
                Descricao = rotina.RotinaTemplate.Descricao,
                Meta = rotina.RotinaTemplate.Meta                
            };
            return rotinaModel;
        }        

        public IEnumerable<Rotina> ObterTodas()
        {
            return _rotinaRepositorio.ObterTodos();
        }

        public IEnumerable<Pontuacao> ObterPontuacao(int id)
        {
            return _rotinaRepositorio.ObterPontuacao(id);
        }       

        public void Remover(Rotina rotina)
        {
            _rotinaRepositorio.Remover(rotina);
        }
    }
}
