using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Servicos.Interfaces;

namespace SnookerTrainingCore.MVC.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaServico _categoriaServico;

        public CategoriaController(ICategoriaServico categoriaServico)
        {
            _categoriaServico = categoriaServico;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var categorias = _categoriaServico.ObterTodas();
            return View(categorias);
        }

        [HttpGet]
        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _categoriaServico.Adicionar(categoria);
            }
            else
            {
                RedirectToAction("Index");
            }

            _categoriaServico.Adicionar(categoria);

            var entidade = _categoriaServico.ObterTodas();

            return View("Index", entidade);
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var categoria = _categoriaServico.ObterPorId(id);
            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        [HttpPost]
        public ActionResult Editar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _categoriaServico.Atualizar(categoria);                
            }
            else
            {
                RedirectToAction("Index");
            }

            var entidade = _categoriaServico.ObterTodas();

            return View("Index", entidade);
        }

        [HttpGet]
        public ActionResult Detalhes(int id)
        {
            var categoria = _categoriaServico.ObterPorId(id);
            return View(categoria);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entidade = _categoriaServico.ObterPorId(id.Value);
            return View(entidade);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var entidade = _categoriaServico.ObterPorId(id);
            _categoriaServico.Remover(entidade);
                
           return RedirectToAction(nameof(Index));            
            
        }
    }
}



        

        

       
   