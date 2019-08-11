using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppModels
{
    public class RotinaViewModel
    {
        public int IdRotina { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string TipoMeta { get; set; }
        public double? Meta { get; set; }
        public double? BreakMaximo { get; set; }
        public double? Media { get; set; }
        public string Observacao { get; set; }
        public ICollection<PontuacaoViewModel> Pontos { get; set; }
    }
}
