using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti_final_grafos.Erro
{
    public class Erro : Exception
    {
        public static string faltaMatriculaAluno()
        {
            return "É necessário informar a matricula do aluno";
        }
    }
}
