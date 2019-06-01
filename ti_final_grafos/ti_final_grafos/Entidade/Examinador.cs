using System;
using System.Collections.Generic;
using System.Text;

namespace ti_final_grafos.Entidade
{
    class Examinador : Usuario
    {
        private int matricula;
        private List<Tcc> listaTcc;

        public int Matricula { get => matricula; }
        internal List<Tcc> ListaTcc { get => listaTcc; }

        public Examinador(int matricula, DateTime data_nascimento, string nome) : base(nome, data_nascimento)
        {
            this.matricula = matricula;
        }

        public Examinador(DateTime data_nascimento, string nome) : base(nome, data_nascimento)
        {
        }
    }
}
