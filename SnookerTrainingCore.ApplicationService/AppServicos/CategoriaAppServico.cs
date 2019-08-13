using SnookerTrainingCore.ApplicationService.AppModels;
using SnookerTrainingCore.ApplicationService.AppModels.Templates;
using SnookerTrainingCore.ApplicationService.AppServicos.Interfaces;
using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppServicos
{
    public class CategoriaAppServico : ICategoriaAppServico
    {
        private readonly ICategoriaServico _categoriaServico;

        public CategoriaAppServico(ICategoriaServico categoriaServico)
        {
            _categoriaServico = categoriaServico;
        }

        public void Adicionar(Categoria categoria)
        {
            _categoriaServico.Adicionar(categoria);
        }

        public void Atualizar(Categoria categoria)
        {
            _categoriaServico.Atualizar(categoria);
        }

        public void Remover(Categoria categoria)
        {
            _categoriaServico.Remover(categoria);
        }

        public CategoriaViewModel ObterPorId(int id)
        {
            var categoria = _categoriaServico.ObterPorId(id);
            
            var categoriaViewModel  = new CategoriaViewModel
            {
                IdCategoria = categoria.IdCategoria,
                NomeCategoria = categoria.Nome,
                DescricaoCategoria = categoria.Descricao,
                Rotinas = categoria.RotinasTemplate.Select(x => new RotinaViewModel
                {
                    IdRotina = x.IdRotina,
                    Nome = x.Nome,
                    Descricao = x.Descricao,
                    TipoMeta = x.TipoMeta.ToString(),
                    Meta = x.Meta

                }).ToList()
            };

            return categoriaViewModel;
        }

        public IEnumerable<RotinaTemplateViewModel> ObterRotinas(int id)
        {
            var rotinas = _categoriaServico.ObterRotinas(id);

            var rotinasViewModel = new List<RotinaTemplateViewModel>();

            foreach (var rotina in rotinas)
            {
                rotinasViewModel.Add(new RotinaTemplateViewModel
                {
                    Nome = rotina.Nome,
                    IdRotina = rotina.IdRotina,
                    Descricao = rotina.Descricao,
                    TipoMeta = rotina.TipoMeta.ToString(),
                    Meta = rotina.Meta
                   
                });
            }

            return rotinasViewModel;
        }

        public IEnumerable<CategoriaViewModel> ObterTodas()
        {
            var categorias = _categoriaServico.ObterTodas();

            var categoriaViewModel = new List<CategoriaViewModel>();

            foreach (var categoria in categorias)
            {
                categoriaViewModel.Add(new CategoriaViewModel
                {
                    IdCategoria = categoria.IdCategoria,
                    NomeCategoria = categoria.Nome,
                    DescricaoCategoria = categoria.Descricao,
                    Rotinas = categoria.RotinasTemplate.Select(x => new RotinaViewModel
                    {
                        IdRotina = x.IdRotina,
                        Nome = x.Nome,
                        Descricao = x.Descricao,
                        TipoMeta = x.TipoMeta.ToString(),
                        Meta = x.Meta

                    }).ToList()
                });
            }           

            return categoriaViewModel;
        }
    }
}
