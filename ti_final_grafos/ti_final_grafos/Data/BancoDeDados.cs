using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ti_final_grafos.Entidade;

namespace ti_final_grafos.Data
{
    class BancoDeDados
    {
        private string stringConexao = "server=localhost;port=3306;User Id=root;database=teste; password=881100;SSL Mode=None";

        protected static MySqlConnection conexao = new MySqlConnection();

        protected void AbreConexaoBanco()
        {
            try
            {
                conexao = new MySqlConnection("server=localhost;port=3306;User Id=root;database=teste; password=881100;SSL Mode=None");
                conexao.Open();
            }
            catch (Exception erro)
            {
                //tratar futuramente como enviar mensagem de erro para usuario
                Console.WriteLine(erro.Message);
            }
        }

        protected void FechaConexaoBanco()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception erro)
            {
                //tratar futuramente como enviar mensagem de erro para usuario
                Console.WriteLine(erro.Message);
            }
        }

        public string MontaQueryInsert(string tabela, List<Object> colunas, List<Object> dados)
        {
            //if(tabela == null || colunas == null || dados == null)
            //{
            //    return null;
            //}dfdsafasdf

            MySqlCommand mySqlCommand = new MySqlCommand();

            string colunasParaQuery = "";

            //colunas.ForEach(delegate (Object objeto));

            string query = "insert into " + tabela + "(" + colunasParaQuery + ")";

            Aluno aluno = new Aluno();
            aluno.matricula = 3434;
            aluno.nome = "nada";
            Object objeto = aluno;
            List<Object> lista = new List<object>();
            lista.Add("teste");
            lista.Add(true);


            return "";



        }

        public void teste()
        {
            //try
            //{
            //    MySqlCommand mySqlCommand = new MySqlCommand();

            //    string nome = "google";
            //    mySqlCommand.CommandText = "INSERT INTO aluno (nome) VALUES( '" + nome + "')";

            //    mySqlCommand = new MySqlCommand(mySqlCommand.CommandText, objConexao);
            //    mySqlCommand.ExecuteNonQuery();

            //    mySqlCommand.CommandText = "select @@identity";
            //    string id_aluno = mySqlCommand.ExecuteScalar().ToString();

            //    mySqlCommand = new MySqlCommand(mySqlCommand.CommandText, objConexao);
            //    mySqlCommand.ExecuteNonQuery();

            //    nome = "engenharia da computação";
            //    mySqlCommand.CommandText = "insert into curso (nome) values ('" + nome + "')";

            //    mySqlCommand = new MySqlCommand(mySqlCommand.CommandText, objConexao);
            //    mySqlCommand.ExecuteNonQuery();

            //    mySqlCommand.CommandText = "select @@identity";
            //    string id_curso = mySqlCommand.ExecuteScalar().ToString();


            //    mySqlCommand.CommandText = "INSERT INTO aluno_has_curso (aluno_idaluno,curso_idcurso) VALUES( '" + id_aluno + "', '" + id_curso + "')";

            //    mySqlCommand = new MySqlCommand(mySqlCommand.CommandText, objConexao);
            //    mySqlCommand.ExecuteNonQuery();

            //    MessageBox.Show("gravou");
            //    objConexao.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}
        }
    }
}
