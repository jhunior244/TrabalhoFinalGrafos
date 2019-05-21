using System;
using System.Collections.Generic;
using System.Text;

namespace ti_final_grafos.Entidade
{
    public class Dissimilaridade
    {
        private int id_dissimilaridade;
        private AreaPesquisa areaPesquisa;
        private AreaPesquisa areaPesquisaCorrespondente;
        private int grau;

        public int Grau { get => grau; set => grau = value; }
        public AreaPesquisa AreaPesquisa { get => areaPesquisa; set => areaPesquisa = value; }
        public AreaPesquisa AreaPesquisaCorrespondente { get => areaPesquisaCorrespondente; set => areaPesquisaCorrespondente = value; }

        public Dissimilaridade(AreaPesquisa areaPesquisa, AreaPesquisa areaPesquisaCorrespondente, int grau)
        {
            this.areaPesquisa = areaPesquisa;
            this.areaPesquisaCorrespondente = areaPesquisaCorrespondente;
            this.grau = grau;
        }

        
    }
}
