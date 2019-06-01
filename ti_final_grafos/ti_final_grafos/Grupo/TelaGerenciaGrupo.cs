using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ti_final_grafos.Cluster;
using ti_final_grafos.Entidade;

namespace ti_final_grafos.Grupo
{
    public partial class TelaGerenciaGrupo : Form
    {
        public TelaGerenciaGrupo()
        {
            InitializeComponent();
        }

        private void btnGerarGrupos_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (TelaPrincipal.clusterPai != null && TelaPrincipal.listaAluno != null && tbTotalProfessor.Text != "" && tbTotalProfessor.Text != null)
            {
                int tamanhoCorte = Convert.ToInt32(tbTotalProfessor.Text);
                GeradorCluster clusterAtual = TelaPrincipal.clusterPai;

                if (clusterAtual.vetorCluster != null)
                {
                    while (tamanhoCorte != clusterAtual.vetorCluster.Length)
                    {

                        if (clusterAtual.vetorCluster.Length == tamanhoCorte)
                        {
                            geraGrupos(clusterAtual, TelaPrincipal.listaAluno);
                        }

                        else
                        {
                            clusterAtual = clusterAtual.clusterFilho;
                        }
                    }
                    geraGrupos(clusterAtual, TelaPrincipal.listaAluno);
                }
                else
                {
                    MessageBox.Show("Carregue os arquivos necessários e tente novamente.");
                }
            }
        }

        private void geraGrupos(GeradorCluster cluster, List<Aluno> listaAluno)
        {
            List<GrupoAluno> listaGrupo = new List<GrupoAluno>();

            for (int i = 0; i < cluster.vetorCluster.Length; i++)
            {
                List<AreaPesquisa> areaPesquisas = cluster.vetorCluster[i].listaAreaPesquisa;

                GrupoAluno grupo = new GrupoAluno();
                grupo.listaAluno = new List<Aluno>();


                foreach (AreaPesquisa item in areaPesquisas)
                {
                    foreach (Aluno aluno in listaAluno)
                    {
                        if (aluno.Id_area_pesquisa == item.Id_area_pesquisa)
                        {
                            grupo.listaAluno.Add(aluno);
                        }
                    }
                }
                listaGrupo.Add(grupo);
            }
            imprimeGrupos(listaGrupo);
        }
        private void imprimeGrupos(List<GrupoAluno> lista)
        {
            int altura = 8;
            foreach (GrupoAluno item in lista)
            {
                DataGridView dtv = new DataGridView();
                panel1.Controls.Add(dtv);
                dtv.ColumnCount = 2;

                dtv.Columns[0].Name = "Matricula";
                dtv.Columns[1].Name = "Area Pesquisa";

                foreach (Aluno aluno in item.listaAluno)
                {
                    string[] row = { aluno.Matricula.ToString(), aluno.Id_area_pesquisa.ToString() };
                    dtv.Rows.Add(row);
                }
                dtv.Location = new Point(8, altura);
                dtv.Size = new Size(300, 170);


                altura = dtv.Location.Y + dtv.Height + 5;
            }
        }

        private void tbTotalProfessor_Click(object sender, EventArgs e)
        {
            tbTotalProfessor.Text = "";
        }
    }
}
