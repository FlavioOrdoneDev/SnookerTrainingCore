using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnookerTrainingCore.Domain.Entidades.Templates;
using SnookerTrainingCore.Domain.Servicos.Interfaces;

namespace SnookerTrainingCore.MVC.Controllers
{
    public class RotinaTemplateController : Controller
    {
        private readonly IRotinaTemplateServico _rotinaTemplateServico;

        public RotinaTemplateController(IRotinaTemplateServico rotinaTemplateServico)
        {
            _rotinaTemplateServico = rotinaTemplateServico;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var rotinasTemplates = _rotinaTemplateServico.ObterTodas();
            return View(rotinasTemplates);
        }

        [HttpGet]
        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(RotinaTemplate rotinaTemplate)
        {
            if (ModelState.IsValid)
            {
                _rotinaTemplateServico.Adicionar(rotinaTemplate);
            }
            else
            {
                RedirectToAction("Index");
            }

            var entidade = _rotinaTemplateServico.ObterTodas();

            return View("Index", entidade);
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var rotinaTemplate = _rotinaTemplateServico.ObterPorId(id);
            if (rotinaTemplate == null)
            {
                return NotFound();
            }

            return View(rotinaTemplate);
        }

        [HttpPost]
        public ActionResult Editar(RotinaTemplate rotinaTemplate)
        {
            if (ModelState.IsValid)
            {
                _rotinaTemplateServico.Atualizar(rotinaTemplate);
            }
            else
            {
                RedirectToAction("Index");
            }

            var entidade = _rotinaTemplateServico.ObterTodas();

            return View("Index", entidade);
        }

        [HttpGet]
        public ActionResult Detalhes(int id)
        {
            var rotinaTemplate = _rotinaTemplateServico.ObterPorId(id);
            return View(rotinaTemplate);
        }
    }
}