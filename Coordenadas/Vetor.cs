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

        public override string ToString()
        {
            char letra;
            switch (this.Direcao)
            {
                case Direcao.S:
                    letra = 'S';
                    break;
                case Direcao.L:
                    letra = 'L';
                    break;
                case Direcao.O:
                    letra = 'O';
                    break;
                case Direcao.N:
                default:
                    letra = 'N';
                    break;
            }

            return string.Format("({0},{1})", letra, intensidade);
        }
    }
}