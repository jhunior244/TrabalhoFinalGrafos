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
    public partial class FormListaTcc : Form
    {
        public List<Tcc> listaSelecionada = new List<Tcc>();
        public FormListaTcc()
        {
            InitializeComponent();
            preencheListaTccs();
        }

        private void FormListaCurso_Load(object sender, EventArgs e)
        {

        }

        private void preencheListaTccs()
        {
            if (checkTcc.Items.Count == 0)
            {
                TccRepositorio tccRepositorio = new TccRepositorio();
                List<Tcc> lista = tccRepositorio.listaTcc();

                lista.ForEach(delegate (Tcc tcc)
                {
                    checkTcc.Items.Add(tcc);
                });
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            foreach(object item in checkTcc.CheckedItems)
            {
                Tcc tccSelecionado = (Tcc)item;
                listaSelecionada.Add(tccSelecionado);
            }
            this.Close();
        }
    }
}
