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
    public partial class CrudExaminador : Form
    {
        FormListaTcc formTcc;
        DataGridView dtvExaminador;

        public CrudExaminador()
        {
            InitializeComponent();
        }

        private void btnVincularTcc_Click(object sender, EventArgs e)
        {
            formTcc = new FormListaTcc();
            formTcc.Show();
        }
        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            if (tbExaminador.Text != null && tbExaminador.Text != "")
            {
                Examinador examinador = new Examinador(Convert.ToDateTime(dtNascimentoProfessor.Text), tbExaminador.Text);

                ExaminadorRepositorio professorRepositorio = new ExaminadorRepositorio();

                int retorno = professorRepositorio.cadastraExaminador(examinador);
                if(retorno == 1)
                {
                    MessageBox.Show("Examinador cadastrado com sucesso!");
                    btnBuscarExaminador_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Os dados para cadastro de um professor estão incompletos. Por favor preencha todos os campos e tente novamente.");
            }
        }

        private void montaGridExaminador(List<Examinador> lista)
        {
            panel1.Controls.Clear();

            dtvExaminador = new DataGridView();

            panel1.Controls.Add(dtvExaminador);

            dtvExaminador.ColumnCount = 3;
       
            dtvExaminador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    
            dtvExaminador.Size = new Size(760, 505);
        
            dtvExaminador.Columns[0].Name = "Matricula";
            dtvExaminador.Columns[0].Width = 80;
            dtvExaminador.Columns[1].Name = "Nome";
            dtvExaminador.Columns[1].Width = 520;
            dtvExaminador.Columns[2].Name = "Data Nascimento";
            dtvExaminador.Columns[2].Width = 110;

            foreach (Examinador examinador in lista)
            {
                string[] row = { examinador.Matricula.ToString(), examinador.Nome, examinador.Data_nascimento.ToString("dd-MM-yyyy")};
                dtvExaminador.Rows.Add(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dtvExaminador != null)
            {
                DataGridViewSelectedCellCollection selectedCells = dtvExaminador.SelectedCells;

                string matricula = selectedCells[0].FormattedValue.ToString();

                string nome = selectedCells[1].FormattedValue.ToString();

                string dataNascimento = selectedCells[2].FormattedValue.ToString();

                if(formTcc != null && formTcc.listaSelecionada != null && formTcc.listaSelecionada.Count > 0)
                {
                    ExaminadorTccRepositorio examinadorTccRepositorio = new ExaminadorTccRepositorio();

                    examinadorTccRepositorio.ligaExaminadorTcc(matricula, formTcc.listaSelecionada);
                }

                ExaminadorRepositorio examinadorRepositorio = new ExaminadorRepositorio();

                Examinador examinador = new Examinador(Convert.ToInt32(matricula), Convert.ToDateTime(dtNascimentoProfessor.Text), nome);

                if (examinadorRepositorio.editaExaminador(examinador) == 1)
                {
                    MessageBox.Show("Os dados do examinador foram alterados com sucesso!");
                    tbExaminador.Text = nome;
                    btnBuscarExaminador_Click(sender, e);
                }
            }
        }

        private void btnBuscarExaminador_Click(object sender, EventArgs e)
        {
            ExaminadorRepositorio examinadorRepositorio = new ExaminadorRepositorio();

            List<Examinador> listaExaminador = new List<Examinador>();

            if(tbExaminador.Text != null && tbExaminador.Text != "")
            {
                listaExaminador = examinadorRepositorio.listaExaminadorPorNome(tbExaminador.Text);
                montaGridExaminador(listaExaminador);
            }
            else
            {
                MessageBox.Show("Escreva um nome ou letras iniciais do nome de um examinador para procurar");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dtvExaminador != null)
            {
                DataGridViewSelectedCellCollection selectedCells = dtvExaminador.SelectedCells;

                string matricula = selectedCells[0].FormattedValue.ToString();

                ExaminadorRepositorio professorRepositorio = new ExaminadorRepositorio();
                if (professorRepositorio.excluiExaminador(matricula) == 1)
                {
                    MessageBox.Show("Examinador excluído com sucesso!");
                    btnBuscarExaminador_Click(sender, e);
                }
            }
        }
    }
}
