using System;
using System.Collections.Generic;
using System.Text;

namespace ti_final_grafos.Entidade
{
    class Usuario
    {
        private string nome;
        private DateTime data_nascimento;

        public string Nome { get => nome; }
        public DateTime Data_nascimento { get => data_nascimento;  }

        public Usuario(string nome, DateTime data_nascimento)
        {
            this.nome = nome;
            this.data_nascimento = data_nascimento;
        }
        public Usuario()
        {

        }
    }
}
