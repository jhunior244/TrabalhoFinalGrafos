using System;
using System.Collections.Generic;
using System.Text;

namespace ti_final_grafos.Entidade
{
    class Tcc
    {
        private int id_tcc;
        private string versão_tcc;
        private TipoTcc tipoTcc;
        private Tema tema;
        private double nota;
        private List<Examinador> listaExaminador;
    }
}
