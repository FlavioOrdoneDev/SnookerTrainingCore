using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnookerTrainingCore.Domain.Entidades;
using System.Collections.Generic;
using System.Linq;
using Moq;
using SnookerTrainingCore.Domain.Repositorios.Interfaces;
using SnookerTrainingCore.Domain.Entidades.Templates;
using SnookerTrainingCore.Domain.Servicos.Templates;

namespace SnookerTrainingCore.Domain.Tests
{
    [TestClass]
    public class RotinaTemplateServicoTests
    {        

        [TestMethod]
        public void RotinaTEmplateServico_ObterPorId_NomeValido()
        {
            var rotina = ObterRotinaTemplate(1);

            var repositorio = new Mock<IRotinaTemplateRepositorio>();
            repositorio.Setup(s => s.ObterPorId(rotina.IdRotina)).Returns(rotina);

            var rotinaServico = new RotinaTemplateServico(repositorio.Object);


            var resultado = rotinaServico.ObterPorId(rotina.IdRotina);


            Assert.AreEqual("Six Reds", resultado.Nome);
        }

        [TestMethod]
        public void RotinaTemplateServico_ObterPorId_CategoriaNomeValido()
        {
            var rotina = ObterRotinaTemplate(1);

            var repositorio = new Mock<IRotinaTemplateRepositorio>();
            repositorio.Setup(s => s.ObterPorId(rotina.IdRotina)).Returns(rotina);

            var rotinaServico = new RotinaTemplateServico(repositorio.Object);


            var resultado = rotinaServico.ObterPorId(rotina.IdRotina);

            Assert.AreEqual("Positional Play", resultado.Categoria.Nome);
        }

        [TestMethod]
        public void RotinaTemplateServico_Atualizar_AtualizarNomeRotina()
        {
            //var rotina = ObterRotinaTemplate(1);

            //var repositorio = new Mock<IRotinaTemplateRepositorio>();
            //repositorio.Setup(s => s.Atualizar(rotina)).Returns(rotina);

            //var rotinaTemplateServico = new RotinaTemplateServico(repositorio.Object);
            //rotina.Nome = "K18";

            //var resultado = rotinaTemplateServico.Atualizar(rotina);

            //Assert.AreEqual("K18", resultado.Nome);
        }

        
        #region Configuracoes
        public Categoria ObterCategoria(int id)
        {
            var categorias = new List<Categoria>();

            var categoria1 = new Categoria
            {
                IdCategoria = 1,
                Nome = "Positional Play",
                Descricao = "Treinamento de precisão para a bola branca"
            };

            var categoria2 = new Categoria
            {
                IdCategoria = 2,
                Nome = "Technique",
                Descricao = "Treinamento destinado a jogadas de tecnica"
            };

            var categoria3 = new Categoria
            {
                IdCategoria = 3,
                Nome = "Cue Ball Control",
                Descricao = "Treinamento de aperfeiçoamento de controle da bola branca"
            };

            categorias.Add(categoria1);
            categorias.Add(categoria2);
            categorias.Add(categoria3);

            var resultado = categorias.Where(r => r.IdCategoria == id).FirstOrDefault();

            return resultado;
        }

        public RotinaTemplate ObterRotinaTemplate(int id)
        {
            var rotina1 = new RotinaTemplate
            {
                IdRotina = 1,
                Nome = "Six Reds",
                Categoria = ObterCategoria(1),
                Descricao = "Treino de aquecimento in-line com seis bolas",
                Meta = 75,
                TipoMeta = TipoMeta.PorPontos
            };

            var rotina2 = new RotinaTemplate
            {
                IdRotina = 2,
                Nome = "Hendry's Straight",
                Categoria = ObterCategoria(2),
                Descricao = "Treino com bolas retas para o fundo.",
                Meta = 19,
                TipoMeta = TipoMeta.PorTentativas
            };           

            var rotina3 = new RotinaTemplate
            {
                IdRotina = 3,
                Nome = "K18",
                Categoria = ObterCategoria(3),
                Descricao = "Treino com 9 bolas vermelhas e a Azul, intercalar vermelhas e azuis",
                Meta = 75,
                TipoMeta = TipoMeta.PorBolas
            };

            var rotinas = new List<RotinaTemplate>();

            rotinas.Add(rotina1);
            rotinas.Add(rotina2);
            rotinas.Add(rotina3);

            var resultado = rotinas.Where(r => r.IdRotina == id).FirstOrDefault();

            return resultado;
        }
    }
} 
#endregion
