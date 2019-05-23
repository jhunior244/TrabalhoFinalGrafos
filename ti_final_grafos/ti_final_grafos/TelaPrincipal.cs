using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ti_final_grafos.Cluster;
using ti_final_grafos.Data;
using ti_final_grafos.Entidade;
using ti_final_grafos.Grupo;
using ti_final_grafos.LeituraArquivo;
using ti_final_grafos.Repositorio;
using ti_final_grafos.Servico;
using ti_final_grafos.ViewCadastro;

namespace ti_final_grafos
{
    public partial class TelaPrincipal : Form
    {
        public static List<Aluno> listaAluno = new List<Aluno>();
        public static GeradorCluster clusterPai = new GeradorCluster();

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CursoRepositorio cursoRepositorio = new CursoRepositorio();
            cursoRepositorio.buscaCurso();
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroAluno cadastroAluno = new CadastroAluno();
            cadastroAluno.Show();
        }

        private void matrizDissimilaridadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "(*.txt)|*.txt";
            openFile.ShowDialog();

            StreamReader streamReader = new StreamReader(openFile.FileName);

            LeituraArquivoDissimilaridade leituraArquivoDissimilaridade = new LeituraArquivoDissimilaridade();
            Dissimilaridade[,] matriz = leituraArquivoDissimilaridade.setaMatrizDissimilaridade(streamReader);
            GeradorCluster gerador = new GeradorCluster();
            clusterPai = gerador.setaCluster(matriz);
        }

        private void arquivoAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "(*.txt)|*.txt";
            openFile.ShowDialog();

            StreamReader streamReader = new StreamReader(openFile.FileName);

            LeituraArquivoAluno leituraArquivoAluno = new LeituraArquivoAluno();
            listaAluno = leituraArquivoAluno.setaListaAluno(streamReader);
        }

        private void gerarGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaGerenciaGrupo telaGerenciaGrupo = new TelaGerenciaGrupo();
            telaGerenciaGrupo.Show();
        }
    }
}
