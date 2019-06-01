using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using ti_final_grafos.Data;
using ti_final_grafos.Entidade;

namespace ti_final_grafos.Repositorio
{
    class ProfessorRepositorio : BancoDeDados
    {
        public string cadastraProfessor(Professor professor)
        {
            ProfessorRepositorio.AbreConexaoBanco();

            ProfessorRepositorio.comando.CommandText = "insert into professor (nome, data_nascimento) " +
                "values ('" + professor.Nome + "', '" + professor.Data_nascimento.ToString("yyyy-MM-dd") + "')";

            ProfessorRepositorio.executaComandoInsertDeleteUpdate(AlunoRepositorio.comando);

            ProfessorRepositorio.comando.CommandText = "select @@identity";

            string matricula = ProfessorRepositorio.returnPrimaryKeyUltimoDadoCadastrado(ProfessorRepositorio.comando);

            ProfessorRepositorio.FechaConexaoBanco();

            return matricula;
        }

        public List<Professor> listaProfessorPorNome(string nome)
        {
            ProfessorRepositorio.AbreConexaoBanco();

            string nomeLike = nome + "%";

            ProfessorRepositorio.comando.CommandText = "select professor.matricula, professor.data_nascimento, professor.nome " +
                "from professor where professor.nome like '" + nomeLike + "'";

            MySqlDataReader dadosRetornados = ProfessorRepositorio.executaComandoSelect(comando);

            return criaListaParaRetornar(dadosRetornados);
        }

        private List<Professor> criaListaParaRetornar(MySqlDataReader dadosRetornados)
        {
            List<Professor> listaProfessor = new List<Professor>();

            if (dadosRetornados.HasRows)
            {
                while (dadosRetornados.Read())
                {
                    Professor professor;

                    string matricula = dadosRetornados["matricula"].ToString();

                    string nome = dadosRetornados["nome"].ToString();

                    string data_nascimento = dadosRetornados["data_nascimento"].ToString();

                    DateTime data = Convert.ToDateTime(data_nascimento);

                    professor = new Professor(Convert.ToInt32(matricula), data, nome);

                    listaProfessor.Add(professor);
                }
                dadosRetornados.Close();
            }
            return listaProfessor;
        }

        public int excluiProfessor(string matricula)
        {
            ProfessorRepositorio.AbreConexaoBanco();

            ProfessorRepositorio.comando.CommandText = "delete from professor where professor.matricula = '" + matricula + "'";

            int x = ProfessorRepositorio.executaComandoInsertDeleteUpdate(comando);

            ProfessorRepositorio.FechaConexaoBanco();

            return x;
        }

        public int editaProfessor(Professor professor)
        {
            ProfessorRepositorio.AbreConexaoBanco();

            ProfessorRepositorio.comando.CommandText = "update professor set nome = '" + professor.Nome + "', data_nascimento = '" + professor.Data_nascimento.ToString("yyyy-MM-dd") + "'" 
                + " where (matricula = '" + professor.Matricula + "')";

            int x = ProfessorRepositorio.executaComandoInsertDeleteUpdate(comando);

            ProfessorRepositorio.FechaConexaoBanco();

            return x;
        }
    }
}
