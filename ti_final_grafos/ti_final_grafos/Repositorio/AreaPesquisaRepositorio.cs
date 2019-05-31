using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using ti_final_grafos.Data;
using ti_final_grafos.Entidade;

namespace ti_final_grafos.Repositorio
{
    class AreaPesquisaRepositorio : BancoDeDados
    {
        private BancoDeDados banco = new BancoDeDados();

        public void cadastraAreaPesquisa(AreaPesquisa areaPesquisa)
        {
            //metodo feito para 
            if (areaPesquisa.Id_area_pesquisa < 1)
            {
                throw new Exception("É necessário informar a id da area de pesquisa");
            }

            AreaPesquisaRepositorio.AbreConexaoBanco();

            AreaPesquisaRepositorio.comando.CommandText = "insert into area_pesquisa (nome, id_area_pesquisa) " +
                "values ('" + areaPesquisa.Nome + "', '" + areaPesquisa.Id_area_pesquisa + "')";

            AreaPesquisaRepositorio.executaComandoInsertDeleteUpdate(AlunoRepositorio.comando);

            AreaPesquisaRepositorio.FechaConexaoBanco();
        }

        public void cadastraAreaPesquisa(int id_area_pesquisa)
        {
            //metodo feito para 
            if (id_area_pesquisa < 1)
            {
                throw new Exception("É necessário informar a id da area de pesquisa");
            }

            AreaPesquisaRepositorio.AbreConexaoBanco();

            AreaPesquisaRepositorio.comando.CommandText = "insert into area_pesquisa (id_area_pesquisa) " +
                "values ('" + id_area_pesquisa + "')";

            AreaPesquisaRepositorio.executaComandoInsertDeleteUpdate(AlunoRepositorio.comando);

            AreaPesquisaRepositorio.FechaConexaoBanco();
        }

        public List<AreaPesquisa> listaAreaPesquisa()
        {
            List<AreaPesquisa> listaAreaPesquisa = new List<AreaPesquisa>();

            AreaPesquisaRepositorio.AbreConexaoBanco();

            AreaPesquisaRepositorio.comando.CommandText = "select * from area_pesquisa";

            MySqlDataReader dadosRetornados = AreaPesquisaRepositorio.executaComandoSelect(AreaPesquisaRepositorio.comando);

            if (dadosRetornados.HasRows)
            {
                while (dadosRetornados.Read())
                {
                    AreaPesquisa areaPesquisa;

                    string id = dadosRetornados["id_area_pesquisa"].ToString();

                    string nomeCurso = dadosRetornados["nome"].ToString();

                    areaPesquisa = new AreaPesquisa(Convert.ToInt32(id), nomeCurso);

                    listaAreaPesquisa.Add(areaPesquisa);

                }
                dadosRetornados.Close();
            }
            return listaAreaPesquisa;
        }
    }
}
