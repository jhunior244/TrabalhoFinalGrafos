using System;
using System.Collections.Generic;
using System.Text;

namespace ti_final_grafos.Entidade
{
    public class TipoTcc
    {
        private int id_tipo_tcc;
        private string nome;
        
        public TipoTcc(int id_tipo_tcc, string nome)
        {
            this.id_tipo_tcc = id_tipo_tcc;
            this.nome = nome;
        }
    }
}
