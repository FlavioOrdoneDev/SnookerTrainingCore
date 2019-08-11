using SnookerTrainingCore.ApplicationService.AppModels;
using SnookerTrainingCore.ApplicationService.AppServicos.Interfaces;
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
    }
}
