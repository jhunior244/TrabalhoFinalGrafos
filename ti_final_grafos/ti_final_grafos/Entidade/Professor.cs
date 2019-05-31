using System;
using System.Collections.Generic;
using System.Text;

namespace ti_final_grafos.Entidade
{
    class Professor : Usuario
    {
        private int matricula;
        private AreaPesquisa areaPesquisa;

        public Professor(DateTime data_nascimento, string nome) : base(nome, data_nascimento)
        {

        }
    }
}
