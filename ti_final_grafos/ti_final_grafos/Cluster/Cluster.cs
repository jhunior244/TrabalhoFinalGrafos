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
        public int corteCluster = int.MaxValue;//talvez nao use

        public GeradorCluster setaCluster(Dissimilaridade[,] matrizDissimilaridade)
        {
            GeradorCluster[,] matrizCluster = geraMatrizCluster(matrizDissimilaridade);
            geraCluster(matrizCluster);

            //while (corteCluster > 1)
            //{
            //    cluster = new Cluster();
            //    //cluster.vetorCluster
            //    //vetorCluster = new Cluster[(int)Math.Sqrt(matrizDissimilaridade.Length)];
            //    //setaVetorCluster(vetorCluster, matrizDissimilaridade);
            //}


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
                    if(matrizDissimilaridade[i,j] != null)
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
            while(tamanhoVetorCluster > 0)
            {
                if (clusterPai == null)
                {
                    clusterPai = new GeradorCluster();
                    tamanhoVetorCluster = (int)Math.Sqrt(matrizCluster.Length);
                    clusterPai.vetorCluster = new GeradorCluster[tamanhoVetorCluster];
                    for (int i = 0; i < tamanhoVetorCluster; i++)
                    {
                        clusterPai.vetorCluster[i] = new GeradorCluster();
                        clusterPai.vetorCluster[i].listaAreaPesquisa = new List<AreaPesquisa>();
                        clusterPai.vetorCluster[i].listaAreaPesquisa.Add(matrizCluster[0, i].listaAreaPesquisa[1]);
                        clusterPai.corteCluster = tamanhoVetorCluster;
                    }
                }

                else
                {
                  int[] indiceMenorDissimilaridade =  buscaMenorDissimilaridade(matrizCluster);
                }
            }
        }

        private int[] buscaMenorDissimilaridade(GeradorCluster[,] matrizCluster)
        {
            int dissimilaridade = int.MaxValue;
            int linhaMenorDissimilaridade = 0;
            int colunaMenorDissimilaridade = 0;
            for (int i = 0; i < matrizCluster.GetLength(0); i++)
            {
                for (int j = 0; j < matrizCluster.GetLength(1); j++)
                {
                    if(matrizCluster[i,j] != null && dissimilaridade > matrizCluster[i,j].distanciaCluster && 
                        matrizCluster[i, j].distanciaCluster > 0)
                    {
                        linhaMenorDissimilaridade = i;
                        colunaMenorDissimilaridade = j;
                    }
                }
            }
            int[] indiceMenorDissimilaridade = new int[] { linhaMenorDissimilaridade, colunaMenorDissimilaridade };
            return indiceMenorDissimilaridade;
        }

        public GeradorCluster setaClusterFilho(GeradorCluster[,] matrizCluster, GeradorCluster clusterPai)
        {
            int tamanhoMatriz = (int)Math.Sqrt(matrizCluster.Length);
            GeradorCluster[,] novaMatriz = new GeradorCluster[tamanhoMatriz - 1, tamanhoMatriz - 1];




            return null;
        }
    }
}
