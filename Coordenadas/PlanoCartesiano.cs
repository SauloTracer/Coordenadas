using System;

namespace Coordenadas
{
    public class PlanoCartesiano
    {
        private Coordenada origem;
        private Coordenada posicaoAtual;

        public PlanoCartesiano (Coordenada origem)
        {
            Origem = origem;
            PosicaoAtual = Origem;
        }

        public PlanoCartesiano(Coordenada origem, Coordenada posicaoAtual) : this(origem)
        {
            PosicaoAtual = posicaoAtual;
        }

        public Coordenada Origem { get => origem; set => origem = value; }
        public Coordenada PosicaoAtual { get => posicaoAtual; set => posicaoAtual = value; }

        public Coordenada AdicionarVetor(Vetor vetor)
        {
            switch (vetor.Direcao)
            {
                case Direcao.N:
                    //Norte => Adicionar intensidade do vetor ao eixo Y (Para cima)
                    PosicaoAtual.Y += vetor.Intensidade;
                    break;
                case Direcao.S:
                    //Sul => Remover intensidade do vetor do eixo Y - (Para baixo)
                    PosicaoAtual.Y -= vetor.Intensidade;
                    break;
                case Direcao.L:
                    //Leste => Adicionar intensidade do vetor ao eixo X - (Para a direita)
                    PosicaoAtual.X += vetor.Intensidade;
                    break;
                case Direcao.O:
                    //Norte => Remover intensidade do vetor do eixo X - (Para a esquerda)
                    PosicaoAtual.X -= vetor.Intensidade;
                    break;
            }
            
            return PosicaoAtual;
        }
    }
}
