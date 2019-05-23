using System;
using System.Collections.Generic;
using System.Text;

namespace ti_final_grafos.Entidade
{
    public class Aluno : Usuario
    {
        private int matricula;

        private Curso curso;

        //atributo adicionado apenas para resolver o problema de grafos
        //(deve ser ignorado dentro do modelo adequado do sistema para BD e ER)
        private int id_area_pesquisa;

        public int Matricula { get => matricula; set => matricula = value; }
        public int Id_area_pesquisa { get => id_area_pesquisa; set => id_area_pesquisa = value; }
        public Curso Curso { get => curso; set => curso = value; }

        public Aluno(DateTime data_nascimento, string nome, Curso curso):base(nome, data_nascimento)
        {
            this.curso = curso;
        }

        public Aluno(int mat, int id_area)
        {
            this.matricula = mat;
            this.id_area_pesquisa = id_area;
        }
    }
}
