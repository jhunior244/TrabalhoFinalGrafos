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
    sealed class ProfessorAreaPesquisaRepositorio : BancoDeDados
    {

        private BancoDeDados banco = new BancoDeDados();

        public void ligaProfessorAreaPesquisa(string matriculaProfessor, List<AreaPesquisa> listaAreaPesquisa)
        {
            ProfessorAreaPesquisaRepositorio.AbreConexaoBanco();

            foreach (AreaPesquisa item in listaAreaPesquisa)
            {
                ProfessorAreaPesquisaRepositorio.comando.CommandText = "insert into professor_area_pesquisa (professor_matricula, id_area_pesquisa) " +
                "values ('" + matriculaProfessor + "', '"+item.Id_area_pesquisa+"')";

                AlunoRepositorio.executaComandoInsertDeleteUpdate(AlunoRepositorio.comando);
            }

            AlunoRepositorio.FechaConexaoBanco();
        }
    }
}
