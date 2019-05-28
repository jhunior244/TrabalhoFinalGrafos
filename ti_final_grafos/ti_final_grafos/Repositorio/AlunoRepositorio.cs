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
            if (matricula < 1)
            {
                throw new Exception("É necessário informar a matricula do aluno");
            }

            AlunoRepositorio.AbreConexaoBanco();

            AlunoRepositorio.comando.CommandText = "insert into aluno (matricula) " +
                "values ('" + matricula + "')";

            AlunoRepositorio.executaComandoInsertDeleteUpdate(AlunoRepositorio.comando);

            AlunoRepositorio.FechaConexaoBanco();
        }

        public void cadastraAluno(Aluno aluno)
        {
            AlunoRepositorio.AbreConexaoBanco();

            AlunoRepositorio.comando.CommandText = "insert into aluno (nome, data_nascimento, id_curso) " +
                "values ('" + aluno.Nome + "', '" + aluno.Data_nascimento.ToString("yyyy-MM-dd") + "', '" + aluno.Curso.Id_curso + "' )";

            AlunoRepositorio.executaComandoInsertDeleteUpdate(AlunoRepositorio.comando);

            AlunoRepositorio.FechaConexaoBanco();
        }

        public List<Aluno> listaAlunoPorNome(string nome)
        {
            AlunoRepositorio.AbreConexaoBanco();

            string nomeLike = nome + "%";

            AlunoRepositorio.comando.CommandText = "select aluno.matricula, aluno.nome, aluno.data_nascimento, curso.nome as nomeCurso from aluno " +
                "inner join curso where aluno.nome  like '" + nomeLike + "'" + " and aluno.id_curso = curso.id_curso" ;

            MySqlDataReader dadosRetornados = AlunoRepositorio.executaComandoSelect(comando);

            return criaListaParaRetornar(dadosRetornados);
        }

        public List<Aluno> listaAlunoPorNomeECurso(Curso curso, string nome)
        {
            AlunoRepositorio.AbreConexaoBanco();

            string nomeLike = nome + "%";

            AlunoRepositorio.comando.CommandText = "select aluno.matricula, aluno.nome, aluno.data_nascimento, curso.nome as nomeCurso from aluno " +
                "inner join curso where curso.nome = '" + curso.Nome + "'" + "and aluno.nome like '"+ nomeLike +"'" + " and curso.id_curso = aluno.id_curso";

            MySqlDataReader dadosRetornados = AlunoRepositorio.executaComandoSelect(comando);

            return criaListaParaRetornar(dadosRetornados);
        }

        public List<Aluno> listaAlunoPorCurso(Curso curso)
        {
            AlunoRepositorio.AbreConexaoBanco();

            AlunoRepositorio.comando.CommandText = "select aluno.matricula, aluno.nome, aluno.data_nascimento, curso.nome as nomeCurso from aluno " +
                "inner join curso where curso.nome = '" + curso.Nome + "'" + " and curso.id_curso = aluno.id_curso";

            MySqlDataReader dadosRetornados = AlunoRepositorio.executaComandoSelect(comando);

            return criaListaParaRetornar(dadosRetornados);
        }

        public int excluiAluno(string matricula)
        {
            AlunoRepositorio.AbreConexaoBanco();

            AlunoRepositorio.comando.CommandText = "delete from aluno where aluno.matricula = '" + matricula + "'";

            int x =AlunoRepositorio.executaComandoInsertDeleteUpdate(comando);

            AlunoRepositorio.FechaConexaoBanco();

            return x;
        }

        public int editaAluno(Aluno aluno)
        {
            AlunoRepositorio.AbreConexaoBanco();

            AlunoRepositorio.comando.CommandText = "update aluno set nome = '"+aluno.Nome+"', data_nascimento = '"+ aluno.Data_nascimento.ToString("yyyy-MM-dd") + "'," +
                "id_curso = '"+aluno.Curso.Id_curso+"' where (matricula = '"+aluno.Matricula+"')";

            int x = AlunoRepositorio.executaComandoInsertDeleteUpdate(comando);

            AlunoRepositorio.FechaConexaoBanco();

            return x;
        }

        private List<Aluno> criaListaParaRetornar(MySqlDataReader dadosRetornados)
        {
            List<Aluno> listaAluno = new List<Aluno>();

            if (dadosRetornados.HasRows)
            {
                while (dadosRetornados.Read())
                {
                    Aluno aluno;

                    string matricula = dadosRetornados["matricula"].ToString();

                    string nome = dadosRetornados["nome"].ToString();

                    string cursoNome = dadosRetornados["nomeCurso"].ToString();

                    string data_nascimento = dadosRetornados["data_nascimento"].ToString();

                    DateTime data = Convert.ToDateTime(data_nascimento);

                    Curso novoCurso = new Curso(cursoNome);

                    aluno = new Aluno(Convert.ToInt32(matricula), data, nome, novoCurso);

                    listaAluno.Add(aluno);

                }
                dadosRetornados.Close();
            }
            return listaAluno;
        }
    }
}
