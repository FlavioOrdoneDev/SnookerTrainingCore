using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.Entidades.Templates
{
    public class RotinaTemplate
    {
        public RotinaTemplate()
        {

        }

        public int IdRotina { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
        public TipoMeta TipoMeta { get; set; }
        public double? Meta { get; set; }
        public ICollection<Rotina> Rotinas { get; set; }
    }
}
