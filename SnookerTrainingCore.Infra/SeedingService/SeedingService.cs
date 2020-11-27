using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Entidades.Templates;
using SnookerTrainingCore.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnookerTrainingCore.Infra.SeedingService
{
    public class SeedingService
    {
        private SnookerContexto _context;

        public SeedingService(SnookerContexto context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Categorias.Any() || _context.Rotinas.Any() || _context.RotinasTemplate.Any() || _context.Treinos.Any() || 
                _context.TreinosTemplate.Any() || _context.Pontuacoes.Any() || _context.Resultados.Any())
            {
                return;
            }

            Categoria c1 = new Categoria("Positional Play", "Descrição categoria 1");
            Categoria c2 = new Categoria("Safety", "Descrição categoria 2");
            Categoria c3 = new Categoria("Technique", "Descrição categoria 3");

            RotinaTemplate rt1 = new RotinaTemplate { Nome = "Six Reds", Descricao = "Descrição RT 1", Categoria = c1, TipoMeta = TipoMeta.PorPontos, Meta = 75 };
            RotinaTemplate rt2 = new RotinaTemplate { Nome = "K118", Descricao = "Descrição RT 2", Categoria = c2, TipoMeta = TipoMeta.PorBolas, Meta = 70 };
            RotinaTemplate rt3 = new RotinaTemplate { Nome = "k75", Descricao = "Descrição RT 3", Categoria = c3, TipoMeta = TipoMeta.PorTentativas, Meta = 50 };

            TreinoTemplate tt1 = new TreinoTemplate { Nome = "Treino de Positional Play", Descricao = "Descrição Treino 1" };
            TreinoTemplate tt2 = new TreinoTemplate { Nome = "Treino de Defesa", Descricao = "Descrição Treino 2" };
            TreinoTemplate tt3 = new TreinoTemplate { Nome = "Treino de Técnica", Descricao = "Descrição Treino 3" };

            Treino t1 = new Treino 
            { 
                TreinoTemplate = tt1, 
                HoraInicio = new DateTime(2020, 09, 15, 09, 00, 00), 
                HoraFim = new DateTime(2020, 09, 15, 12, 00, 00), 
                Observacao = "Observação treino positional play 1", 
                Data = new DateTime(2020, 09, 15) 
            };
            Treino t2 = new Treino
            {
                TreinoTemplate = tt2,
                HoraInicio = new DateTime(2020, 09, 15, 09, 00, 00),
                HoraFim = new DateTime(2020, 09, 15, 12, 00, 00),
                Observacao = "Observação treino defesa 1",
                Data = new DateTime(2020, 09, 15)
            };
            Treino t3 = new Treino
            {
                TreinoTemplate = tt3,
                HoraInicio = new DateTime(2020, 09, 15, 09, 00, 00),
                HoraFim = new DateTime(2020, 09, 15, 12, 00, 00),
                Observacao = "Observação treino técnica 1",
                Data = new DateTime(2020, 09, 15)
            };

            Rotina r1 = new Rotina
            {
                RotinaTemplate = rt1,
                HoraInicio = new DateTime(2020, 09, 15, 10, 00, 00),
                HoraFim = new DateTime(2020, 09, 15, 10, 40, 00),
                Observacao = "Observação rotina 1",
                BreakMaximo = 70,
                Treino = t1

            };
            Rotina r2 = new Rotina
            {
                RotinaTemplate = rt2,
                HoraInicio = new DateTime(2020, 09, 15, 10, 00, 00),
                HoraFim = new DateTime(2020, 09, 15, 10, 40, 00),
                Observacao = "Observação rotina 1",
                BreakMaximo = 70,
                Treino = t2

            };
            Rotina r3 = new Rotina
            {
                RotinaTemplate = rt3,
                HoraInicio = new DateTime(2020, 09, 15, 10, 00, 00),
                HoraFim = new DateTime(2020, 09, 15, 10, 40, 00),
                Observacao = "Observação rotina 1",
                BreakMaximo = 70,
                Treino = t3

            };

            _context.Categorias.AddRange(c1, c2, c3);

            _context.RotinasTemplate.AddRange(rt1, rt2, rt3);

            _context.TreinosTemplate.AddRange(tt1, tt2, tt3);

            _context.Treinos.AddRange(t1, t2, t3);

            _context.Rotinas.AddRange(r1, r2, r3);

            _context.SaveChanges();
        }        
    }
}
