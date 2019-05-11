using System;
using System.Collections.Generic;
using System.Text;
using ti_final_grafos.Data;
using ti_final_grafos.Entidade;

namespace ti_final_grafos.Repositorio
{
    class CursoRepositorio : BancoDeDados
    {
        private BancoDeDados banco = new BancoDeDados();

        public void cadastraCursoArquivo(Curso curso)
        {
            //metodo feito para 
            if (curso.Id_curso < 1)
            {
                throw new Exception("É necessário informar a id do curso");
            }

            CursoRepositorio.AbreConexaoBanco();

            CursoRepositorio.comando.CommandText = "insert into curso (nome, id_curso, departamento) " +
                "values ('" + curso.Nome + "', '" + curso.Id_curso + "', '" + curso.Departamento + "')";

            CursoRepositorio.executaComandoInsert(CursoRepositorio.comando);

            CursoRepositorio.FechaConexaoBanco();
        }
    }
}
