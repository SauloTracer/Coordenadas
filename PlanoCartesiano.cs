using System;

namespace Coordenadas
{
    public class PlanoCartesiano
    {
        private Coordenada origem;
        private Coordenada posicaoAtual;
        private Coordenada limiteX = new Coordenada(Int32.MinValue, Int32.MaxValue); 
        private Coordenada limiteY = new Coordenada(Int32.MinValue, Int32.MaxValue);

        public PlanoCartesiano(Coordenada origem, Coordenada posicaoAtual, Coordenada limiteX, Coordenada limiteY)
        {
            this.limiteX = limiteX;
            this.limiteY = limiteY;
            this.origem = origem;
            this.posicaoAtual = posicaoAtual;
        }

        public PlanoCartesiano(Coordenada origem, Coordenada limiteX, Coordenada limiteY)
        {
            this.limiteX = limiteX;
            this.limiteY = limiteY;
            this.origem = origem;
            posicaoAtual = this.origem;
        }

        public PlanoCartesiano (Coordenada origem)
        {
            this.origem = origem;
            posicaoAtual = this.origem;
        }

        public Coordenada AdicionarVetor(Vetor vetor)
        {
            switch (vetor.Direcao)
            {
                case Direcao.N:
                    //Norte => Adicionar intensidade do vetor ao eixo Y (Para cima)
                    posicaoAtual.Y += vetor.Intensidade;
                    break;
                case Direcao.S:
                    //Sul => Remover intensidade do vetor do eixo Y - (Para baixo)
                    posicaoAtual.Y -= vetor.Intensidade;
                    break;
                case Direcao.L:
                    //Leste => Adicionar intensidade do vetor ao eixo X - (Para a direita)
                    posicaoAtual.X += vetor.Intensidade;
                    break;
                case Direcao.O:
                    //Norte => Remover intensidade do vetor do eixo X - (Para a esquerda)
                    posicaoAtual.X -= vetor.Intensidade;
                    break;
            }
            
            return posicaoAtual;
        }
    }
}
