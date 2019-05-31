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
    sealed class ProfessorCursoRepositorio : BancoDeDados
    {

        private BancoDeDados banco = new BancoDeDados();

        public void ligaProfessorCurso(string matriculaProfessor, List<Curso> listaAreaPesquisa)
        {
            ProfessorCursoRepositorio.AbreConexaoBanco();

            foreach (Curso item in listaAreaPesquisa)
            {
                ProfessorCursoRepositorio.comando.CommandText = "insert into professor_curso (professor_matricula, id_curso) " +
                "values ('" + matriculaProfessor + "', '"+item.Id_curso+"')";

                ProfessorCursoRepositorio.executaComandoInsertDeleteUpdate(ProfessorCursoRepositorio.comando);
            }

            ProfessorCursoRepositorio.FechaConexaoBanco();
        }
    }
}
