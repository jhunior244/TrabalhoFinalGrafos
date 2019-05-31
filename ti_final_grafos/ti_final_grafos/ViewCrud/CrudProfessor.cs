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
        FormListaAreaPesquisa formAreaPesquisa = new FormListaAreaPesquisa();
        FormListaCurso formCurso = new FormListaCurso();
        DataGridView dtvProfessor;

        public CrudProfessor()
        {
            InitializeComponent();
        }

        private void btnVincularCurso_Click(object sender, EventArgs e)
        {
            formCurso.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            formAreaPesquisa.Show();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            if(tbProfessor.Text != null && tbProfessor.Text != "")
            {
                Professor professor = new Professor(Convert.ToDateTime(dtNascimentoProfessor.Text), tbProfessor.Text);

                ProfessorRepositorio professorRepositorio = new ProfessorRepositorio();
                string matricula = professorRepositorio.cadastraProfessor(professor);

                ProfessorAreaPesquisaRepositorio professorAreaPesquisaRepositorio = new ProfessorAreaPesquisaRepositorio();

                ProfessorCursoRepositorio professorCursoRepositorio = new ProfessorCursoRepositorio();

                professorAreaPesquisaRepositorio.ligaProfessorAreaPesquisa(matricula, formAreaPesquisa.listaSelecionada);

                professorCursoRepositorio.ligaProfessorCurso(matricula, formCurso.listaSelecionada);
            }
        }

        private void btnBuscarAluno_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            dtvProfessor = new DataGridView();

            panel1.Controls.Add(dtvProfessor);

            dtvProfessor.ColumnCount = 3;

            dtvProfessor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dtvProfessor.Size = new Size(740, 505);

            dtvProfessor.Columns[0].Name = "Matricula";
            dtvProfessor.Columns[0].Width = 80;
            dtvProfessor.Columns[1].Name = "Nome";
            dtvProfessor.Columns[1].Width = 295;
            dtvProfessor.Columns[2].Name = "Data Nascimento";
            dtvProfessor.Columns[2].Width = 110;

            foreach (Aluno alunoLista in lista)
            {
                string[] row = { alunoLista.Matricula.ToString(), alunoLista.Nome, alunoLista.Data_nascimento.ToString("dd-MM-yyyy"), alunoLista.Curso.Nome };
                dtvInfAlunos.Rows.Add(row);
            }
        }
    }
}
