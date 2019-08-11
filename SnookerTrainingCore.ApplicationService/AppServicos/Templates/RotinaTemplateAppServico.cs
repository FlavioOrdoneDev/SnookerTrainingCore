using SnookerTrainingCore.ApplicationService.AppModels.Templates;
using SnookerTrainingCore.ApplicationService.AppServicos.Interfaces.Templates;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppServicos.Templates
{
    public class RotinaTemplateAppServico : IRotinaTemplateAppServico
    {
        private readonly IRotinaTemplateServico _rotinaTemplateServico;

        public RotinaTemplateAppServico(IRotinaTemplateServico rotinaTemplateServico)
        {
            _rotinaTemplateServico = rotinaTemplateServico;
        }

        public RotinaTemplateViewModel ObterPorId(int id)
        {
            var rotina = _rotinaTemplateServico.ObterPorId(id);

            var rotinaViewModel = new RotinaTemplateViewModel
            {
                IdRotina = rotina.IdRotina,
                Nome = rotina.Nome,
                Descricao = rotina.Descricao,
                TipoMeta = rotina.TipoMeta.ToString(),
                Meta = rotina.Meta
            };

            return rotinaViewModel;        
        }
    }
}
