namespace SnookerTrainingCore.Domain.Entidades
{
    public class Pontuacao
    {
        public Pontuacao() { }

        public Pontuacao(double pontos)
        {
            this.Pontos = pontos;
        }

        public int IdPontuacao { get; set; }
        public double Pontos { get; set; }
        public bool MatouTodasAsBolas { get; set; }
        public int IdRotina { get; set; }
        public virtual Rotina Rotina { get; set; }
    }
}