using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using ti_final_grafos.Data;
using ti_final_grafos.Entidade;

namespace ti_final_grafos.Repositorio
{
    class TccRepositorio : BancoDeDados
    {
        public List<Tcc> listaTcc()
        {
            List<Tcc> listaTcc = new List<Tcc>();

            TccRepositorio.AbreConexaoBanco();

            TccRepositorio.comando.CommandText = "select tema.titulo_tema, area_pesquisa.nome, tcc.id_tcc from tcc " +
                "inner join area_pesquisa inner join tema on area_pesquisa.id_area_pesquisa = tema.id_area_pesquisa and " +
                "tema.id_tema = tcc.id_tema";

            MySqlDataReader dadosRetornados = TccRepositorio.executaComandoSelect(TccRepositorio.comando);

            if (dadosRetornados.HasRows)
            {
                while (dadosRetornados.Read())
                {
                    Tcc tcc;

                    string id = dadosRetornados["id_tcc"].ToString();

                    string tituloTema = dadosRetornados["titulo_tema"].ToString();

                    string nomeAreaPesquisa = dadosRetornados["nome"].ToString();

                    AreaPesquisa areaPesquisa = new AreaPesquisa(nomeAreaPesquisa);

                    Tema tema = new Tema(tituloTema);

                    tcc = new Tcc(Convert.ToInt32(id), tema);

                    listaTcc.Add(tcc);

                }
                dadosRetornados.Close();
            }
            return listaTcc;
        }
    }
}
