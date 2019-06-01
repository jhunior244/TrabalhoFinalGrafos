using System;
using System.Collections.Generic;
using System.Text;

namespace ti_final_grafos.Entidade
{
    public class Usuario
    {
        private string nome;
        private DateTime data_nascimento;

        public string Nome { get => nome; set => nome = value; }
        public DateTime Data_nascimento { get => data_nascimento; set => data_nascimento = value; }

        public Usuario(string nome, DateTime data_nascimento)
        {
            this.Nome = nome;
            this.Data_nascimento = data_nascimento;
        }
        public Usuario()
        {

        }
    }
}
