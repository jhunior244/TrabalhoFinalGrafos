using System;
using System.Collections.Generic;
using System.Text;

namespace ti_final_grafos.Entidade
{
    public class AreaPesquisa
    {
        private int id_area_pesquisa;

        private string nome;

        private List<Curso_AreaPesquisa> listaCurso_AreaPesquisa;

        public int Id_area_pesquisa { get => id_area_pesquisa; }
        public string Nome { get => nome; }
        public List<Curso_AreaPesquisa> ListaCurso_AreaPesquisa { get => listaCurso_AreaPesquisa; }

        public AreaPesquisa(int id_area, string nome)
        {
            this.id_area_pesquisa = id_area;
            this.nome = nome;
        }

        public AreaPesquisa(int id_area)
        {
            this.id_area_pesquisa = id_area;
        }

        public override string ToString()
        {
            return this.nome;
        }
    }
}
