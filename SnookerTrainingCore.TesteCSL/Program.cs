using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Entidades.Templates;
using System;
using System.Collections.Generic;

namespace SnookerTrainingCore.TesteCSL
{
    class Program
    {
        static void Main(string[] args)
        {

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

            // Positional Play -------------------------------------------------

            var rotina1 = new RotinaTemplate
            {
                IdRotina = 1,
                Nome = "Six Reds",
                Descricao = "Descrição rotina",
                Categoria = categoria1,
                TipoMeta = TipoMeta.PorPontos,
                Meta = 75                
            };

            var rotina2 = new RotinaTemplate
            {
                IdRotina = 2,
                Nome = "K118",
                Descricao = "Descrição rotina",
                Categoria = categoria1,
                TipoMeta = TipoMeta.PorPontos,
                Meta = 75
            };

            var rotina3 = new RotinaTemplate
            {
                IdRotina = 3,
                Nome = "K75",
                Descricao = "Descrição rotina",
                Categoria = categoria1,
                TipoMeta = TipoMeta.PorPontos,
                Meta = 75
            };

            var treinoPositional = new TreinoTemplate
            {
                IdTreino = 1,
                Nome = "Positional Play",
                //Data = DateTime.Now,
                //Duracao = 2,
                Descricao = "Descrição treino"
                //Observacao = "Treino foi bem tranquilo, muitas metas batidas"
            };

            //treinoPositional.Rotinas.Add(rotina1);
            //treinoPositional.Rotinas.Add(rotina2);
            //treinoPositional.Rotinas.Add(rotina3);

            // Safety --------------------------------------------------------------------------------

            var rotina4 = new RotinaTemplate
            {
                IdRotina = 4,
                Nome = "Defence",
                Descricao = "Descrição rotina",
                Categoria = categoria1,
                TipoMeta = TipoMeta.PorPontos,
                Meta = 75
            };

            var rotina5 = new RotinaTemplate
            {
                IdRotina = 5,
                Nome = "K120",
                Descricao = "Descrição rotina",
                Categoria = categoria1,
                TipoMeta = TipoMeta.PorPontos,
                Meta = 75
            };

            var rotina6 = new RotinaTemplate
            {
                IdRotina = 6,
                Nome = "K50",
                Descricao = "Descrição rotina",
                Categoria = categoria1,
                TipoMeta = TipoMeta.PorPontos,
                Meta = 75
            };

            var treinoSafety = new TreinoTemplate
            {
                IdTreino = 2,
                Nome = "Safety",
                //Data = DateTime.Now,
                //Duracao = 2,
                Descricao = "Descrição treino"
                //Observacao = "Treino foi bem tranquilo, muitas metas batidas"
            };

            //treinoSafety.Rotinas.Add(rotina4);
            //treinoSafety.Rotinas.Add(rotina5);
            //treinoSafety.Rotinas.Add(rotina6);


            // Cue Ball Control --------------------------------------------------------------------------------

            var rotina7 = new RotinaTemplate
            {
                IdRotina = 7,
                Nome = "K20",
                Descricao = "Descrição rotina",
                Categoria = categoria3,
                TipoMeta = TipoMeta.PorPontos,
                Meta = 75
            };

            var rotina8 = new RotinaTemplate
            {
                IdRotina = 8,
                Nome = "K80",
                Descricao = "Descrição rotina",
                Categoria = categoria3,
                TipoMeta = TipoMeta.PorPontos,
                Meta = 75
            };

            var rotina9 = new RotinaTemplate
            {
                IdRotina = 9,
                Nome = "K01",
                Descricao = "Descrição rotina",
                Categoria = categoria3,
                TipoMeta = TipoMeta.PorPontos,
                Meta = 75
            };

            var treinoCueBall = new TreinoTemplate
            {
                IdTreino = 3,
                Nome = "Cue Ball Control",
                //Data = DateTime.Now,
                //Duracao = 2,
                Descricao = "Descrição treino"
                //Observacao = "Treino foi bem tranquilo, muitas metas batidas"
            };

            //treinoCueBall.Rotinas.Add(rotina7);
            //treinoCueBall.Rotinas.Add(rotina8);
            //treinoCueBall.Rotinas.Add(rotina9);


            List<TreinoTemplate> treinos = new List<TreinoTemplate>();

            treinos.Add(treinoPositional);
            treinos.Add(treinoSafety);
            treinos.Add(treinoCueBall);

            int i = 1;
            //int j = 1;
            foreach (var treino in treinos)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Treino " + i);
                Console.WriteLine("");
                Console.WriteLine(" Nome      : " + treino.Nome);
                //Console.WriteLine(" Data      : " + treino.Data);
                //Console.WriteLine(" Duração   : " + treino.Duracao);
                Console.WriteLine(" Meta      : " + treino.Descricao);
                //Console.WriteLine(" Descrição : " + treino.Observacao);

                //foreach (var rotina in treinoPositional.Rotinas)
                //{
                //    Console.WriteLine("\t-------------------------------");
                //    Console.WriteLine("");
                //    Console.WriteLine("\t Rotina " + j);
                //    Console.WriteLine("");
                //    Console.WriteLine("\t   Nome      : " + rotina.Nome);
                //    Console.WriteLine("\t   Categoria : " + rotina.Categoria.Nome);
                //    Console.WriteLine("\t   Tipo meta : " + rotina.TipoMeta);
                //    //Console.WriteLine("\t   Meta      : " + rotina.Meta);
                //    Console.WriteLine("\t   Descrição : " + rotina.Descricao);

                //    j++;
                //}

                i++;
            }
            

            Console.ReadKey();
        }
    }
}
