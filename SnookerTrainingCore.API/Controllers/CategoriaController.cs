using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SnookerTrainingCore.ApplicationService.AppModels;
using SnookerTrainingCore.ApplicationService.AppModels.Templates;
using SnookerTrainingCore.ApplicationService.AppServicos.Interfaces;
using SnookerTrainingCore.Domain.Entidades;

namespace SnookerTrainingCore.API.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaAppServico _categoriaAppServico;

        public CategoriaController(ICategoriaAppServico categoriaAppServico)
        {
            _categoriaAppServico = categoriaAppServico;
        }

        [Route("v1/categorias")]
        [HttpGet]
        public IEnumerable<CategoriaViewModel> Get()
        {
            var categorias = _categoriaAppServico.ObterTodas();
            return categorias;
        }

        [Route("v1/categorias/{id}")]
        [HttpGet]
        public CategoriaViewModel Get(int id)
        {
            var categoriaViewModel = _categoriaAppServico.ObterPorId(id);           
            return categoriaViewModel;
        }

        [Route("v1/categorias/{id}/rotinas")]
        [HttpGet]
        public IEnumerable<RotinaTemplateViewModel> GetRotinas(int id)
        {
            var rotina = _categoriaAppServico.ObterRotinas(id);
            return rotina;
        }

        [Route("v1/categorias")]
        [HttpPost]
        public Categoria Post([FromBody]Categoria categoria)
        {
            _categoriaAppServico.Adicionar(categoria);
            return categoria;
        }

        [Route("v1/categorias")]
        [HttpPut]
        public Categoria Put([FromBody]Categoria categoria)
        {
            _categoriaAppServico.Atualizar(categoria);
            return categoria;
        }

        [Route("v1/categorias")]
        [HttpDelete]
        public Categoria Delete([FromBody]Categoria categoria)
        {
            _categoriaAppServico.Remover(categoria);
            return categoria;
        }
    }
}