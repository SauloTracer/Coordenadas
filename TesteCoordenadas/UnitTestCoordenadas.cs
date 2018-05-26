using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coordenadas;
using System.Collections.Generic;

namespace TesteCoordenadas
{
    [TestClass]
    public class UnitTestCoordenadas
    {
        [TestMethod]
        public void CasoDeTeste1()
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

            string mensagemDeErro;
            foreach (KeyValuePair<Vetor, Coordenada> item in vetores)
            {
                planoCartesiano.AdicionarVetor(item.Key);
                mensagemDeErro = "Posição atual " + planoCartesiano.PosicaoAtual.ToString() + " diferente da esperada " + item.Value.ToString() + " após aplicação do vetor " + vetor.ToString() + ".";
                Assert.AreEqual(planoCartesiano.PosicaoAtual.ToString(), item.Value.ToString(), mensagemDeErro);
            }

            Coordenada posicaoFinal = new Coordenada(34, 10);
            Assert.AreEqual(planoCartesiano.PosicaoAtual.ToString(), posicaoFinal.ToString(), "Posição final " + planoCartesiano.PosicaoAtual.ToString() + " diferente da esperada " + posicaoFinal + ".");
        }

        [TestMethod]
        public void CasoDeTeste2()
        {
            PlanoCartesiano planoCartesiano = new PlanoCartesiano(new Coordenada(-10, 0));

            List<KeyValuePair<Vetor, Coordenada>> vetores = new List<KeyValuePair<Vetor, Coordenada>>();

            Vetor vetor;
            Coordenada destino;
            KeyValuePair<Vetor, Coordenada> vetorDestino;

            vetor = new Vetor(Direcao.L, 14);
            destino = new Coordenada(4, 0);
            vetorDestino = new KeyValuePair<Vetor, Coordenada>(vetor, destino);
            vetores.Add(vetorDestino);

            vetor = new Vetor(Direcao.N, 27);
            destino = new Coordenada(4, 27);
            vetorDestino = new KeyValuePair<Vetor, Coordenada>(vetor, destino);
            vetores.Add(vetorDestino);

            vetor = new Vetor(Direcao.O, 33);
            destino = new Coordenada(-29, 27);
            vetorDestino = new KeyValuePair<Vetor, Coordenada>(vetor, destino);
            vetores.Add(vetorDestino);

            vetor = new Vetor(Direcao.S, 20);
            destino = new Coordenada(-29, 7);
            vetorDestino = new KeyValuePair<Vetor, Coordenada>(vetor, destino);
            vetores.Add(vetorDestino);

            vetor = new Vetor(Direcao.L, 15);
            destino = new Coordenada(-14, 7);
            vetorDestino = new KeyValuePair<Vetor, Coordenada>(vetor, destino);
            vetores.Add(vetorDestino);

            string mensagemDeErro;
            foreach (KeyValuePair<Vetor, Coordenada> item in vetores)
            {
                planoCartesiano.AdicionarVetor(item.Key);
                mensagemDeErro = "Posição atual " + planoCartesiano.PosicaoAtual.ToString() + " diferente da esperada " + item.Value.ToString() + " após aplicação do vetor " + vetor.ToString() + ".";
                Assert.AreEqual(planoCartesiano.PosicaoAtual.ToString(), item.Value.ToString(), mensagemDeErro);
            }

            Coordenada posicaoFinal = new Coordenada(-14, 7);
            Assert.AreEqual(planoCartesiano.PosicaoAtual.ToString(), posicaoFinal.ToString(), "Posição final " + planoCartesiano.PosicaoAtual.ToString() + " diferente da esperada " + posicaoFinal + ".");
        }
    }
}
