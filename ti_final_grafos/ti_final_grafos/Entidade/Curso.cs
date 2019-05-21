using System;
using System.Collections.Generic;
using System.Text;

namespace ti_final_grafos.Entidade
{
    public class Curso
    {
        private int id_curso;

        private string nome;

        private string departamento;

        private List<Curso_AreaPesquisa> listaCurso_AreaPesquisas;

        public int Id_curso { get => id_curso; set => id_curso = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Departamento { get => departamento; set => departamento = value; }

        public Curso(int id_curso, string nome, string departamento)
        {
            this.Id_curso = id_curso;
            this.Nome = nome;
            this.Departamento = departamento;
        }

    }
}
