using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ti_final_grafos.Entidade;

namespace ti_final_grafos.LeituraArquivo
{
    class LeituraArquivoAluno
    {
        private List<Aluno> listaAluno;

        public List<Aluno> ListaAluno { get => this.listaAluno; }

        public List<Aluno> setaListaAluno(StreamReader streamReader)
        {
            listaAluno = new List<Aluno>();
            string linha = streamReader.ReadLine();

            while (linha != null)
            {
                string[] dados = linha.Split(';');

                if (dados.Length == 2)
                {
                    int matricula = int.Parse(dados[0]);
                    int id_area = int.Parse(dados[1]);
                    Aluno aluno = new Aluno(matricula, id_area);
                    listaAluno.Add(aluno);
                }
                linha = streamReader.ReadLine();
            }
            return this.ListaAluno;
        }
    }
}
