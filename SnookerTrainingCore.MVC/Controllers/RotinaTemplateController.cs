using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnookerTrainingCore.Domain.Entidades.Templates;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using SnookerTrainingCore.MVC.Models.ViewModels;

namespace SnookerTrainingCore.MVC.Controllers
{
    public class RotinaTemplateController : Controller
    {
        private readonly IRotinaTemplateServico _rotinaTemplateServico;
        private readonly ICategoriaServico _categoriaServico;

        public RotinaTemplateController(IRotinaTemplateServico rotinaTemplateServico, ICategoriaServico categoriaServico)
        {
            _rotinaTemplateServico = rotinaTemplateServico;
            _categoriaServico = categoriaServico;
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
            var categorias = _categoriaServico.ObterTodas();
            var viewModel = new RotinaCategoriaViewModel { Categorias = categorias };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Adicionar(RotinaTemplate rotinaTemplate)
        {
            //if (ModelState.IsValid)
            //{
            //    _rotinaTemplateServico.Adicionar(rotinaTemplate);
            //}
            //else
            //{
            //    RedirectToAction("Index");
            //}

            _rotinaTemplateServico.Adicionar(rotinaTemplate);

            var entidade = _rotinaTemplateServico.ObterTodas();

            return View("Index", entidade);
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var rotinaTemplate = _rotinaTemplateServico.ObterPorId(id);
            var categorias = _categoriaServico.ObterTodas();
            var viewModel = new RotinaCategoriaViewModel { RotinaTemplate = rotinaTemplate, Categorias = categorias }; 
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Editar(RotinaTemplate rotinaTemplate)
        {
            //if (ModelState.IsValid)
            //{
            //    _rotinaTemplateServico.Atualizar(rotinaTemplate);
            //}
            //else
            //{
            //    RedirectToAction("Index");
            //}

            _rotinaTemplateServico.Atualizar(rotinaTemplate);

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