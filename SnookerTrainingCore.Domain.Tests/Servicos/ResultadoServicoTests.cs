using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Entidades.Templates;
using SnookerTrainingCore.Domain.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SnookerTrainingCore.Domain.Tests
{
    [TestClass]
    public class ResultadoServicoTests
    {
        private ResultadoServico _resultadoServico;

        public ResultadoServicoTests()
        {
            
        }

        [TestMethod]
        public void Resultado_E_Possivel_Obter_A_Quantidade_De_Rotinas_Do_Treino()
        {

            Treino treino = ObterTreino(1);

            Resultado resultado = new Resultado
            {
                IdResultado = 1                
            };

            var resultadoTreino = _resultadoServico.GerarResultado(resultado, treino, new DateTime(2019, 01, 01));

            Assert.AreEqual(3, resultadoTreino.ResultadoRotinas.Count);            
        }


        [TestMethod]
        public void Resultado_E_Possivel_Obter_O_BreakMaximo_Das_Rotinas()
        {

            Treino treino = ObterTreino(1);

            Resultado resultado = new Resultado
            {
                IdResultado = 1
            };

            var resultadoTreino = _resultadoServico.GerarResultado(resultado, treino, new DateTime(2019, 01, 01));

            Assert.AreEqual(75, resultadoTreino.ResultadoRotinas[0].BreakMaximo);
            Assert.AreEqual(74, resultadoTreino.ResultadoRotinas[1].BreakMaximo);
            Assert.AreEqual(73, resultadoTreino.ResultadoRotinas[2].BreakMaximo);
        }

        [TestMethod]
        public void Resultado_E_Possivel_Obter_A_Media_De_Pontos_Das_Rotinas()
        {

            Treino treino = ObterTreino(1);

            Resultado resultado = new Resultado
            {
                IdResultado = 1
            };

            var resultadoTreino = _resultadoServico.GerarResultado(resultado, treino, new DateTime(2019, 01, 01));

            Assert.AreEqual(73, resultadoTreino.ResultadoRotinas[0].Media);
            Assert.AreEqual(72, resultadoTreino.ResultadoRotinas[1].Media);
            Assert.AreEqual(70, resultadoTreino.ResultadoRotinas[2].Media);
        }


        #region Configuracoes
        public Categoria ObterCategoria(int id)
        {
            var categorias = new List<Categoria>();

            var categoria1 = new Categoria
            {
                IdCategoria = 1,
                Nome = "Positional Play",
                Descricao = "Descrição categoria"
            };

            var categoria2 = new Categoria
            {
                IdCategoria = 2,
                Nome = "Safety",
                Descricao = "Descrição categoria"
            };

            var categoria3 = new Categoria
            {
                IdCategoria = 3,
                Nome = "Cue Ball Control",
                Descricao = "Descrição categoria"
            };

            categorias.Add(categoria1);
            categorias.Add(categoria2);
            categorias.Add(categoria3);

            var resultado = categorias.Where(r => r.IdCategoria == id).FirstOrDefault();

            return resultado;
        }

        public Rotina ObterRotina(int id)
        {
            var pontos1 = new List<Pontuacao>();
            var ponto1 = new Pontuacao(73);
            var ponto2 = new Pontuacao(75);
            var ponto3 = new Pontuacao(71);

            pontos1.Add(ponto1);
            pontos1.Add(ponto2);
            pontos1.Add(ponto3);

            var rotina1 = new RotinaTemplate
            {
                IdRotina = 1,
                Nome = "Six Reds",
                Descricao = "Descrição rotina",
                Categoria = ObterCategoria(1),
                TipoMeta = TipoMeta.PorPontos,
                Meta = 75
            };

            var pontos2 = new List<Pontuacao>();
            var ponto21 = new Pontuacao(72);
            var ponto22 = new Pontuacao(74);
            var ponto23 = new Pontuacao(70);

            pontos2.Add(ponto21);
            pontos2.Add(ponto22);
            pontos2.Add(ponto23);

            var rotina2 = new RotinaTemplate
            {
                IdRotina = 2,
                Nome = "K118",
                Descricao = "Descrição rotina",
                Categoria = ObterCategoria(1),
                TipoMeta = TipoMeta.PorPontos,
                Meta = 75
            };

            var pontos3 = new List<Pontuacao>();
            var ponto31 = new Pontuacao(73);
            var ponto32 = new Pontuacao(67);
            var ponto33 = new Pontuacao(70);

            pontos3.Add(ponto31);
            pontos3.Add(ponto32);
            pontos3.Add(ponto33);

            var rotina3 = new RotinaTemplate
            {
                IdRotina = 3,
                Nome = "K75",
                Descricao = "Descrição rotina",
                Categoria = ObterCategoria(1),
                TipoMeta = TipoMeta.PorPontos,
                Meta = 75
            };

            var rotinas = new List<RotinaTemplate>();

            rotinas.Add(rotina1);
            rotinas.Add(rotina2);
            rotinas.Add(rotina3);

            var rotina = rotinas.Where(r => r.IdRotina == id).FirstOrDefault();

            return null;
        }

        public Treino ObterTreino(int id)
        {
            var treinoPositional = new TreinoTemplate
            {
                IdTreino = 1,
                Nome = "Positional Play",
                Descricao = "Descrição treino"
            };

            //treinoPositional.TreinoRotinas.Add(ObterRotina(1));
            //treinoPositional.TreinoRotinas.Add(ObterRotina(2));
            //treinoPositional.TreinoRotinas.Add(ObterRotina(3));

            var treinoSafety = new TreinoTemplate
            {
                IdTreino = 2,
                Nome = "Safety",
                Descricao = "Descrição treino"                
            };

            //treinoSafety.TreinoRotinas.Add(ObterRotina(1));
            //treinoSafety.TreinoRotinas.Add(ObterRotina(2));
            //treinoSafety.TreinoRotinas.Add(ObterRotina(3));

            var treinos = new List<TreinoTemplate>();

            treinos.Add(treinoPositional);
            treinos.Add(treinoSafety);

            var treino = treinos.Where(t => t.IdTreino == id).FirstOrDefault();

            return null;
        }
        #endregion
    }
}
