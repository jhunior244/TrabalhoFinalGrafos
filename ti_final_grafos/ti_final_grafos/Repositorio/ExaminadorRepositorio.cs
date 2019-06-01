using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using ti_final_grafos.Data;
using ti_final_grafos.Entidade;

namespace ti_final_grafos.Repositorio
{
    class ExaminadorRepositorio : BancoDeDados
    {
        private BancoDeDados banco = new BancoDeDados();

        public int cadastraExaminador(Examinador examinador)
        {

            ExaminadorRepositorio.AbreConexaoBanco();

            ExaminadorRepositorio.comando.CommandText = "insert into examinador (nome, data_nascimento) " +
                "values ('" + examinador.Nome + "', '" + examinador.Data_nascimento.ToString("yyyy-MM-dd") + "')";

            int x = ExaminadorRepositorio.executaComandoInsertDeleteUpdate(ExaminadorRepositorio.comando);

            ExaminadorRepositorio.FechaConexaoBanco();

            return x;
        }

        public List<Examinador> listaExaminadorPorNome(string nome)
        {
            ExaminadorRepositorio.AbreConexaoBanco();

            string nomeLike = nome + "%";

            ExaminadorRepositorio.comando.CommandText = "select examinador.matricula, examinador.nome, examinador.data_nascimento from examinador " +
                "where examinador.nome  like '" + nomeLike + "'";

            MySqlDataReader dadosRetornados = AlunoRepositorio.executaComandoSelect(comando);

            return criaListaParaRetornar(dadosRetornados);
        }

        private List<Examinador> criaListaParaRetornar(MySqlDataReader dadosRetornados)
        {
            List<Examinador> listaExaminador = new List<Examinador>();

            if (dadosRetornados.HasRows)
            {
                while (dadosRetornados.Read())
                {
                    Examinador examinador;

                    string matricula = dadosRetornados["matricula"].ToString();

                    string nome = dadosRetornados["nome"].ToString();

                    string data_nascimento = dadosRetornados["data_nascimento"].ToString();

                    DateTime data = Convert.ToDateTime(data_nascimento);

                    examinador = new Examinador(Convert.ToInt32(matricula), data, nome);

                    listaExaminador.Add(examinador);

                }
                dadosRetornados.Close();
            }
            return listaExaminador;
        }

        public int excluiExaminador(string matricula)
        {
            ExaminadorRepositorio.AbreConexaoBanco();

            ExaminadorRepositorio.comando.CommandText = "delete from examinador where examinador.matricula = '" + matricula + "'";

            int x = ExaminadorRepositorio.executaComandoInsertDeleteUpdate(comando);

            ExaminadorRepositorio.FechaConexaoBanco();

            return x;
        }

        public int editaExaminador(Examinador examinador)
        {
            ExaminadorRepositorio.AbreConexaoBanco();

            ExaminadorRepositorio.comando.CommandText = "update examinador set nome = '" + examinador.Nome + "', data_nascimento = '" + examinador.Data_nascimento.ToString("yyyy-MM-dd") + "'"
                + " where (matricula = '" + examinador.Matricula + "')";

            int x = ExaminadorRepositorio.executaComandoInsertDeleteUpdate(comando);

            ExaminadorRepositorio.FechaConexaoBanco();

            return x;
        }
    }
}

