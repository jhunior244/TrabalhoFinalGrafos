using System;
using System.Collections.Generic;
using System.Text;

namespace ti_final_grafos.Entidade
{
    public class Tema
    {
        private int id_tema;
        private string titulo_tema;
        private AreaPesquisa areaPesquisa;

        public int Id_tema { get => id_tema; set => id_tema = value; }
        public string Titulo_tema { get => titulo_tema; set => titulo_tema = value; }
        public AreaPesquisa AreaPesquisa { get => areaPesquisa; set => areaPesquisa = value; }

        public Tema(string titulo)
        {
            this.titulo_tema = titulo;
        }
    }
}
