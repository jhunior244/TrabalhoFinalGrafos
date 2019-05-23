using System;
using System.Collections.Generic;
using System.Text;

namespace ti_final_grafos.Entidade
{
    public class Curso
    {
        private string id_curso;

        private string nome;

        private string departamento;

        private List<Curso_AreaPesquisa> listaCurso_AreaPesquisas;

        public string Id_curso { get => id_curso; set => id_curso = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Departamento { get => departamento; set => departamento = value; }

        public Curso(string id_curso, string nome, string departamento)
        {
            this.Id_curso = id_curso;
            this.Nome = nome;
            this.Departamento = departamento;
        }

        public Curso(string nome)
        {
            this.nome = nome;
        }

        public override string ToString()
        {
            return this.Nome;
        }

    }
}
