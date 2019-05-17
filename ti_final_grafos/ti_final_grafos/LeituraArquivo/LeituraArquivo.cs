using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ti_final_grafos.Entidade;
using ti_final_grafos.Cluster;

namespace ti_final_grafos
{
    class LeituraArquivo
    {
        public void lerMatrizDissimilaridade(StreamReader streamReader)
        {
            string linha = streamReader.ReadLine();
            string[] dados = linha.Split(';');

            Dissimilaridade[,] matrizDissimilaridade = new Dissimilaridade[dados.Length, dados.Length];

            AreaPesquisa[] vetorAreaPesquisa = new AreaPesquisa[dados.Length];

            criaVetorDissimilaridade(vetorAreaPesquisa);

            int limiteDoFor = dados.Length;
            int linhaMatriz = 0;
            int colunaMatriz = 0;
            while (linha != null)
            {
                gravaDadosMatriz(colunaMatriz, linhaMatriz, vetorAreaPesquisa, matrizDissimilaridade, dados);
                linha = streamReader.ReadLine();

                if (linha != null)
                {
                    dados = linha.Split(';');
                    linhaMatriz++;
                    colunaMatriz++;
                }
            }
            GeradorCluster cluster = new GeradorCluster();
            cluster.setaCluster(matrizDissimilaridade);
        }
        private void criaVetorDissimilaridade(AreaPesquisa[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                AreaPesquisa areaPesquisa = new AreaPesquisa(i + 1);
                vetor[i] = areaPesquisa;
            }
        }
        private void gravaDadosMatriz(int colunaMatriz, int linha, AreaPesquisa[] vetorAreaPesquisa, Dissimilaridade[,] matrizDissimilaridade, string[] dados)
        {
            int indiceDados = 0;
            for (int i = 0; i < dados.Length; i++)
            {
                Dissimilaridade dissimilaridade = new Dissimilaridade(vetorAreaPesquisa[linha], vetorAreaPesquisa[colunaMatriz], int.Parse(dados[indiceDados]));
                matrizDissimilaridade[linha, colunaMatriz] = dissimilaridade;
                indiceDados++;
                colunaMatriz++;
            }
        }
    }
}
