using SnookerTrainingCore.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.DomainModels.RotinaModels
{
    public class RotinaModel
    {
        public int IdRotina { get; set; }
        public string Nome { get; set; }
        public string NomeCategoria { get; set; }
        //public TipoMeta TipoMeta { get; set; }
        public double? Meta { get; set; }
        public string Descricao { get; set; }
        public IList<Pontuacao> Resultados { get; set; }
    }
}
