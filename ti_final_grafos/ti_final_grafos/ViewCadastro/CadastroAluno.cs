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
        DataGridView dtvInfAlunos;
        AlunoServico alunoServico = new AlunoServico();
        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            if (tbNomeAluno.Text != "" && tbNomeAluno.Text != null && dtNascimentoAluno.Text != "" && dtNascimentoAluno.Text != null && cbCurso.SelectedItem != null)
            {
                Curso curso = (Curso)cbCurso.SelectedItem;
                Aluno aluno = new Aluno(Convert.ToDateTime(dtNascimentoAluno.Text), tbNomeAluno.Text, curso);
                alunoServico.cadastraAluno(aluno);

                MessageBox.Show("Aluno cadastrado com sucesso!");
                btnBuscarAluno_Click(sender, e);
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
            AlunoRepositorio aluno = new AlunoRepositorio();
            List<Aluno> listaAluno = new List<Aluno>();

            if (cbCurso.Text != null && cbCurso.Text != "" && tbNomeAluno.Text != null && tbNomeAluno.Text != "")
            {
                listaAluno = aluno.listaAlunoPorNomeECurso((Curso)cbCurso.SelectedItem, tbNomeAluno.Text);
                montaGridAluno(listaAluno);
            }
            else if (cbCurso.Text != null && cbCurso.Text != "")
            {
                listaAluno = aluno.listaAlunoPorCurso((Curso)cbCurso.SelectedItem);
                montaGridAluno(listaAluno);
            }
            else if (tbNomeAluno.Text != null && tbNomeAluno.Text != "")
            {
                listaAluno = aluno.listaAlunoPorNome(tbNomeAluno.Text);
                montaGridAluno(listaAluno);
            }
        }

        private void montaGridAluno(List<Aluno> lista)
        {
            panel1.Controls.Clear();

            dtvInfAlunos = new DataGridView();

            panel1.Controls.Add(dtvInfAlunos);

            dtvInfAlunos.ColumnCount = 4;

            dtvInfAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dtvInfAlunos.Size = new Size(740, 505);

            dtvInfAlunos.Columns[0].Name = "Matricula";
            dtvInfAlunos.Columns[0].Width = 80;
            dtvInfAlunos.Columns[1].Name = "Nome";
            dtvInfAlunos.Columns[1].Width = 295;
            dtvInfAlunos.Columns[2].Name = "Data Nascimento";
            dtvInfAlunos.Columns[2].Width = 110;
            dtvInfAlunos.Columns[3].Name = "Curso";
            dtvInfAlunos.Columns[3].Width = 220;

            foreach (Aluno alunoLista in lista)
            {
                string[] row = { alunoLista.Matricula.ToString(), alunoLista.Nome, alunoLista.Data_nascimento.ToString("dd-MM-yyyy"), alunoLista.Curso.Nome };
                dtvInfAlunos.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtvInfAlunos != null)
            {
                DataGridViewSelectedCellCollection selectedCells = dtvInfAlunos.SelectedCells;

                string matricula = selectedCells[0].FormattedValue.ToString();

                AlunoRepositorio aluno = new AlunoRepositorio();
                if (aluno.excluiAluno(matricula) == 1)
                {
                    MessageBox.Show("Aluno excluido com sucesso!");
                    btnBuscarAluno_Click(sender, e);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(dtvInfAlunos != null)
            {
                DataGridViewSelectedCellCollection selectedCells = dtvInfAlunos.SelectedCells;

                string matricula = selectedCells[0].FormattedValue.ToString();

                string nome = selectedCells[1].FormattedValue.ToString();

                string dataNascimento = selectedCells[2].FormattedValue.ToString();

                string curso = selectedCells[3].FormattedValue.ToString();

                CursoRepositorio cursoRepositorio = new CursoRepositorio();

                Curso objCurso = cursoRepositorio.obtemPorNome(curso);

                if(objCurso == null)
                {
                    return;
                }

                Aluno aluno = new Aluno(Convert.ToInt32(matricula), Convert.ToDateTime(dataNascimento), nome, objCurso);

                AlunoRepositorio alunoRepositorio = new AlunoRepositorio();

                if (alunoRepositorio.editaAluno(aluno) == 1)
                {
                    MessageBox.Show("Os dados do aluno foram alterados com sucesso!");
                    btnBuscarAluno_Click(sender, e);
                }

            }
        }
    }
}
