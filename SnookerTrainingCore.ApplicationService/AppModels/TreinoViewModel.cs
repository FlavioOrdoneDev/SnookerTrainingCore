using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppModels
{
    public class TreinoViewModel
    {
        public int IdTreino { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public DateTime? HoraInicio { get; set; }
        public DateTime? HoraFim { get; set; }
        public TimeSpan? Duracao { get; set; }
        public string Observacao { get; set; }
        public ICollection<RotinaViewModel> Rotinas { get; set; }
    }
}
