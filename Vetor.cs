namespace Coordenadas
{
    public class Vetor
    {
        private Direcao direcao;
        private int intensidade;

        public Direcao Direcao { get => direcao; set => direcao = value; }
        public int Intensidade { get => intensidade; set => intensidade = value; }

        public Vetor(Direcao direcao, int intensidade)
        {
            Direcao = direcao;
            Intensidade = intensidade;
        }
    }
}
