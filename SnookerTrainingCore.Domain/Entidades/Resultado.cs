using System;
using System.Collections.Generic;

namespace SnookerTrainingCore.Domain.Entidades
{
    public class Resultado
    {
        public Resultado()
        {
            
        }

        public int IdResultado { get; set; }
        public DateTime Data { get; set; }
        public string Observacao { get; set; }

    }
}
