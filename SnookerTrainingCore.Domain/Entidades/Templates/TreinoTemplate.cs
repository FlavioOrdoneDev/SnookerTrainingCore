using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.Entidades.Templates
{
   public class TreinoTemplate
   {
        public TreinoTemplate()
        {
            RotinaTreinoTemplate = new List<RotinaTreinoTemplate>();
        }

        public int IdTreino { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public ICollection<Treino> Treinos { get; set; } = new List<Treino>();
        public ICollection<RotinaTreinoTemplate> RotinaTreinoTemplate { get; set; }
    }
}
