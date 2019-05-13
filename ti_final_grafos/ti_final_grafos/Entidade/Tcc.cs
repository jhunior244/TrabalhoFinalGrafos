using System;
using System.Collections.Generic;
using System.Text;

namespace ti_final_grafos.Entidade
{
    class Tcc
    {
        private int id_tcc;
        private string versao_tcc;
        private TipoTcc tipoTcc;
        private Tema tema;
        private double nota;
        private List<Examinador> listaExaminador;

        public Tcc(int id_tcc, string versao_tcc, TipoTcc tipo, Tema tema)
        {
            this.id_tcc = id_tcc;
            this.versao_tcc = versao_tcc;
            this.tipoTcc = tipo;
            this.tema = tema;//ftytysdsd
        }
    }
}
