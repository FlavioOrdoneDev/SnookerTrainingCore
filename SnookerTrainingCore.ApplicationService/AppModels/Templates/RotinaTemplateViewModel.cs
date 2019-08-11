using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppModels.Templates
{
    public class RotinaTemplateViewModel
    {
        public int IdRotina { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string TipoMeta { get; set; }
        public double? Meta { get; set; }
    }
}
