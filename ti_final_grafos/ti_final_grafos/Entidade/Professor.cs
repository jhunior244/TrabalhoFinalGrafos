using System;
using System.Collections.Generic;
using System.Text;

namespace ti_final_grafos.Entidade
{
    class Professor : Usuario
    {
        private int matricula;
        private AreaPesquisa areaPesquisa;

        public int Matricula { get => matricula; set => matricula = value; }

        public Professor(int mat, DateTime data_nascimento, string nome) : base(nome, data_nascimento)
        {
            this.Matricula = mat;
            this.Data_nascimento = data_nascimento;
            this.Nome = nome;
        }
        public Professor( DateTime data_nascimento, string nome) : base(nome, data_nascimento)
        {
            this.Data_nascimento = data_nascimento;
            this.Nome = nome;
        }

    }
}
