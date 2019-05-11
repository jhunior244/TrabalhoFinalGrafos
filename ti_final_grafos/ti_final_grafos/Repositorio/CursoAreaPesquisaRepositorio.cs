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
    class CursoAreaPesquisaRepositorio : BancoDeDados
    {
        private BancoDeDados banco = new BancoDeDados();

        public void ligaCursoAreaPesquisa(string nomeCurso, string nomeAreaPesquisa)
        {
            if (nomeCurso == null || nomeAreaPesquisa == null)
            {
                throw new Exception("Os valores estão em um padrão incorreto. Verifique e tente novamente.");
            }

            string idCurso = null;
            string idAreaPesquisa = null;

            CursoAreaPesquisaRepositorio.AbreConexaoBanco();

            CursoAreaPesquisaRepositorio.comando.CommandText = "SELECT id_area_pesquisa FROM area_pesquisa" +
                " where nome = '" + nomeAreaPesquisa + "'";

            MySqlDataReader id_area_pesquisa = CursoAreaPesquisaRepositorio.executaComandoSelect(CursoAreaPesquisaRepositorio.comando);

            if (id_area_pesquisa.HasRows)
            {
                id_area_pesquisa.Read();

                idAreaPesquisa = id_area_pesquisa["id_area_pesquisa"].ToString();

            }
            CursoAreaPesquisaRepositorio.FechaConexaoBanco();

            CursoAreaPesquisaRepositorio.AbreConexaoBanco();

            CursoAreaPesquisaRepositorio.comando.CommandText = "SELECT id_curso FROM curso" +
                " where nome = '" + nomeCurso + "'";

            MySqlDataReader id_curso = CursoAreaPesquisaRepositorio.executaComandoSelect(CursoAreaPesquisaRepositorio.comando);

            if (id_curso.HasRows)
            {
                id_curso.Read();

                idCurso = id_curso["id_curso"].ToString();

                CursoAreaPesquisaRepositorio.FechaConexaoBanco();
            }
            cadastraCursoAreaPesquisa(idAreaPesquisa, idCurso);
        }

        private void cadastraCursoAreaPesquisa(string idAreaPesquisa, string idCurso)
        {

            if (idAreaPesquisa == null || idAreaPesquisa == null)
            {
                throw new Exception("Os valores estão incorretos. Verifique e tente novamente.");
            }

            CursoAreaPesquisaRepositorio.AbreConexaoBanco();

            CursoAreaPesquisaRepositorio.comando.CommandText = "insert into curso_area_pesquisa (id_curso, id_area_pesquisa) " +
                "values ('" + idCurso + "', '" + idAreaPesquisa + "')";

            CursoAreaPesquisaRepositorio.executaComandoInsert(CursoAreaPesquisaRepositorio.comando);

            CursoAreaPesquisaRepositorio.FechaConexaoBanco();//
        }
    }
}
