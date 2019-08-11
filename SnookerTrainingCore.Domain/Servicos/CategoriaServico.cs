using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Entidades.Templates;
using SnookerTrainingCore.Domain.Repositorios.Interfaces;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using System;
using System.Collections.Generic;

namespace SnookerTrainingCore.Domain.Servicos
{
    public class CategoriaServico : ICategoriaServico
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public CategoriaServico(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }

        public void Adicionar(Categoria categoria)
        {
            _categoriaRepositorio.Adicionar(categoria);
        }

        public void Atualizar(Categoria categoria)
        {
            _categoriaRepositorio.Atualizar(categoria);
        }

        public Categoria ObterPorId(int id)
        {
            return _categoriaRepositorio.ObterPorId(id);
        }

        public IEnumerable<Categoria> ObterTodas()
        {
            return _categoriaRepositorio.ObterTodos();
        }

        public IEnumerable<RotinaTemplate> ObterRotinas(int id)
        {
            return _categoriaRepositorio.ObterRotinas(id);
        }

        public void Remover(Categoria categoria)
        {
            _categoriaRepositorio.Remover(categoria);
        }
    }
}
