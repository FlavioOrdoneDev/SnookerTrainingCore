using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnookerTrainingCore.ApplicationService.AppModels.Templates;
using SnookerTrainingCore.ApplicationService.AppServicos.Interfaces.Templates;
using SnookerTrainingCore.Domain.Entidades.Templates;
using SnookerTrainingCore.Domain.Servicos.Interfaces;

namespace SnookerTrainingCore.API.Controllers.Templates
{
    public class RotinaTemplateController : Controller
    {
        private readonly IRotinaTemplateServico _rotinaTemplateServico;
        private readonly IRotinaTemplateAppServico _rotinaTemplateAppServico;

        public RotinaTemplateController(IRotinaTemplateServico rotinaTemplateServico, IRotinaTemplateAppServico rotinaTemplateAppServico)
        {
            _rotinaTemplateServico = rotinaTemplateServico;
            _rotinaTemplateAppServico = rotinaTemplateAppServico;
        }

        [Route("v1/rotinasTemplate")]
        [HttpGet]
        public IEnumerable<RotinaTemplate> Get()
        {
            var rotinas = _rotinaTemplateServico.ObterTodas();
            return rotinas;
        }

        [Route("v1/rotinasTemplate/{id}")]
        [HttpGet]
        public RotinaTemplateViewModel Get(int id)
        {
            var rotina = _rotinaTemplateAppServico.ObterPorId(id);
            return rotina;
        }

        [Route("v1/rotinasTemplate")]
        [HttpPost]
        public RotinaTemplate Post([FromBody]RotinaTemplate rotina)
        {
            _rotinaTemplateServico.Adicionar(rotina);
            return rotina;
        }

        [Route("v1/rotinasTemplate")]
        [HttpPut]
        public RotinaTemplate Put([FromBody]RotinaTemplate rotina)
        {
            _rotinaTemplateServico.Atualizar(rotina);
            return rotina;
        }

        [Route("v1/rotinasTemplate")]
        [HttpDelete]
        public RotinaTemplate Delete([FromBody]RotinaTemplate rotina)
        {
            _rotinaTemplateServico.Remover(rotina);
            return rotina;
        }
    }
}