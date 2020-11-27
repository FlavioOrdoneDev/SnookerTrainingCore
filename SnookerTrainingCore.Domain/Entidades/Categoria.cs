using SnookerTrainingCore.Domain.Entidades.Templates;
using System.Collections.Generic;

namespace SnookerTrainingCore.Domain.Entidades
{
    public class Categoria
    {
        public Categoria() { }

        public Categoria(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public int IdCategoria { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public ICollection<RotinaTemplate> RotinasTemplate { get; set; }
    }
}