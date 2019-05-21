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
            if(tbNomeAluno.Text != "" && tbNomeAluno.Text != null && dtNascimentoAluno.Text != "" && dtNascimentoAluno.Text != null)
            {
                Aluno aluno = new Aluno(Convert.ToDateTime(dtNascimentoAluno.Text), tbNomeAluno.Text);
                alunoServico.cadastraAluno(aluno);
            }
        }
    }
}
