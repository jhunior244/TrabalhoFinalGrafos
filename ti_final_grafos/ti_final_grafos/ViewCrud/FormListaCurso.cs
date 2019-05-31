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
using static System.Windows.Forms.ListBox;

namespace ti_final_grafos.ViewCrud
{
    public partial class FormListaCurso : Form
    {
        public List<Curso> listaSelecionada = new List<Curso>();
        public FormListaCurso()
        {
            InitializeComponent();
            preencheListaCursos();
        }

        private void FormListaCurso_Load(object sender, EventArgs e)
        {

        }

        private void preencheListaCursos()
        {
            if (checkCurso.Items.Count == 0)
            {
                CursoRepositorio cursoRepositorio = new CursoRepositorio();
                List<Curso> lista = cursoRepositorio.buscaCurso();

                lista.ForEach(delegate (Curso curso)
                {
                    checkCurso.Items.Add(curso);
                });
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            foreach(object item in checkCurso.CheckedItems)
            {
                Curso cursoSelecionado = (Curso)item;
                listaSelecionada.Add(cursoSelecionado);
            }
            this.Close();
        }
    }
}
