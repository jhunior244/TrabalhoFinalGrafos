using System;
using System.Collections.Generic;
using System.Text;
using ti_final_grafos.Entidade;
using ti_final_grafos.Repositorio;

namespace ti_final_grafos.Servico
{
    class AlunoServico
    {
        AlunoRepositorio alunoRepositorio = new AlunoRepositorio();

        public void cadastraAluno(Aluno aluno)
        {
            alunoRepositorio.cadastraAluno(aluno);
        }
    }
}
