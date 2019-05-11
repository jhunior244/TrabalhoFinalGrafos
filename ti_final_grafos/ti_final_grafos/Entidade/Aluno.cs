using System;
using System.Collections.Generic;
using System.Text;

namespace ti_final_grafos.Entidade
{
    class Aluno : Usuario
    {
        private int matricula;

        public int Matricula { get => matricula; set => matricula = value; }

        public Aluno(int matricula, DateTime data_nascimento, string nome):base(nome, data_nascimento)
        {
            this.matricula = matricula;
        }

        public Aluno(int mat)
        {
            this.matricula = mat;
        }
    }
}
