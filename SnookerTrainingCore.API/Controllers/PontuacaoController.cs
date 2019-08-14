using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SnookerTrainingCore.ApplicationService.AppModels;
using SnookerTrainingCore.ApplicationService.AppServicos.Interfaces;
using SnookerTrainingCore.Domain.Entidades;

namespace SnookerTrainingCore.API.Controllers
{
    public class PontuacaoController : Controller
    {
        private readonly IPontuacaoAppServico _pontuacaoAppServico;

        public PontuacaoController(IPontuacaoAppServico pontuacaoAppServico)
        {
            _pontuacaoAppServico = pontuacaoAppServico;
        }

        [Route("v1/pontuacoes")]
        [HttpGet]
        public IEnumerable<PontuacaoViewModel> Get()
        {
            var pontuacoes = _pontuacaoAppServico.ObterTodas();
            return pontuacoes;
        }

        [Route("v1/pontuacoes/{id}")]
        [HttpGet]
        public PontuacaoViewModel Get(int id)
        {
            var pontuacao = _pontuacaoAppServico.ObterPorId(id);
            return pontuacao;
        }

        [Route("v1/pontuacoes/{id}/rotina")]
        [HttpGet]
        public RotinaViewModel GetRotina(int id)
        {
            var rotina = _pontuacaoAppServico.ObterRotina(id);
            return rotina;
        }

        [Route("v1/pontuacoes")]
        [HttpPost]
        public Pontuacao Post([FromBody]Pontuacao pontuacao)
        {
            _pontuacaoAppServico.Adicionar(pontuacao);
            return pontuacao;
        }

        [Route("v1/pontuacoes")]
        [HttpPut]
        public Pontuacao Put([FromBody]Pontuacao pontuacao)
        {
            _pontuacaoAppServico.Atualizar(pontuacao);
            return pontuacao;
        }

        [Route("v1/pontuacoes")]
        [HttpDelete]
        public Pontuacao Delete([FromBody]Pontuacao pontuacao)
        {
            _pontuacaoAppServico.Remover(pontuacao);
            return pontuacao;
        }
    }
}