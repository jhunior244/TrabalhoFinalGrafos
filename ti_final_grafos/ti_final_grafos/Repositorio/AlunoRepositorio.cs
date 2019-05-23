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
            AlunoRepositorio.AbreConexaoBanco();

            AlunoRepositorio.comando.CommandText = "insert into aluno (nome, data_nascimento, id_curso) " +
                "values ('" + aluno.Nome + "', '" + aluno.Data_nascimento.ToString("yyyy-MM-dd") + "', '"+aluno.Curso.Id_curso+"' )";

            AlunoRepositorio.executaComandoInsert(AlunoRepositorio.comando);

            AlunoRepositorio.FechaConexaoBanco();
        }

        public List<Aluno> listaAluno(Curso curso)
        {
            AlunoRepositorio.AbreConexaoBanco();

            AlunoRepositorio.comando.CommandText = "select * from aluno where id_curso = '" + curso.Id_curso + "'";

            return null;
        }

        public List<Aluno> listaAlunoPorCurso(Curso curso)
        {
            List<Aluno> listaAluno = new List<Aluno>();

            AlunoRepositorio.AbreConexaoBanco();

            AlunoRepositorio.comando.CommandText = "select aluno.nome, aluno.data_nascimento, curso.nome as nomeCurso from aluno " +
                "inner join curso where curso.nome = '" + curso.Nome + "'";

            MySqlDataReader dadosRetornados = AlunoRepositorio.executaComandoSelect(comando);

            if (dadosRetornados.HasRows)
            {
                while (dadosRetornados.Read())
                {
                    Aluno aluno;

                    string nome = dadosRetornados["nome"].ToString();

                    string cursoNome = dadosRetornados["nomeCurso"].ToString();

                    string data_nascimento = dadosRetornados["data_nascimento"].ToString();

                    DateTime data = Convert.ToDateTime(data_nascimento);

                    Curso novoCurso = new Curso(cursoNome);

                    aluno = new Aluno(data, nome, novoCurso);

                    listaAluno.Add(aluno);

                }
                dadosRetornados.Close();
            }
            return listaAluno;
        }
    }
}
