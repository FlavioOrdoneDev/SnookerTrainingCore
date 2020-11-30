using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Entidades.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnookerTrainingCore.MVC.Models.ViewModels
{
    public class TreinoRotinaViewModel
    {
        public Treino Treino { get; set; }
        public IEnumerable<TreinoTemplate> TreinosTemplate { get; set; }
        public IEnumerable<RotinaTemplate> RotinasTemplate { get; set; }
    }
}
