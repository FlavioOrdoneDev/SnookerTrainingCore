using System;
using System.Collections.Generic;
using System.Text;

namespace SnookerTrainingCore.ApplicationService.AppModels
{
    public class CategoriaViewModel
    {
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public string DescricaoCategoria { get; set; }
        public ICollection<RotinaViewModel> Rotinas { get; set; }
    }
}
