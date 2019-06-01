using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ti_final_grafos.Data;
using ti_final_grafos.Entidade;

namespace ti_final_grafos.Repositorio
{
    class ExaminadorTccRepositorio : BancoDeDados
    {
        private BancoDeDados banco = new BancoDeDados();

        public void ligaExaminadorTcc(string matriculaExaminador, List<Tcc> listaTcc)
        {
            ExaminadorTccRepositorio.AbreConexaoBanco();

            foreach (Tcc item in listaTcc)
            {
                ExaminadorTccRepositorio.comando.CommandText = "insert into examinador_tcc (examinador_matricula, id_tcc) " +
                "values ('" + matriculaExaminador + "', '" + item.Id_tcc + "')";

                ExaminadorTccRepositorio.executaComandoInsertDeleteUpdate(AlunoRepositorio.comando);
            }

            ExaminadorTccRepositorio.FechaConexaoBanco();
        }
    }
}
