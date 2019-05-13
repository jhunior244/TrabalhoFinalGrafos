using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ti_final_grafos.Data;
using ti_final_grafos.Entidade;
using ti_final_grafos.Repositorio;
using ti_final_grafos.Servico;

namespace ti_final_grafos
{
    public partial class TelaPrincipal : Form
    {
        

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CursoAreaPesquisaRepositorio cursoTeste = new CursoAreaPesquisaRepositorio();
            cursoTeste.ligaCursoAreaPesquisa("filosofia", "testes");
        }
    }
}
