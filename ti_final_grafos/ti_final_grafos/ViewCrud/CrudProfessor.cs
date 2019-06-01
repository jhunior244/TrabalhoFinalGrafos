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

namespace ti_final_grafos.ViewCrud
{
    public partial class CrudProfessor : Form
    {
        FormListaAreaPesquisa formAreaPesquisa;
        FormListaCurso formCurso;
        DataGridView dtvProfessor;

        public CrudProfessor()
        {
            InitializeComponent();
        }

        private void btnVincularCurso_Click(object sender, EventArgs e)
        {
            formCurso = new FormListaCurso();
            formCurso.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            formAreaPesquisa = new FormListaAreaPesquisa();
            formAreaPesquisa.Show();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            if (tbProfessor.Text != null && tbProfessor.Text != "")
            {
                Professor professor = new Professor(Convert.ToDateTime(dtNascimentoProfessor.Text), tbProfessor.Text);

                ProfessorRepositorio professorRepositorio = new ProfessorRepositorio();

                string matricula = professorRepositorio.cadastraProfessor(professor);

                if (matricula != null && matricula != "")
                {
                    ProfessorAreaPesquisaRepositorio professorAreaPesquisaRepositorio = new ProfessorAreaPesquisaRepositorio();

                    ProfessorCursoRepositorio professorCursoRepositorio = new ProfessorCursoRepositorio();

                    professorAreaPesquisaRepositorio.ligaProfessorAreaPesquisa(matricula, formAreaPesquisa.listaSelecionada);

                    professorCursoRepositorio.ligaProfessorCurso(matricula, formCurso.listaSelecionada);
                }
                MessageBox.Show("Professor cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Os dados para cadastro de um professor estão incompletos. Por favor preencha todos os campos e tente novamente.");
            }
        }

        private void btnBuscarAluno_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProfessor_Click(object sender, EventArgs e)
        {
            ProfessorRepositorio professorRepositorio = new ProfessorRepositorio();
            List<Professor> listaProfessor = new List<Professor>();

            if (tbProfessor.Text != null && tbProfessor.Text != "")
            {
                listaProfessor = professorRepositorio.listaProfessorPorNome(tbProfessor.Text);
                montaGridProfessor(listaProfessor);

            }
        }

        private void montaGridProfessor(List<Professor> lista)
        {
            panel1.Controls.Clear();

            dtvProfessor = new DataGridView();

            panel1.Controls.Add(dtvProfessor);

            dtvProfessor.ColumnCount = 3;

            dtvProfessor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dtvProfessor.Size = new Size(760, 505);

            dtvProfessor.Columns[0].Name = "Matricula";
            dtvProfessor.Columns[0].Width = 80;
            dtvProfessor.Columns[1].Name = "Nome";
            dtvProfessor.Columns[1].Width = 520;
            dtvProfessor.Columns[2].Name = "Data Nascimento";
            dtvProfessor.Columns[2].Width = 110;

            foreach (Professor professor in lista)
            {
                string[] row = { professor.Matricula.ToString(), professor.Nome, professor.Data_nascimento.ToString("dd-MM-yyyy")};
                dtvProfessor.Rows.Add(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dtvProfessor != null)
            {
                DataGridViewSelectedCellCollection selectedCells = dtvProfessor.SelectedCells;

                string matricula = selectedCells[0].FormattedValue.ToString();

                ProfessorRepositorio professorRepositorio = new ProfessorRepositorio();
                if (professorRepositorio.excluiProfessor(matricula) == 1)
                {
                    MessageBox.Show("Professor excluído com sucesso!");
                    btnBuscarProfessor_Click(sender, e);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dtvProfessor != null)
            {
                DataGridViewSelectedCellCollection selectedCells = dtvProfessor.SelectedCells;

                string matricula = selectedCells[0].FormattedValue.ToString();

                string nome = selectedCells[1].FormattedValue.ToString();

                string dataNascimento = selectedCells[2].FormattedValue.ToString();

                Professor professor = new Professor(Convert.ToInt32(matricula), Convert.ToDateTime(dataNascimento), nome);

                ProfessorRepositorio professorRepositorio = new ProfessorRepositorio();

                if (professorRepositorio.editaProfessor(professor) == 1)
                {
                    MessageBox.Show("Os dados do professor foram alterados com sucesso!");
                    btnBuscarAluno_Click(sender, e);
                }
            }
        }
    }
}
