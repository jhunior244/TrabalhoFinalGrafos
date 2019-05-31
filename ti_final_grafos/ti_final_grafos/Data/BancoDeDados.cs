using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ti_final_grafos.Entidade;

namespace ti_final_grafos.Data
{
    public class BancoDeDados
    {
        private static string stringConexao = "server=localhost;port=3306;User Id=root;database=bd_ti_final; password=881100;SSL Mode=None";

        private static MySqlConnection conexao = new MySqlConnection();

        protected static MySqlCommand comando = new MySqlCommand();

        protected static void AbreConexaoBanco()
        {
            try
            {
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();
            }
            catch (Exception erro)
            {
                //tratar futuramente como enviar mensagem de erro para usuario
                Console.WriteLine(erro.Message);
            }
        }

        protected static void FechaConexaoBanco()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception erro)
            {
                //tratar futuramente como enviar mensagem de erro para usuario
                MessageBox.Show("Ocorreu o seguinte erro ao tentar fechar a conexao: " + erro.Message);
                Console.WriteLine(erro.Message);
            }
        }

        protected static int executaComandoInsertDeleteUpdate(MySqlCommand comando)
        {
            int result = 0;
            try
            {
                comando = new MySqlCommand(comando.CommandText, conexao);
                result = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro ao executar a ação: " + ex.Message);
            }
            return result;
        }

        protected static MySqlDataReader executaComandoSelect(MySqlCommand comando)
        {
            MySqlDataReader objetoRetornado = null;
            try
            {
                comando = new MySqlCommand(comando.CommandText, conexao);
                objetoRetornado = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu o seguinte erro ao executar a ação: " + ex.Message);
            }
            return objetoRetornado;
        }

        public static string returnPrimaryKeyUltimoDadoCadastrado(MySqlCommand comando)
        {
            string retorno = "";
            try
            {
                comando = new MySqlCommand(comando.CommandText, conexao);
                retorno = comando.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu o seguinte erro ao executar a ação: " + ex.Message);
            }
            return retorno;
        }

        public void teste()
        {
            //try
            //{
            ////    MySqlCommand mySqlCommand = new MySqlCommand();

            ////    string nome = "google";
            ////    mySqlCommand.CommandText = "INSERT INTO aluno (nome) VALUES( '" + nome + "')";

            ////    mySqlCommand = new MySqlCommand(mySqlCommand.CommandText, objConexao);
            ////    mySqlCommand.ExecuteNonQuery();

            ////    mySqlCommand.CommandText = "select @@identity";
            ////    string id_aluno = mySqlCommand.ExecuteScalar().ToString();

            ////    mySqlCommand = new MySqlCommand(mySqlCommand.CommandText, objConexao);
            ////    mySqlCommand.ExecuteNonQuery();

            ////    nome = "engenharia da computação";
            ////    mySqlCommand.CommandText = "insert into curso (nome) values ('" + nome + "')";

            ////    mySqlCommand = new MySqlCommand(mySqlCommand.CommandText, objConexao);
            ////    mySqlCommand.ExecuteNonQuery();

            ////    mySqlCommand.CommandText = "select @@identity";
            ////    string id_curso = mySqlCommand.ExecuteScalar().ToString();


            ////    mySqlCommand.CommandText = "INSERT INTO aluno_has_curso (aluno_idaluno,curso_idcurso) VALUES( '" + id_aluno + "', '" + id_curso + "')";

            ////    mySqlCommand = new MySqlCommand(mySqlCommand.CommandText, objConexao);
            ////    mySqlCommand.ExecuteNonQuery();

            ////    MessageBox.Show("gravou");
            ////    objConexao.Close();
            ////}
            ////catch (Exception ex)
            ////{
            ////    MessageBox.Show(ex.Message);

            ////}
        }
    }
}
