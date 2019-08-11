using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnookerTrainingCore.ApplicationService.AppModels;
using SnookerTrainingCore.ApplicationService.AppServicos.Interfaces;
using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Servicos.Interfaces;

namespace SnookerTrainingCore.API.Controllers
{
    public class TreinoController : Controller
    {
        private readonly ITreinoServico _treinoServico;
        private readonly ITreinoAppServico _treinoAppServico;

        public TreinoController(ITreinoServico treinoServico, ITreinoAppServico treinoAppServico)
        {
            _treinoServico = treinoServico;
            _treinoAppServico = treinoAppServico;
        }

        [Route("v1/treinos")]
        [HttpGet]
        public IEnumerable<TreinoViewModel> Get()
        {
            var treinos = _treinoAppServico.ObterTodos();
            return treinos;
        }

        [Route("v1/treinos/{id}")]
        [HttpGet]
        public TreinoViewModel Get(int id)
        {
            var treino = _treinoAppServico.ObterPorId(id);
            return treino;
        }

        [Route("v1/treinos")]
        [HttpPost]
        public Treino Post([FromBody]Treino treino)
        {
            _treinoServico.Adicionar(treino);
            return treino;
        }

        [Route("v1/treinos")]
        [HttpPut]
        public Treino Put([FromBody]Treino treino)
        {
            _treinoServico.Atualizar(treino);
            return treino;
        }

        [Route("v1/treinos")]
        [HttpDelete]
        public Treino Delete([FromBody]Treino treino)
        {
            _treinoServico.Remover(treino);
            return treino;
        }
    }
}