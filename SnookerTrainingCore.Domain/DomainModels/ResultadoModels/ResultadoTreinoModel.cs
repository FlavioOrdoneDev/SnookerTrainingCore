using SnookerTrainingCore.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.Domain.DomainModels.ResultadoModels
{
    public class ResultadoTreinoModel
    {
        public int IdResultado { get; set; }
        public int IdTreino { get; set; }
        public string NomeTreino { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public int? Duracao { get; set; }
        public string Observacao { get; set; }
        public virtual IList<ResultadoRotinaModel> ResultadoRotinas { get; set; }
    }
}
