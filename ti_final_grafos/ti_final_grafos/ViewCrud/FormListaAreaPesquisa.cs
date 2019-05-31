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
    public partial class FormListaAreaPesquisa : Form
    {
        public List<AreaPesquisa> listaSelecionada = new List<AreaPesquisa>();
        public FormListaAreaPesquisa()
        {
            InitializeComponent();
            preencheListaAreaPesquisa();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            foreach (object item in checkAreaPesquisa.CheckedItems)
            {
                AreaPesquisa areaPesquisaSelecionada = (AreaPesquisa)item;
                listaSelecionada.Add(areaPesquisaSelecionada);
            }
            this.Close();
        }

        private void preencheListaAreaPesquisa()
        {
            if (checkAreaPesquisa.Items.Count == 0)
            {
                AreaPesquisaRepositorio areaRepositorio = new AreaPesquisaRepositorio();
                List<AreaPesquisa> lista = areaRepositorio.listaAreaPesquisa();

                lista.ForEach(delegate (AreaPesquisa areaPesquisa)
                {
                    checkAreaPesquisa.Items.Add(areaPesquisa);
                });
            }
        }
    }
}
