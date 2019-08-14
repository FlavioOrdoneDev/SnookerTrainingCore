using SnookerTrainingCore.ApplicationService.AppModels.Templates;
using SnookerTrainingCore.ApplicationService.AppServicos.Interfaces.Templates;
using SnookerTrainingCore.Domain.Entidades.Templates;
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

        public void Adicionar(RotinaTemplate rotina)
        {
            _rotinaTemplateServico.Adicionar(rotina);
        }

        public void Atualizar(RotinaTemplate rotina)
        {
            _rotinaTemplateServico.Atualizar(rotina);
        }

        public void Remover(RotinaTemplate rotina)
        {
            _rotinaTemplateServico.Remover(rotina);
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

        public IEnumerable<RotinaTemplateViewModel> ObterTodas()
        {
            var rotinas = _rotinaTemplateServico.ObterTodas();

            var rotinaTemplateViewModel = new List<RotinaTemplateViewModel>();

            foreach (var rotina in rotinas)
            {
                rotinaTemplateViewModel.Add(new RotinaTemplateViewModel
                {
                    IdRotina = rotina.IdRotina,
                    Nome = rotina.Nome,
                    Descricao = rotina.Descricao,
                    TipoMeta = rotina.TipoMeta.ToString(),
                    Meta = rotina.Meta
                });
            }

            return rotinaTemplateViewModel;
        }        
    }
}
