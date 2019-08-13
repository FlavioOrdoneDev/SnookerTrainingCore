using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SnookerTrainingCore.ApplicationService.AppModels.Templates;
using SnookerTrainingCore.ApplicationService.AppServicos.Interfaces.Templates;
using SnookerTrainingCore.Domain.Entidades.Templates;

namespace SnookerTrainingCore.API.Controllers.Templates
{
    public class TreinoTemplateController : Controller
    {
        private readonly ITreinoTemplateAppServico _treinoTemplateAppServico;

        public TreinoTemplateController(ITreinoTemplateAppServico treinoTemplateAppServico)
        {
            _treinoTemplateAppServico = treinoTemplateAppServico;
        }

        [Route("v1/treinosTemplate")]
        [HttpGet]
        public IEnumerable<TreinoTemplateViewModel> Get()
        {
            var treinos = _treinoTemplateAppServico.ObterTodos();
            return treinos;
        }

        [Route("v1/treinosTemplate/{id}")]
        [HttpGet]
        public TreinoTemplateViewModel Get(int id)
        {
            var treino = _treinoTemplateAppServico.ObterPorId(id);
            return treino;
        }

        [Route("v1/treinosTemplate")]
        [HttpPost]
        public TreinoTemplate Post([FromBody]TreinoTemplate treino)
        {
            _treinoTemplateAppServico.Adicionar(treino);
            return treino;
        }

        [Route("v1/treinosTemplate")]
        [HttpPut]
        public TreinoTemplate Put([FromBody]TreinoTemplate treino)
        {
            _treinoTemplateAppServico.Atualizar(treino);
            return treino;
        }

        [Route("v1/treinosTemplate")]
        [HttpDelete]
        public TreinoTemplate Delete([FromBody]TreinoTemplate treino)
        {
            _treinoTemplateAppServico.Remover(treino);
            return treino;
        }
    }
}