using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ti_final_grafos.Entidade;

namespace ti_final_grafos.Cluster
{
    class GeradorCluster
    {
        public List<AreaPesquisa> listaAreaPesquisa = new List<AreaPesquisa>();
        public GeradorCluster[] vetorCluster;
        public GeradorCluster clusterPai;
        public GeradorCluster clusterFilho;
        public int distanciaCluster;
        //public int corteCluster = int.MaxValue;//talvez nao use

        public GeradorCluster setaCluster(Dissimilaridade[,] matrizDissimilaridade)
        {
            GeradorCluster[,] matrizCluster = geraMatrizCluster(matrizDissimilaridade);
            geraCluster(matrizCluster);

            
            return null;
        }
        private GeradorCluster[,] geraMatrizCluster(Dissimilaridade[,] matrizDissimilaridade)
        {
            int dimensaoMatriz = (int)Math.Sqrt(matrizDissimilaridade.Length);
            GeradorCluster[,] novaMatriz = new GeradorCluster[dimensaoMatriz, dimensaoMatriz];

            for (int i = 0; i < dimensaoMatriz; i++)
            {
                for (int j = 0; j < dimensaoMatriz; j++)
                {
                    if (matrizDissimilaridade[i, j] != null)
                    {
                        GeradorCluster cluster = new GeradorCluster();
                        cluster.listaAreaPesquisa.Add(matrizDissimilaridade[i, j].AreaPesquisa);
                        cluster.listaAreaPesquisa.Add(matrizDissimilaridade[i, j].AreaPesquisaCorrespondente);
                        cluster.distanciaCluster = matrizDissimilaridade[i, j].Grau;
                        novaMatriz[i, j] = cluster;
                    }
                }
            }
            return novaMatriz;
        }

        private void geraCluster(GeradorCluster[,] matrizCluster)
        {
            int tamanhoVetorCluster = int.MaxValue;
            while (tamanhoVetorCluster > 1)
            {
                if (this.clusterPai == null)
                {
                    this.clusterPai = new GeradorCluster();
                    this.clusterPai.clusterPai = null;
                    tamanhoVetorCluster = (int)Math.Sqrt(matrizCluster.Length);
                    this.clusterPai.vetorCluster = new GeradorCluster[tamanhoVetorCluster];
                    for (int i = 0; i < tamanhoVetorCluster; i++)
                    {
                        this.clusterPai.vetorCluster[i] = new GeradorCluster();
                        this.clusterPai.vetorCluster[i].listaAreaPesquisa = new List<AreaPesquisa>();
                        this.clusterPai.vetorCluster[i].listaAreaPesquisa.Add(matrizCluster[0, i].listaAreaPesquisa[1]);
                        //this.clusterPai.corteCluster = tamanhoVetorCluster;
                    }
                }

                else
                {
                    int[] indiceMenorDissimilaridade = buscaMenorDissimilaridade(matrizCluster);
                    GeradorCluster[,] matrizFilha = setaMatrizFilha(matrizCluster, indiceMenorDissimilaridade[0], indiceMenorDissimilaridade[1]);
                    matrizCluster = null;
                    matrizCluster = matrizFilha;
                    tamanhoVetorCluster--;
                    GeradorCluster ultimoclusterPai = buscaUltimoClusterPai(this.clusterPai);
                    ultimoclusterPai.clusterFilho = new GeradorCluster();
                    ultimoclusterPai.clusterFilho.vetorCluster = new GeradorCluster[tamanhoVetorCluster];

                    for (int i = 0; i < matrizFilha.GetLength(0); i++)
                    {
                        ultimoclusterPai.clusterFilho.vetorCluster[i] = new GeradorCluster();
                        ultimoclusterPai.clusterFilho.vetorCluster[i].listaAreaPesquisa = new List<AreaPesquisa>();
                        ultimoclusterPai.clusterFilho.vetorCluster[i].listaAreaPesquisa.AddRange(matrizFilha[i, i].listaAreaPesquisa);
                    }
                }
            }
        }

        private GeradorCluster buscaUltimoClusterPai(GeradorCluster clusterPai)
        {
            GeradorCluster ultimoPaiEncontrado = clusterPai;
            while (ultimoPaiEncontrado.clusterFilho != null)
            {

                if (ultimoPaiEncontrado.clusterFilho == null)
                {
                    ultimoPaiEncontrado = clusterPai;
                }
                else
                {
                    ultimoPaiEncontrado = ultimoPaiEncontrado.clusterFilho;
                }
            }
            return ultimoPaiEncontrado;
        }

        private int[] buscaMenorDissimilaridade(GeradorCluster[,] matrizCluster)
        {
            int dissimilaridade = int.MaxValue;
            int linhaMenorDissimilaridade = 0;
            int colunaMenorDissimilaridade = 0;
            int coluna = 1;
            for (int i = 0; i < matrizCluster.GetLength(0); i++)
            {
                for (int j = coluna; j < matrizCluster.GetLength(1); j++)
                {
                    if (matrizCluster[i, j] != null && dissimilaridade > matrizCluster[i, j].distanciaCluster)
                    {
                        linhaMenorDissimilaridade = i;
                        colunaMenorDissimilaridade = j;
                        dissimilaridade = matrizCluster[i, j].distanciaCluster;
                    }
                }
                coluna++;
            }
            int[] indiceMenorDissimilaridade = new int[] { linhaMenorDissimilaridade, colunaMenorDissimilaridade };
            return indiceMenorDissimilaridade;
        }

