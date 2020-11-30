using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using SnookerTrainingCore.MVC.Models.ViewModels;

namespace SnookerTrainingCore.MVC.Controllers
{
    public class TreinoController : Controller
    {
        private readonly ITreinoServico _treinoServico;
        private readonly ITreinoTemplateServico _treinoTemplateServico;
        private readonly IRotinaTemplateServico _rotinaTemplateServico;

        public TreinoController(ITreinoServico treinoServico, ITreinoTemplateServico treinoTemplateServico, IRotinaTemplateServico rotinaTemplateServico)
        {
            _treinoServico = treinoServico;
            _treinoTemplateServico = treinoTemplateServico;
            _rotinaTemplateServico = rotinaTemplateServico;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var treinos = _treinoServico.ObterTodas();
            return View(treinos);
        }

        [HttpGet]
        public ActionResult Adicionar()
        {
            var treinosTemplate = _treinoTemplateServico.ObterTodas();
            var rotinasTemplate = _rotinaTemplateServico.ObterTodas();
            var viewModel = new TreinoRotinaViewModel { TreinosTemplate = treinosTemplate, RotinasTemplate = rotinasTemplate };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Adicionar(Treino treino)
        {
            //if (ModelState.IsValid)
            //{
            //    _treinoTemplateServico.Adicionar(treinoTemplate);
            //}
            //else
            //{
            //    RedirectToAction("Index");
            //}

            _treinoServico.Adicionar(treino);
            var entidade = _treinoServico.ObterTodas();

            return View("Index", entidade);
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var treino = _treinoServico.ObterPorId(id);
            if (treino == null)
            {
                return NotFound();
            }

            return View(treino);
        }

        [HttpPost]
        public ActionResult Editar(Treino treino)
        {
            if (ModelState.IsValid)
            {
                _treinoServico.Atualizar(treino);
            }
            else
            {
                RedirectToAction("Index");
            }

            var entidade = _treinoServico.ObterTodas();

            return View("Index", entidade);
        }

        [HttpGet]
        public ActionResult Detalhes(int id)
        {
            var treino = _treinoServico.ObterPorId(id);
            return View(treino);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entidade = _treinoServico.ObterPorId(id.Value);
            return View(entidade);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var entidade = _treinoServico.ObterPorId(id);
            _treinoServico.Remover(entidade);

            return RedirectToAction(nameof(Index));

        }
    }
}
