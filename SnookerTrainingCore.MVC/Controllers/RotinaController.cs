using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Entidades.Templates;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using SnookerTrainingCore.MVC.Models.ViewModels;

namespace SnookerTrainingCore.MVC.Controllers
{
    public class RotinaController : Controller
    {
        private readonly IRotinaServico _rotinaServico;

        public RotinaController(IRotinaServico rotinaServico)
        {
            _rotinaServico = rotinaServico;
            
        }

        [HttpGet]
        public ActionResult Index()
        {
            var rotinas = _rotinaServico.ObterTodas();
            return View(rotinas);
        }

        [HttpGet]
        public ActionResult Adicionar()
        {
            //var categorias = _categoriaServico.ObterTodas();
            //var viewModel = new RotinaCategoriaViewModel { Categorias = categorias };

            var rotina = _rotinaServico.ObterTodas();
            return View(rotina);
        }

        [HttpPost]
        public ActionResult Adicionar(Rotina rotina)
        {
            //if (ModelState.IsValid)
            //{
            //    _rotinaTemplateServico.Adicionar(rotinaTemplate);
            //}
            //else
            //{
            //    RedirectToAction("Index");
            //}

            _rotinaServico.Adicionar(rotina);

            var entidade = _rotinaServico.ObterTodas();

            return View("Index", entidade);
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var rotina = _rotinaServico.ObterPorId(id);
            //var categorias = _categoriaServico.ObterTodas();
            //var viewModel = new RotinaCategoriaViewModel { RotinaTemplate = rotinaTemplate, Categorias = categorias }; 
            return View(rotina);
        }

        [HttpPost]
        public ActionResult Editar(Rotina rotina)
        {
            //if (ModelState.IsValid)
            //{
            //    _rotinaTemplateServico.Atualizar(rotinaTemplate);
            //}
            //else
            //{
            //    RedirectToAction("Index");
            //}

            _rotinaServico.Atualizar(rotina);

            var entidade = _rotinaServico.ObterTodas();

            return View("Index", entidade);
        }

        [HttpGet]
        public ActionResult Detalhes(int id)
        {

            Pontuacao ponto1 = new Pontuacao { IdPontuacao = 1, Pontos = 67 };
            Pontuacao ponto2 = new Pontuacao { IdPontuacao = 2, Pontos = 70 };
            Pontuacao ponto3 = new Pontuacao { IdPontuacao = 3, Pontos = 69 };
            Pontuacao ponto4 = new Pontuacao { IdPontuacao = 4, Pontos = 73 };
            Pontuacao ponto5 = new Pontuacao { IdPontuacao = 5, Pontos = 58 };
            Pontuacao ponto6 = new Pontuacao { IdPontuacao = 6, Pontos = 60 };
            Pontuacao ponto7 = new Pontuacao { IdPontuacao = 7, Pontos = 68 };
            Pontuacao ponto8 = new Pontuacao { IdPontuacao = 8, Pontos = 74 };
            Pontuacao ponto9 = new Pontuacao { IdPontuacao = 9, Pontos = 62 };
            Pontuacao ponto10 = new Pontuacao { IdPontuacao = 10, Pontos = 65 };


            var rotina = _rotinaServico.ObterPorId(id);
            rotina.Pontos.Add(ponto1);
            rotina.Pontos.Add(ponto2);
            rotina.Pontos.Add(ponto3);
            rotina.Pontos.Add(ponto4);
            rotina.Pontos.Add(ponto5);
            rotina.Pontos.Add(ponto6);
            rotina.Pontos.Add(ponto7);
            rotina.Pontos.Add(ponto8);
            rotina.Pontos.Add(ponto9);
            rotina.Pontos.Add(ponto10);
            return View(rotina);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entidade = _rotinaServico.ObterPorId(id.Value);
            return View(entidade);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var entidade = _rotinaServico.ObterPorId(id);
            _rotinaServico.Remover(entidade);

            return RedirectToAction(nameof(Index));

        }
    }
}