        public GeradorCluster[,] setaMatrizFilha(GeradorCluster[,] matrizCluster, int linhaMenorDistanciaCluster, int colunaMenorDistanciaCluster)
        {
            int tamanhoMatriz = (int)Math.Sqrt(matrizCluster.Length);
            GeradorCluster[,] novaMatriz = new GeradorCluster[tamanhoMatriz - 1, tamanhoMatriz - 1];
            novaMatriz[0, 0] = new GeradorCluster();
            novaMatriz[0, 0].listaAreaPesquisa = new List<AreaPesquisa>();
            novaMatriz[0, 0].listaAreaPesquisa.AddRange(matrizCluster[linhaMenorDistanciaCluster, colunaMenorDistanciaCluster].listaAreaPesquisa);

            setaPrimeiraLinhaMatrizFilha(novaMatriz, linhaMenorDistanciaCluster, colunaMenorDistanciaCluster, matrizCluster);
            setaRestoMatrizFilha(novaMatriz, linhaMenorDistanciaCluster, colunaMenorDistanciaCluster, matrizCluster);

            return novaMatriz;
        }

        private void setaPrimeiraLinhaMatrizFilha(GeradorCluster[,] novaMatriz, int linhaMenorDistanciaCluster, int colunaMenorDistanciaCluster, GeradorCluster[,] matrizCluster)
        {
            int[] vetorDissimilaridadeClusterUm = new int[(int)Math.Sqrt(matrizCluster.Length)];
            int[] vetorDissimilaridadeClusterDois = new int[(int)Math.Sqrt(matrizCluster.Length)];
            int posicaoPrimeiroCluster = linhaMenorDistanciaCluster;
            int posicaoSegundoCluster = colunaMenorDistanciaCluster;

            for (int i = 0; i < colunaMenorDistanciaCluster; i++)
            {
                vetorDissimilaridadeClusterUm[i] = matrizCluster[i, posicaoPrimeiroCluster].distanciaCluster;
            }
            for (int i = colunaMenorDistanciaCluster; i < matrizCluster.GetLength(0); i++)
            {
                vetorDissimilaridadeClusterUm[i] = matrizCluster[posicaoPrimeiroCluster, i].distanciaCluster;
            }

            for (int i = 0; i < colunaMenorDistanciaCluster; i++)
            {
                vetorDissimilaridadeClusterDois[i] = matrizCluster[i, posicaoSegundoCluster].distanciaCluster;
            }
            for (int i = colunaMenorDistanciaCluster; i < matrizCluster.GetLength(0); i++)
            {
                vetorDissimilaridadeClusterDois[i] = matrizCluster[posicaoSegundoCluster, i].distanciaCluster;
            }

            for (int i = 0; i < matrizCluster.GetLength(0); i++)
            {
                if(vetorDissimilaridadeClusterUm[i] > 0 && vetorDissimilaridadeClusterDois[i] > 0)
                {
                    int distanciaCluster = Convert.ToInt32((vetorDissimilaridadeClusterUm[i] + vetorDissimilaridadeClusterDois[i]) * 0.5);
                    novaMatriz[0, i -1] = new GeradorCluster();
                    novaMatriz[0, i -1].listaAreaPesquisa = new List<AreaPesquisa>();
                    novaMatriz[0, i -1].listaAreaPesquisa.AddRange(novaMatriz[0, 0].listaAreaPesquisa);
                    foreach (AreaPesquisa item in matrizCluster[0,i].listaAreaPesquisa)
                    {
                        if(!novaMatriz[0,i - 1].listaAreaPesquisa.Contains(item))
                        {
                            novaMatriz[0, i - 1].listaAreaPesquisa.Add(item);
                        }
                    }
                    novaMatriz[0, i -1].distanciaCluster = distanciaCluster;
                }
            }

        }

        private void setaRestoMatrizFilha(GeradorCluster[,] novaMatriz, int linhaMenorDistanciaCluster, int colunaMenorDistanciaCluster, GeradorCluster[,] matrizCluster)
        {
            int linhaNovaMatriz = 0;
            int colunaNovaMatriz = 0;

            for (int i = 0; i < matrizCluster.GetLength(0); i++)
            {
                for (int j = 0; j < matrizCluster.GetLength(0); j++)
                {
                    if(i != linhaMenorDistanciaCluster && i != colunaMenorDistanciaCluster && j != linhaMenorDistanciaCluster && j != colunaMenorDistanciaCluster
                        && matrizCluster[i,j] != null)
                    {
                        setaClusterMatriz(novaMatriz, matrizCluster[i, j].listaAreaPesquisa, matrizCluster[i,j].distanciaCluster);
                    }
                }
            }
        }

        private void setaClusterMatriz(GeradorCluster[,] novaMatriz, List<AreaPesquisa> lista, int distanciaCluster)
        {
            int auxiliarDiagonal = 0;
            for (int i = 0; i < novaMatriz.GetLength(0); i++)
            {
                for (int j = auxiliarDiagonal; j < novaMatriz.GetLength(0); j++)
                {
                    if(novaMatriz[i,j] == null)
                    {
                        novaMatriz[i, j] = new GeradorCluster();
                        novaMatriz[i, j].listaAreaPesquisa = new List<AreaPesquisa>();
                        novaMatriz[i, j].listaAreaPesquisa.AddRange(lista);
                        novaMatriz[i, j].distanciaCluster = distanciaCluster;
                        return;
                    }
                }
                auxiliarDiagonal++;
            }
        }
    }
}
