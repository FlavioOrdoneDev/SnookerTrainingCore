using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SnookerTrainingCore.ApplicationService.AppModels;
using SnookerTrainingCore.ApplicationService.AppServicos.Interfaces;
using SnookerTrainingCore.Domain.Entidades;

namespace SnookerTrainingCore.API.Controllers
{
    public class RotinaController : Controller
    { 
        private readonly IRotinaAppServico _rotinaAppServico;

        public RotinaController(IRotinaAppServico rotinaAppServico)
        {
           _rotinaAppServico = rotinaAppServico;
        }

        [Route("v1/rotinas")]
        [HttpGet]
        public IEnumerable<RotinaViewModel> Get()
        {
            var rotinas = _rotinaAppServico.ObterTodas();
            return rotinas;
        }

        [Route("v1/rotinas/{id}")]
        [HttpGet]
        public RotinaViewModel Get(int id)
        {
            var rotina = _rotinaAppServico.ObterPorId(id);
            return rotina;
        }

        [Route("v1/rotinas/{id}/pontuacoes")]
        [HttpGet]
        public IEnumerable<Pontuacao> GetRotinas(int id)
        {
            var pontos = _rotinaAppServico.ObterPontuacao(id);
            return pontos;
        }

        [Route("v1/rotinas")]
        [HttpPost]
        public Rotina Post([FromBody]Rotina rotina)
        {
            _rotinaAppServico.Adicionar(rotina);
            return rotina;
        }

        [Route("v1/rotinas")]
        [HttpPut]
        public Rotina Put([FromBody]Rotina rotina)
        {
            _rotinaAppServico.Atualizar(rotina);
            return rotina;
        }

        [Route("v1/rotinas")]
        [HttpDelete]
        public Rotina Delete([FromBody]Rotina rotina)
        {
            _rotinaAppServico.Remover(rotina);
            return rotina;
        }
    }
}