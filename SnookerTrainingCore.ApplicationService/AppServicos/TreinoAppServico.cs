using SnookerTrainingCore.ApplicationService.AppModels;
using SnookerTrainingCore.ApplicationService.AppServicos.Interfaces;
using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppServicos
{
    public class TreinoAppServico : ITreinoAppServico
    {

        private readonly ITreinoServico _treinoServico;
        public TreinoAppServico(ITreinoServico treinoServico)
        {
            _treinoServico = treinoServico;
        }

        public void Adicionar(Treino treino)
        {
            _treinoServico.Adicionar(treino);
        }

        public void Atualizar(Treino treino)
        {
            _treinoServico.Atualizar(treino);
        }

        public void Remover(Treino treino)
        {
            _treinoServico.Remover(treino);
        }

        public TreinoViewModel ObterPorId(int id)
        {
            var treino = _treinoServico.ObterPorId(id);

            var treinoViewModel = new TreinoViewModel
            {
                IdTreino = treino.IdTreino,
                Nome = treino.TreinoTemplate.Nome,
                Descricao = treino.TreinoTemplate.Descricao,
                Data = treino.Data,
                HoraInicio = treino.HoraInicio,
                HoraFim = treino.HoraFim,
                Duracao = treino.Duracao,
                Observacao = treino.Observacao,
                Rotinas = treino.Rotinas.Select(x => new RotinaViewModel
                {
                    IdRotina = x.IdRotina,
                    //Nome = x.RotinaTemplate.Nome,
                    //Descricao = x.RotinaTemplate.Descricao,
                    //TipoMeta = x.RotinaTemplate.TipoMeta.ToString(),
                    //Meta = x.RotinaTemplate.Meta,
                    BreakMaximo = x.ObterBreakMaximo(),
                    Media = x.ObterMedia(),
                    Observacao = x.Observacao

                }).ToList()
            };

            return treinoViewModel;

        }

        public IEnumerable<TreinoViewModel> ObterTodos()
        {
            var treinos = _treinoServico.ObterTodas();

            var treinosViewModel = new List<TreinoViewModel>();

            foreach (var treino in treinos)
            {
                treinosViewModel.Add(new TreinoViewModel
                {
                    IdTreino = treino.IdTreino,
                    Nome = treino.TreinoTemplate.Nome,
                    Descricao = treino.TreinoTemplate.Descricao,
                    Data = treino.Data,
                    HoraInicio = treino.HoraInicio,
                    HoraFim = treino.HoraFim,
                    Duracao = treino.Duracao,
                    Observacao = treino.Observacao,
                    Rotinas = treino.Rotinas.Select(x => new RotinaViewModel
                    {
                        IdRotina = x.IdRotina,
                        //Nome = x.RotinaTemplate.Nome,
                        //Descricao = x.RotinaTemplate.Descricao,
                        //TipoMeta = x.RotinaTemplate.TipoMeta.ToString(),
                        //Meta = x.RotinaTemplate.Meta,
                        BreakMaximo = x.ObterBreakMaximo(),
                        Media = x.ObterMedia(),
                        Observacao = x.Observacao

                    }).ToList()
                });
            }

            return treinosViewModel;
        }        
    }
}
