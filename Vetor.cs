namespace Coordenadas
{
    public class Vetor
    {
        private Direcao direcao;
        private int intensidade;
        private Coordenada origem;

        public Direcao Direcao { get => direcao; set => direcao = value; }
        public int Intensidade { get => intensidade; set => intensidade = value; }
        public Coordenada Origem { get => origem; set => origem = value; }

        public Vetor(Coordenada origem, Direcao direcao, int intensidade)
        {
            Origem = origem;
            Direcao = direcao;
            Intensidade = intensidade;
        }
    }
}