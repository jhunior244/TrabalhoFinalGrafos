using System;
using System.Collections.Generic;
using System.Text;
using ti_final_grafos.Data;
using ti_final_grafos.Entidade;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ti_final_grafos.Repositorio
{
    class CursoRepositorio : BancoDeDados
    {
        private BancoDeDados banco = new BancoDeDados();

        public void cadastraCurso(Curso curso)
        {
            //metodo feito para 
            if (curso.Id_curso == null)
            {
                throw new Exception("É necessário informar a id do curso");
            }

            CursoRepositorio.AbreConexaoBanco();

            CursoRepositorio.comando.CommandText = "insert into curso (nome, id_curso, departamento) " +
                "values ('" + curso.Nome + "', '" + curso.Id_curso + "', '" + curso.Departamento + "')";

            CursoRepositorio.executaComandoInsertDeleteUpdate(CursoRepositorio.comando);

            CursoRepositorio.FechaConexaoBanco();
        }

        public Curso obtemPorNome(string nome)
        {
            Curso curso = null;

            CursoRepositorio.AbreConexaoBanco();

            CursoRepositorio.comando.CommandText = "select curso.nome, curso.id_curso, curso.departamento from curso where curso.nome = '" + nome + "'";

            MySqlDataReader objetoRetornado = CursoRepositorio.executaComandoSelect(comando);

            if (objetoRetornado.HasRows)
            {
                objetoRetornado.Read();

                string id_curso = objetoRetornado["id_curso"].ToString();

                string nomeCurso = objetoRetornado["nome"].ToString();

                string departamento = objetoRetornado["departamento"].ToString();

                curso = new Curso(id_curso, nomeCurso, departamento);

                objetoRetornado.Close();
            }
            else 
            {
                MessageBox.Show("Curso não encontrado na base de dados. Verifique se o nome está correto e tente novamente.");
                return null;
            }

            return curso;
        }

        public List<Curso> buscaCurso()
        {
            List<Curso> listaCurso = new List<Curso>();

            CursoRepositorio.AbreConexaoBanco();

            CursoRepositorio.comando.CommandText = "select * from curso";

            MySqlDataReader dadosRetornados = CursoRepositorio.executaComandoSelect(CursoRepositorio.comando);

            if (dadosRetornados.HasRows)
            {
                while (dadosRetornados.Read())
                {
                    Curso curso;

                    string id = dadosRetornados["id_curso"].ToString();

                    string nomeCurso = dadosRetornados["nome"].ToString();

                    string departamento = dadosRetornados["departamento"].ToString();

                    curso = new Curso(id, nomeCurso, departamento);

                    listaCurso.Add(curso);

                }
                dadosRetornados.Close();
            }
            return listaCurso;
        }
    }
}
