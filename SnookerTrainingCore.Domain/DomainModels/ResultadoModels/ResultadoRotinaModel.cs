using SnookerTrainingCore.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.DomainModels.ResultadoModels
{
    public class ResultadoRotinaModel
    {
        public int IdRotina { get; set; }
        public string NomeRotina { get; set; }
        public string NomeCategoria { get; set; }
        public string Descricao { get; set; }
        public double? Meta { get; set; }
        public double? BreakMaximo { get; set; }
        public double? Media { get; set; }
        public int? Duracao { get; set; }
        public string Observacao { get; set; }
        public virtual IList<Pontuacao> Pontos { get; set; }
    }
}
