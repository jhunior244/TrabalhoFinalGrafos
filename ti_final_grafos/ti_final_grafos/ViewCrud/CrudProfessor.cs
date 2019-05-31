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

                ProfessorAreaPesquisaRepositorio repositorio = new ProfessorAreaPesquisaRepositorio();

                repositorio.ligaProfessorAreaPesquisa(matricula, formAreaPesquisa.listaSelecionada);
            }
        }
    }
}
