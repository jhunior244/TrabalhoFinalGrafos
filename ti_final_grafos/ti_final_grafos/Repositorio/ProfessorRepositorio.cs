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
        //    mySqlCommand.CommandText = "select @@identity";
        //    string id_aluno = mySqlCommand.ExecuteScalar().ToString();

        //    mySqlCommand = new MySqlCommand(mySqlCommand.CommandText, objConexao);
        //    mySqlCommand.ExecuteNonQuery();
    }
}
