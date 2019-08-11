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
    public class TreinoTemplateController : Controller
    {
        private readonly ITreinoTemplateServico _treinoTemplateServico;
        private readonly ITreinoTemplateAppServico _treinoTemplateAppServico;

        public TreinoTemplateController(ITreinoTemplateServico treinoTemplateServico, ITreinoTemplateAppServico treinoTemplateAppServico)
        {
            _treinoTemplateServico = treinoTemplateServico;
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
            _treinoTemplateServico.Adicionar(treino);
            return treino;
        }

        [Route("v1/treinosTemplate")]
        [HttpPut]
        public TreinoTemplate Put([FromBody]TreinoTemplate treino)
        {
            _treinoTemplateServico.Atualizar(treino);
            return treino;
        }

        [Route("v1/treinosTemplate")]
        [HttpDelete]
        public TreinoTemplate Delete([FromBody]TreinoTemplate treino)
        {
            _treinoTemplateServico.Remover(treino);
            return treino;
        }
    }
}