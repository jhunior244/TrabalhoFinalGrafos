using System;
using System.Collections.Generic;
using System.Text;

namespace ti_final_grafos.Entidade
{
    class Grupo
    {
        private List<Aluno> listaAluno;
        private Tema tema;
        private Professor professor_orientador;

        public Grupo(List<Aluno> listaAluno, Tema tema, Professor professorOrientador)
        {
            this.listaAluno = listaAluno;
            this.tema = tema;
            this.professor_orientador = professorOrientador;
        }
    }
}
