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

        public GeradorCluster setaCluster(Dissimilaridade[,] matrizDissimilaridade)
        {
            GeradorCluster[,] matrizCluster = geraMatrizCluster(matrizDissimilaridade);
            geraCluster(matrizCluster);

            return this.clusterPai;
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
                        if (matrizDissimilaridade[i, j].AreaPesquisa.Equals(matrizDissimilaridade[i, j].AreaPesquisaCorrespondente))
                        {
                            cluster.listaAreaPesquisa.Add(matrizDissimilaridade[i, j].AreaPesquisa);
                            novaMatriz[i, j] = cluster;
                        }
                        else
                        {
                            cluster.listaAreaPesquisa.Add(matrizDissimilaridade[i, j].AreaPesquisa);
                            cluster.listaAreaPesquisa.Add(matrizDissimilaridade[i, j].AreaPesquisaCorrespondente);
                            cluster.distanciaCluster = matrizDissimilaridade[i, j].Grau;
                            novaMatriz[i, j] = cluster;
                        }
                    }
                }
            }
            return novaMatriz;
        }

        private void geraCluster(GeradorCluster[,] matrizCluster)
        {
            int tamanhoVetorCluster = int.MaxValue;
            while (tamanhoVetorCluster > 1)
            {   //se o pai ainda nao tiver sido iniciado, gera o primeiro cluster com todas areas de pesquisa disponiveis em seu vetor de cluster
                if (this.clusterPai == null)
                {
                    int coluna = 0;
                    this.clusterPai = new GeradorCluster();
                    this.clusterPai.clusterPai = null;
                    tamanhoVetorCluster = (int)Math.Sqrt(matrizCluster.Length);
                    this.clusterPai.vetorCluster = new GeradorCluster[tamanhoVetorCluster];
                    for (int linha = 0; linha < tamanhoVetorCluster; linha++)
                    {
                        this.clusterPai.vetorCluster[linha] = new GeradorCluster();
                        this.clusterPai.vetorCluster[linha].listaAreaPesquisa = new List<AreaPesquisa>();
                        this.clusterPai.vetorCluster[linha].listaAreaPesquisa.Add(matrizCluster[linha, coluna].listaAreaPesquisa[0]);
                        coluna++;
                    }
                }

                else
                {   //busca cluster com menor grau de dissimilaridade para setar cluster filho
                    int[] indiceMenorDissimilaridade = buscaIndiceMenorDissimilaridade(matrizCluster);
                    GeradorCluster[,] matrizFilha = setaMatrizFilha(matrizCluster, indiceMenorDissimilaridade[0], indiceMenorDissimilaridade[1]);
                    matrizCluster = null;
                    matrizCluster = matrizFilha;
                    tamanhoVetorCluster--;
                    GeradorCluster ultimoclusterPai = buscaUltimoClusterPai(this.clusterPai);
                    ultimoclusterPai.clusterFilho = new GeradorCluster();
                    ultimoclusterPai.clusterFilho.vetorCluster = new GeradorCluster[tamanhoVetorCluster];

                    for (int i = 0; i < matrizFilha.GetLength(0); i++)
                    {   //seta cluster filho com todos clusters da diagonal da matriz (o tamanho do vetorCluster, determina o grau de corte desse cluster)
                        ultimoclusterPai.clusterFilho.vetorCluster[i] = new GeradorCluster();
                        ultimoclusterPai.clusterFilho.vetorCluster[i].listaAreaPesquisa = new List<AreaPesquisa>();
                        ultimoclusterPai.clusterFilho.vetorCluster[i].listaAreaPesquisa.AddRange(matrizFilha[i, i].listaAreaPesquisa);
                    }
                }
            }
        }

        private GeradorCluster buscaUltimoClusterPai(GeradorCluster clusterPai)
        {   //busca o ultimo pai para a fila de clusters
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

        private int[] buscaIndiceMenorDissimilaridade(GeradorCluster[,] matrizCluster)
        {   //busca a posicao do cluster com menor distancia para ser o novo cluster a ser unido
            //(ignora os clusters da diagonal principal)
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

        private GeradorCluster[,] setaMatrizFilha(GeradorCluster[,] matrizCluster, int linhaMenorDistanciaCluster, int colunaMenorDistanciaCluster)
        {   //cria uma nova matriz com tamanho de linha e coluna uma unidade menor que a matriz atual
            int tamanhoMatriz = (int)Math.Sqrt(matrizCluster.Length);
            GeradorCluster[,] novaMatriz = new GeradorCluster[tamanhoMatriz - 1, tamanhoMatriz - 1];
            //seta nova matriz a partir das cordenadas do menor cluster encontradas
            adicionaEBuscaClusterComLigacaoNovoCluster(novaMatriz, linhaMenorDistanciaCluster, colunaMenorDistanciaCluster, matrizCluster);
            buscaClusterSemLigacaoComNovoCluster(novaMatriz, linhaMenorDistanciaCluster, colunaMenorDistanciaCluster, matrizCluster);

            return novaMatriz;
        }

        private void adicionaEBuscaClusterComLigacaoNovoCluster(GeradorCluster[,] novaMatriz, int linhaMenorDistanciaCluster, int colunaMenorDistanciaCluster, GeradorCluster[,] matrizCluster)
        {
            //une cluster mais proximo e o coloca na primeira posição da matriz
            novaMatriz[0, 0] = new GeradorCluster();
            novaMatriz[0, 0].listaAreaPesquisa = new List<AreaPesquisa>();
            novaMatriz[0, 0].listaAreaPesquisa.AddRange(matrizCluster[linhaMenorDistanciaCluster, linhaMenorDistanciaCluster].listaAreaPesquisa);
            foreach (AreaPesquisa item in matrizCluster[colunaMenorDistanciaCluster, colunaMenorDistanciaCluster].listaAreaPesquisa)
            {
                if (!novaMatriz[0, 0].listaAreaPesquisa.Contains(item))
                {
                    novaMatriz[0, 0].listaAreaPesquisa.Add(item);
                    novaMatriz[0, 0].distanciaCluster = 0;
                }
            }
            //busca todos os outros clusters e calcula sua distancia para o novo cluster
            int coluna = 0;
            for (int linha = 0; linha < matrizCluster.GetLength(0); linha++)
            {
                if (linha != linhaMenorDistanciaCluster && coluna != colunaMenorDistanciaCluster)
                {
                    setaClusterComNovoCluster(novaMatriz, linhaMenorDistanciaCluster, colunaMenorDistanciaCluster, linha, matrizCluster);
                }
                coluna++;
            }
        }

        private void setaClusterComNovoCluster(GeradorCluster[,] novaMatriz, int linhaMenorDistanciaCluster, int colunaMenorDistanciaCluster, int posicaoClusterPraAdicionar, GeradorCluster[,] matrizCluster)
        {   //pega distancia do cluster atual para o primeiro cluster da nova ligação
            int distanciaParaClusterUm = 0;
            if (posicaoClusterPraAdicionar < linhaMenorDistanciaCluster)
            {
                distanciaParaClusterUm = matrizCluster[posicaoClusterPraAdicionar, linhaMenorDistanciaCluster].distanciaCluster;
            }
            else
            {
                distanciaParaClusterUm = matrizCluster[linhaMenorDistanciaCluster, posicaoClusterPraAdicionar].distanciaCluster;
            }
            //pega distancia do cluster atual para o segundo cluster da nova ligação
            int distanciaParaClusterDois = 0;
            if (posicaoClusterPraAdicionar < colunaMenorDistanciaCluster)
            {
                distanciaParaClusterDois = matrizCluster[posicaoClusterPraAdicionar, colunaMenorDistanciaCluster].distanciaCluster;
            }
            else
            {
                distanciaParaClusterDois = matrizCluster[colunaMenorDistanciaCluster, posicaoClusterPraAdicionar].distanciaCluster;
            }
            //calcula sua distancia para o novo cluster e o adiciona na primeira posição vazia da primeira linha da nova matriz
            for (int coluna = 1; coluna < novaMatriz.GetLength(0); coluna++)
            {
                if (novaMatriz[0, coluna] == null)
                {
                    int distancia = Convert.ToInt32((distanciaParaClusterUm + distanciaParaClusterDois) * 0.5);
                    GeradorCluster novoCluster = new GeradorCluster();
                    novoCluster.listaAreaPesquisa = new List<AreaPesquisa>();
                    novoCluster.listaAreaPesquisa.AddRange(matrizCluster[0, 0].listaAreaPesquisa);
                    novoCluster.listaAreaPesquisa.AddRange(matrizCluster[posicaoClusterPraAdicionar, posicaoClusterPraAdicionar].listaAreaPesquisa);
                    novoCluster.distanciaCluster = distancia;
                    novaMatriz[0, coluna] = novoCluster;
                    return;
                }
            }
        }

        private void buscaClusterSemLigacaoComNovoCluster(GeradorCluster[,] novaMatriz, int linhaMenorDistanciaCluster, int colunaMenorDistanciaCluster, GeradorCluster[,] matrizCluster)
        {
            for (int i = 0; i < matrizCluster.GetLength(0); i++)
            {
                for (int j = 0; j < matrizCluster.GetLength(0); j++)
                {   //busca todos clusters que nao tem ligação com o novo cluster para os adicionar na nova matriz
                    if (i != linhaMenorDistanciaCluster && i != colunaMenorDistanciaCluster && j != linhaMenorDistanciaCluster && j != colunaMenorDistanciaCluster
                        && matrizCluster[i, j] != null)
                    {
                        setaClusterSemLigacaoComNovoCluster(novaMatriz, matrizCluster[i, j].listaAreaPesquisa, matrizCluster[i, j].distanciaCluster);
                    }
                }
            }
        }

        private void setaClusterSemLigacaoComNovoCluster(GeradorCluster[,] novaMatriz, List<AreaPesquisa> lista, int distanciaCluster)
        {
            int auxiliarDiagonal = 1;
            for (int i = 1; i < novaMatriz.GetLength(0); i++)
            {
                for (int j = auxiliarDiagonal; j < novaMatriz.GetLength(0); j++)
                {   //busca uma posicao da matriz que esteja vazia, sempre andando na metade a direita da diagonal
                    if (novaMatriz[i, j] == null)
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
