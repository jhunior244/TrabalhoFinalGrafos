using System;
using System.Collections.Generic;
using System.Text;

namespace ti_final_grafos.Entidade
{
    public class Tcc
    {
        private int id_tcc;
        private string versao_tcc;
        private TipoTcc tipoTcc;
        private Tema tema;
        private double nota;
        private List<Examinador> listaExaminador;

        public Tcc(int id_tcc, Tema tema)
        {
            this.Id_tcc = id_tcc;
            this.Tema = tema;
        }

        public int Id_tcc { get => id_tcc; set => id_tcc = value; }
        public Tema Tema { get => tema; set => tema = value; }

        public override string ToString()
        {
            return Id_tcc.ToString() + " " + Tema.Titulo_tema;
        }
    }
}
