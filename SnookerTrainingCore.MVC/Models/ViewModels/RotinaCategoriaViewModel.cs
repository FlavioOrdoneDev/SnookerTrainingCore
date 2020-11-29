using SnookerTrainingCore.Domain.Entidades;
using SnookerTrainingCore.Domain.Entidades.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnookerTrainingCore.MVC.Models.ViewModels
{
    public class RotinaCategoriaViewModel
    {
        public RotinaTemplate RotinaTemplate { get; set; }
        public IEnumerable<Categoria> Categorias { get; set; }
    }
}
