using System;
using System.Collections.Generic;
using System.Text;
using ti_final_grafos.Data;
using ti_final_grafos.Entidade;

namespace ti_final_grafos.Repositorio
{
    class ExaminadorRepositorio : BancoDeDados
    {
        private BancoDeDados banco = new BancoDeDados();

        public void cadastraCurso(Examinador examinador)
        {
            //metodo feito para 
            if (examinador.Matricula < 1)
            {
                throw new Exception("É necessário informar a id do curso");
            }

            ExaminadorRepositorio.AbreConexaoBanco();

            ExaminadorRepositorio.comando.CommandText = "insert into matricula (nome, matricula, departamento) " +
                "values ('" + examinador.Nome + "', '" + examinador.Matricula + "', '" + examinador.Data_nascimento.ToString("yyyy-MM-dd") + "')";

            ExaminadorRepositorio.executaComandoInsert(ExaminadorRepositorio.comando);

            ExaminadorRepositorio.FechaConexaoBanco();
        }
    }
}
