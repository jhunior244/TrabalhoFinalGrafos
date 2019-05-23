using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ti_final_grafos.Entidade;
using ti_final_grafos.Repositorio;
using ti_final_grafos.Servico;

namespace ti_final_grafos.ViewCadastro
{
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }
        AlunoServico alunoServico = new AlunoServico();
        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            if (tbNomeAluno.Text != "" && tbNomeAluno.Text != null && dtNascimentoAluno.Text != "" && dtNascimentoAluno.Text != null && cbCurso.SelectedItem != null)
            {
                Curso curso = (Curso)cbCurso.SelectedItem;
                Aluno aluno = new Aluno(Convert.ToDateTime(dtNascimentoAluno.Text), tbNomeAluno.Text, curso);
                alunoServico.cadastraAluno(aluno);

                MessageBox.Show("Aluno cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Os dados para cadastro de um aluno estão incompletos. Por favor preencha todos os campos e tente novamente.");
            }
        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {

        }

        private void cbCurso_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbCurso.Items.Count == 0)
            {
                CursoRepositorio cursoRepositorio = new CursoRepositorio();
                List<Curso> lista = cursoRepositorio.buscaCurso();

                lista.ForEach(delegate (Curso curso)
                {
                    cbCurso.Items.Add(curso);
                });
            }
        }

        private void btnBuscarAluno_Click(object sender, EventArgs e)
        {
            if ((tbNomeAluno.Text != null && tbNomeAluno.Text != "") || (cbCurso.Text != null && cbCurso.Text != ""))
            {
                AlunoRepositorio aluno = new AlunoRepositorio();
                List<Aluno> listaAluno = aluno.listaAlunoPorCurso((Curso)cbCurso.SelectedItem);

                dtvInfAlunos.ColumnCount = 3;

                dtvInfAlunos.Columns[0].Name = "Nome";
                dtvInfAlunos.Columns[1].Name = "Data Nascimento";
                dtvInfAlunos.Columns[2].Name = "Curso";

                foreach (Aluno alunoLista in listaAluno)
                {
                    string[] row = { alunoLista.Nome, alunoLista.Data_nascimento.ToString("dd-MM-yyyy"), alunoLista.Curso.Nome };
                    dtvInfAlunos.Rows.Add(row);
                }

            }
        }
    }
}
