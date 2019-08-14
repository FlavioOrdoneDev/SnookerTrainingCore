using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SnookerTrainingCore.ApplicationService.AppModels.Templates;
using SnookerTrainingCore.ApplicationService.AppServicos.Interfaces.Templates;
using SnookerTrainingCore.Domain.Entidades.Templates;

namespace SnookerTrainingCore.API.Controllers.Templates
{
    public class RotinaTemplateController : Controller
    {
        private readonly IRotinaTemplateAppServico _rotinaTemplateAppServico;

        public RotinaTemplateController(IRotinaTemplateAppServico rotinaTemplateAppServico)
        {
            _rotinaTemplateAppServico = rotinaTemplateAppServico;
        }

        [Route("v1/rotinasTemplate")]
        [HttpGet]
        public IEnumerable<RotinaTemplateViewModel> Get()
        {
            var rotinas = _rotinaTemplateAppServico.ObterTodas();
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
            _rotinaTemplateAppServico.Adicionar(rotina);
            return rotina;
        }

        [Route("v1/rotinasTemplate")]
        [HttpPut]
        public RotinaTemplate Put([FromBody]RotinaTemplate rotina)
        {
            _rotinaTemplateAppServico.Atualizar(rotina);
            return rotina;
        }

        [Route("v1/rotinasTemplate")]
        [HttpDelete]
        public RotinaTemplate Delete([FromBody]RotinaTemplate rotina)
        {
            _rotinaTemplateAppServico.Remover(rotina);
            return rotina;
        }
    }
}