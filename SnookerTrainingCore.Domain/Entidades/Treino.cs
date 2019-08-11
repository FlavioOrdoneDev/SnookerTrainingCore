using SnookerTrainingCore.Domain.Entidades.Templates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.Entidades
{
    public class Treino
    {
        public Treino()
        {
           Rotinas = new List<Rotina>();
        }

        public int IdTreino { get; set; }
        public int IdTreinoTemplate { get; set; }
        public TreinoTemplate TreinoTemplate { get; set; }
        public DateTime Data { get; set; }
        public DateTime? HoraInicio { get; set; }
        public DateTime? HoraFim { get; set; }
        public TimeSpan? Duracao { get; set; }
        public string Observacao { get; set; }
        //public virtual ICollection<Resultado> Resultados { get; set; }
        public ICollection<Rotina> Rotinas { get; set; }       
    }
}
