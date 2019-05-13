using System;
using System.Collections.Generic;
using System.Text;
using ti_final_grafos.Data;

namespace ti_final_grafos.Repositorio
{
    class DissimilaridadeRepositorio : BancoDeDados
    {
        private BancoDeDados banco = new BancoDeDados();

        public void cadastraDissimilaridade(int id_area_pesquisa, int id_area_pesquisa_correspondente)
        {
            //metodo feito para 
            if (id_area_pesquisa < 1 || id_area_pesquisa_correspondente < 1)
            {
                throw new Exception("Codigo de area de pesquisa invalido");
            }

            DissimilaridadeRepositorio.AbreConexaoBanco();

            DissimilaridadeRepositorio.comando.CommandText = "insert into dissimilaridade (id_area_pesquisa, id_curso, id_area_pesquisa_correspondente) " +
                "values ('" + id_area_pesquisa + "', '" + id_area_pesquisa_correspondente + "')";

            DissimilaridadeRepositorio.executaComandoInsert(DissimilaridadeRepositorio.comando);

            DissimilaridadeRepositorio.FechaConexaoBanco();
        }
    }
}
