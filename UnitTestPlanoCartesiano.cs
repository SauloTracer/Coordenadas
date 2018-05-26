using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coordenadas;
using System.Collections.Generic;

namespace TesteCoordenadas
{
    [TestClass]
    public class UnitTestPlanoCartesiano
    {
        [TestMethod]
        public void ValidaMovimentoCoordenada()
        {
            PlanoCartesiano planoCartesiano = new PlanoCartesiano(new Coordenada(8, 12));

            List<KeyValuePair<Vetor, Coordenada>> vetores = new List<KeyValuePair<Vetor, Coordenada>>();

            Vetor vetor;
            Coordenada destino;
            KeyValuePair<Vetor, Coordenada> vetorDestino;

            vetor = new Vetor(Direcao.N, 23);
            destino = new Coordenada(8, 35);
            vetorDestino = new KeyValuePair<Vetor, Coordenada>(vetor, destino);
            vetores.Add(vetorDestino);

            vetor = new Vetor(Direcao.O, 7);
            destino = new Coordenada(1, 35);
            vetorDestino = new KeyValuePair<Vetor, Coordenada>(vetor, destino);
            vetores.Add(vetorDestino);

            vetor = new Vetor(Direcao.S, 40);
            destino = new Coordenada(1, -5);
            vetorDestino = new KeyValuePair<Vetor, Coordenada>(vetor, destino);
            vetores.Add(vetorDestino);

            vetor = new Vetor(Direcao.L, 33);
            destino = new Coordenada(34, -5);
            vetorDestino = new KeyValuePair<Vetor, Coordenada>(vetor, destino);
            vetores.Add(vetorDestino);

            vetor = new Vetor(Direcao.N, 15);
            destino = new Coordenada(34, 10);
            vetorDestino = new KeyValuePair<Vetor, Coordenada>(vetor, destino);
            vetores.Add(vetorDestino);

            foreach (KeyValuePair<Vetor, Coordenada> item in vetores)
            {
                planoCartesiano.AdicionarVetor(item.Key);
                Assert.Equals(planoCartesiano.PosicaoAtual, item.Value);
            }

            Assert.Equals(planoCartesiano.PosicaoAtual, new Coordenada(34,10));
        }
    }
}
