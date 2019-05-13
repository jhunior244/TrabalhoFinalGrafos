using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ti_final_grafos.Data;
using ti_final_grafos.Entidade;

namespace ti_final_grafos.Repositorio
{
    sealed class AlunoRepositorio : BancoDeDados
    {

        private BancoDeDados banco = new BancoDeDados();

        public void cadastraAluno(int matricula)
        {
            if(matricula < 1)
            {
                throw new Exception("É necessário informar a matricula do aluno");
            }

            AlunoRepositorio.AbreConexaoBanco();

            AlunoRepositorio.comando.CommandText = "insert into aluno (matricula) " +
                "values ('" + matricula + "')";

            AlunoRepositorio.executaComandoInsert(AlunoRepositorio.comando);

            AlunoRepositorio.FechaConexaoBanco();
        }

        public void cadastraAluno(Aluno aluno)
        {
            //metodo feito para 
            if(aluno.Matricula < 1)
            {
                throw new Exception("É necessário informar a matricula do aluno");
            }

            AlunoRepositorio.AbreConexaoBanco();

            AlunoRepositorio.comando.CommandText = "insert into aluno (nome, matricula, data_nascimento) " +
                "values ('" + aluno.Nome + "', '" + aluno.Matricula + "', '" + aluno.Data_nascimento.ToString("yyyy-MM-dd") + "')";

            AlunoRepositorio.executaComandoInsert(AlunoRepositorio.comando);

            AlunoRepositorio.FechaConexaoBanco();
        }
    }
}
