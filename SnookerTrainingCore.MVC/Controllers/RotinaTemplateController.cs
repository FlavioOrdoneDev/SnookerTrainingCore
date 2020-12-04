using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnookerTrainingCore.Domain.Entidades.Templates;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using SnookerTrainingCore.MVC.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Collections.Generic;
using System;

namespace SnookerTrainingCore.MVC.Controllers
{
    public class RotinaTemplateController : Controller
    {
        private readonly IRotinaTemplateServico _rotinaTemplateServico;
        private readonly ICategoriaServico _categoriaServico;
        private readonly IHostingEnvironment _hostingEnvironment;

        public RotinaTemplateController(IRotinaTemplateServico rotinaTemplateServico, 
                                        ICategoriaServico categoriaServico, 
                                        IHostingEnvironment hostingEnvironment )
        {
            _rotinaTemplateServico = rotinaTemplateServico;
            _categoriaServico = categoriaServico;
            _hostingEnvironment = hostingEnvironment;
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
        public ActionResult Adicionar(RotinaTemplate rotinaTemplate, IFormFile arquivo)
        {
            //if (ModelState.IsValid)
            //{
            //    _rotinaTemplateServico.Adicionar(rotinaTemplate);
            //}
            //else
            //{
            //    RedirectToAction("Index");
            //}

            var linkUpload = Path.Combine(_hostingEnvironment.WebRootPath, "imagens");

            //string jpgFileName = Path.GetFileNameWithoutExtension(arquivo.FileName) + ".jpg";

            if (arquivo != null)
            {
                using (var filestream = new FileStream(Path.Combine(linkUpload, arquivo.FileName), FileMode.Create))
                {
                    arquivo.CopyTo(filestream);
                    rotinaTemplate.Imagem = "~/imagens/" + arquivo.FileName;

                    //var rotinas = _rotinaTemplateServico.ObterTodas();
                    //foreach (var item in rotinas)
                    //{
                    //    if (rotinaTemplate.Imagem.Equals(item.Imagem))
                    //        rotinaTemplate.Imagem += "1";
                    //}
                    
                }
            }

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
            TempData["ImagemRotina"] = viewModel.RotinaTemplate.Imagem;
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Editar(RotinaTemplate rotinaTemplate, IFormFile arquivo)
        {
            //if (ModelState.IsValid)
            //{
            //    _rotinaTemplateServico.Atualizar(rotinaTemplate);
            //}
            //else
            //{
            //    RedirectToAction("Index");
            //}

            if (String.IsNullOrEmpty(rotinaTemplate.Imagem))
                rotinaTemplate.Imagem = TempData["ImagemRotina"].ToString();

            var linkUpload = Path.Combine(_hostingEnvironment.WebRootPath, "imagens");

            if (arquivo != null)
            {
                using (var filestream = new FileStream(Path.Combine(linkUpload, arquivo.FileName), FileMode.Create))
                {
                    arquivo.CopyToAsync(filestream);
                    rotinaTemplate.Imagem = "~/imagens/" + arquivo.FileName;   
                }
            }

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

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entidade = _rotinaTemplateServico.ObterPorId(id.Value);
            return View(entidade);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var link = _rotinaTemplateServico.ObterPorId(id).Imagem;
            if (link != null)
            {
                var linkImagem = link.Replace("~", "wwwroot");
                System.IO.File.Delete(linkImagem);
            }
            
            var entidade = _rotinaTemplateServico.ObterPorId(id);
            _rotinaTemplateServico.Remover(entidade);

            return RedirectToAction(nameof(Index));

        }
    }
}