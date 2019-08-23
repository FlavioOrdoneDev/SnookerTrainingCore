using SnookerTrainingCore.ApplicationService.AppModels;
using SnookerTrainingCore.ApplicationService.AppServicos.Interfaces;
using SnookerTrainingCore.Domain.DomainModels.RotinaModels;
using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppServicos
{
    public class RotinaAppServico : IRotinaAppServico
    {
        private readonly IRotinaServico _rotinaServico;
        public RotinaAppServico(IRotinaServico rotinaServico)
        {
            _rotinaServico = rotinaServico;
        }

        public void Adicionar(Rotina rotina)
        {
            _rotinaServico.Adicionar(rotina);
        }

        public void Atualizar(Rotina rotina)
        {
            _rotinaServico.Atualizar(rotina);
        }

        public IEnumerable<Pontuacao> ObterPontuacao(int id)
        {
            return _rotinaServico.ObterPontuacao(id);
        }

        public RotinaModel ObterResultadoDaRotina(int id)
        {
            throw new NotImplementedException();
        }        

        public void Remover(Rotina rotina)
        {
            _rotinaServico.Remover(rotina);
        }

        public RotinaViewModel ObterPorId(int id)
        {
            var rotina = _rotinaServico.ObterPorId(id);

            var rotinaViewModel = new RotinaViewModel
            {
                IdRotina = rotina.IdRotina,
                Nome = rotina.RotinaTemplate.Nome,
                Descricao = rotina.RotinaTemplate.Descricao,
                TipoMeta = rotina.RotinaTemplate.TipoMeta.ToString(),
                Meta = rotina.RotinaTemplate.Meta,
                BreakMaximo = rotina.ObterBreakMaximo(),
                Media = rotina.ObterMedia(),
                Observacao = rotina.Observacao,
                Pontos = rotina.Pontos.Select(x => new PontuacaoViewModel
                {
                    IdPontuacao = x.IdPontuacao,
                    Pontos = x.Pontos,
                    MatouTodasAsBolas = x.MatouTodasAsBolas
                }).ToList()
            };

            return rotinaViewModel;
        }

        public IEnumerable<RotinaViewModel> ObterTodas()
        {
            var rotinas = _rotinaServico.ObterTodas();

            var rotinasViewModel = new List<RotinaViewModel>();

            foreach (var rotina in rotinas)
            {
                rotinasViewModel.Add(new RotinaViewModel
                {
                    IdRotina = rotina.IdRotina,
                    Nome = rotina.RotinaTemplate.Nome,
                    Descricao = rotina.RotinaTemplate.Descricao,
                    TipoMeta = rotina.RotinaTemplate.TipoMeta.ToString(),
                    Meta = rotina.RotinaTemplate.Meta,
                    BreakMaximo = rotina.BreakMaximo,
                    Media = rotina.Media,
                    Observacao = rotina.Observacao,
                    Pontos = rotina.Pontos.Select(x => new PontuacaoViewModel
                    {
                        IdPontuacao = x.IdPontuacao,
                        MatouTodasAsBolas = x.MatouTodasAsBolas,
                        Pontos = x.Pontos
                    }).ToList()
                });
            }

            return rotinasViewModel;
        }
    }
}
