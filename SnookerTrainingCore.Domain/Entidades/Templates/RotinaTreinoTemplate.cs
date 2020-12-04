using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.Entidades.Templates
{
    public class RotinaTreinoTemplate
    {        
        public int IdRotina { get; set; }
        public RotinaTemplate RotinaTemplate { get; set; }

        public int IdTreino { get; set; }
        public TreinoTemplate TreinoTemplate { get; set; }
    }
}
