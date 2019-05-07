using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ti_final_grafos
{
    class LeituraArquivo
    {
        public void lerMatrizDissimilaridade(StreamReader streamReader)
        {
            string linha = streamReader.ReadLine();
            string[] dados = linha.Split(';');
            int[,] matrizDissimilaridade = new int[dados.Length, dados.Length];
            int limiteDoFor = dados.Length;
            int linhaMatriz = 0;
            while (!streamReader.EndOfStream)
            {

                gravaDadosMatriz(linhaMatriz, matrizDissimilaridade, dados);
                linha = streamReader.ReadLine();
                dados = linha.Split(';');
                linhaMatriz++;
            }
            
        }
        private void gravaDadosMatriz(int linha, int[,] matrizDissimilaridade, string[] dados)
        {
            for (int coluna = 0; coluna < dados.Length; coluna++)
            {
                matrizDissimilaridade[linha, coluna] = int.Parse(dados[coluna]);
            }
        }
    }
}
