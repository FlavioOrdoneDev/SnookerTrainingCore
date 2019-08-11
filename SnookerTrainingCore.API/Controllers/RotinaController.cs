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
    public class RotinaController : Controller
    { 
        private readonly IRotinaServico _rotinaServico;
        private readonly IRotinaAppServico _rotinaAppServico;

        public RotinaController(IRotinaServico rotinaServico, IRotinaAppServico rotinaAppServico)
        {
            _rotinaServico = rotinaServico;
            _rotinaAppServico = rotinaAppServico;
        }

        [Route("v1/rotinas")]
        [HttpGet]
        public IEnumerable<Rotina> Get()
        {
            var rotinas = _rotinaServico.ObterTodas();
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
            var pontos = _rotinaServico.ObterPontuacao(id);
            return pontos;
        }

        [Route("v1/rotinas")]
        [HttpPost]
        public Rotina Post([FromBody]Rotina rotina)
        {
            _rotinaServico.Adicionar(rotina);
            return rotina;
        }

        [Route("v1/rotinas")]
        [HttpPut]
        public Rotina Put([FromBody]Rotina rotina)
        {
            _rotinaServico.Atualizar(rotina);
            return rotina;
        }

        [Route("v1/rotinas")]
        [HttpDelete]
        public Rotina Delete([FromBody]Rotina rotina)
        {
            _rotinaServico.Remover(rotina);
            return rotina;
        }
    }
}