using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.Entidades
{
    public class TreinoRotina
    {
        public int IdRotina { get; set; }
        public Rotina Rotina { get; set; }

        public int IdTreino { get; set; }
        public Treino Treino { get; set; }
    }
}
