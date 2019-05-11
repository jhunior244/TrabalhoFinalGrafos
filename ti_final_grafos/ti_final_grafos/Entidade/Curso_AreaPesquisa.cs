using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti_final_grafos.Entidade
{
    class Curso_AreaPesquisa
    {
        private Curso curso;

        private AreaPesquisa areaPesquisa;

        public Curso_AreaPesquisa(Curso curso, AreaPesquisa areaPesquisa)
        {
            this.curso = curso;
            this.areaPesquisa = areaPesquisa;
        }
    }
}
