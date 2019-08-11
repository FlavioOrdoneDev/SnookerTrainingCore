using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppModels
{
    public class PontuacaoViewModel
    {
        public int IdPontuacao { get; set; }
        public double Pontos { get; set; }

        public bool MatouTodasAsBolas { get; set; }
    }
}
