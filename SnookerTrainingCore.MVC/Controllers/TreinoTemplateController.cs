using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnookerTrainingCore.Domain.Entidades.Templates;
using SnookerTrainingCore.Domain.Servicos.Interfaces;

namespace SnookerTrainingCore.MVC.Controllers
{
    public class TreinoTemplateController : Controller

    {
        private readonly ITreinoTemplateServico _treinoTemplateServico;
        private readonly IRotinaTemplateServico _rotinaTemplateServico;

        public TreinoTemplateController(ITreinoTemplateServico treinoTemplateServico, IRotinaTemplateServico rotinaTemplateServico)
        {
            _treinoTemplateServico = treinoTemplateServico;
            _rotinaTemplateServico = rotinaTemplateServico;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var treinosTemplates = _treinoTemplateServico.ObterTodas();
            return View(treinosTemplates);
        }

        [HttpGet]
        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(TreinoTemplate treinoTemplate)
        {
            //if (ModelState.IsValid)
            //{
            //    _treinoTemplateServico.Adicionar(treinoTemplate);
            //}
            //else
            //{
            //    RedirectToAction("Index");
            //}

            var rotinas = _rotinaTemplateServico.ObterTodas();

            foreach (var rotina in rotinas)
            {
                treinoTemplate.RotinaTreinoTemplate.Add(new RotinaTreinoTemplate { RotinaTemplate = rotina });
            }

            _treinoTemplateServico.Adicionar(treinoTemplate);           

            var entidade = _treinoTemplateServico.ObterTodas();

            return View("Index", entidade);
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var treinoTemplate = _treinoTemplateServico.ObterPorId(id);
            if (treinoTemplate == null)
            {
                return NotFound();
            }

            return View(treinoTemplate);
        }

        [HttpPost]
        public ActionResult Editar(TreinoTemplate treinoTemplate)
        {
            if (ModelState.IsValid)
            {
                _treinoTemplateServico.Atualizar(treinoTemplate);
            }
            else
            {
                RedirectToAction("Index");
            }

            var entidade = _treinoTemplateServico.ObterTodas();

            return View("Index", entidade);
        }

        [HttpGet]
        public ActionResult Detalhes(int id)
        {
            var treinoTemplate = _treinoTemplateServico.ObterPorId(id);
            return View(treinoTemplate);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entidade = _treinoTemplateServico.ObterPorId(id.Value);
            return View(entidade);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var entidade = _treinoTemplateServico.ObterPorId(id);
            _treinoTemplateServico.Remover(entidade);

            return RedirectToAction(nameof(Index));

        }
    }
}