using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SnookerTrainingCore.Domain.Entidades.Templates;

namespace SnookerTrainingCore.Domain.Entidades
{
    public class Rotina
    {
        public Rotina()
        {
            
        }

        public int IdRotina { get; set; }
        public int IdRotinaTemplate { get; set; }
        public RotinaTemplate RotinaTemplate { get; set; }        
        public DateTime? HoraInicio { get; set; }
        public DateTime? HoraFim { get; set; }
        public TimeSpan? Duracao { get; set; }       
        public double? BreakMaximo { get; set; }
        public double? Media { get; set; }
        public string Observacao { get; set; }
        public int IdTreino { get; set; }
        public Treino Treino { get; set; }
        public virtual ICollection<Pontuacao> Pontos { get; set; } = new List<Pontuacao>();

    public double ObterMedia()
        {
            if (Pontos != null)
                return Pontos.Sum(x => x.Pontos) / Pontos.Count;
            return 0;
        }

        public double ObterBreakMaximo()
        {
            if (Pontos != null)
                return Pontos.Max(x => x.Pontos);
            return 0;
        }

        public double ObterBreakMinimo()
        {
            if (Pontos != null)
                return Pontos.Min(x => x.Pontos);
            return 0;
        }

    }
}

