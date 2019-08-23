using SnookerTrainingCore.Domain.DomainModels.ResultadoModels;
using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Repositorios.Interfaces;
using SnookerTrainingCore.Domain.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SnookerTrainingCore.Domain.Servicos
{
    public class ResultadoServico : IResultadoServico
    {
        private readonly IResultadoRepositorio _resultadorepositorio;

        public ResultadoServico(IResultadoRepositorio resultadorepositorio)
        {
            _resultadorepositorio = resultadorepositorio;
        }

        public ResultadoTreinoModel GerarResultado(Resultado resultado, Treino treino, DateTime data)
        {
            var gerarResultado = new ResultadoTreinoModel
            {
                IdResultado = resultado.IdResultado,
                IdTreino = treino.IdTreino,
                NomeTreino = treino.TreinoTemplate.Nome,
                Data = data,
                Descricao = treino.TreinoTemplate.Descricao              
            };

            return gerarResultado;
        }

        public void Adicionar(Resultado resultado)
        {
            _resultadorepositorio.Adicionar(resultado);
        }

        public void Atualizar(Resultado resultado)
        {
            _resultadorepositorio.Atualizar(resultado);
        }

        public Resultado ObterPorId(int id)
        {
            return _resultadorepositorio.ObterPorId(id);
        }

        public IEnumerable<Resultado> ObterTodas()
        {
            return _resultadorepositorio.ObterTodos();
        }

        public void Remover(Resultado resultado)
        {
            _resultadorepositorio.Remover(resultado);
        }

        private IList<ResultadoRotinaModel> ObterRotinas(ICollection<Rotina> rotinas)
        {
            var resultadoRotinas = new List<ResultadoRotinaModel>();

            foreach (var rotina in rotinas)
            {
                resultadoRotinas.Add(new ResultadoRotinaModel
                {
                    IdRotina = rotina.IdRotina,
                    NomeRotina = rotina.RotinaTemplate.Nome,
                    Descricao = rotina.RotinaTemplate.Descricao,
                    NomeCategoria = rotina.RotinaTemplate.Categoria.Nome,
                    Meta = rotina.RotinaTemplate.Meta,
                    BreakMaximo = rotina.ObterBreakMaximo(),
                    Media = rotina.ObterMedia(),
                    Observacao = rotina.Observacao,
                    Pontos = rotina.Pontos.ToArray()
                });
            }

            return resultadoRotinas;
        }
    }
}
