﻿using System;
using System.Collections.Generic;
using System.Text;
using ti_final_grafos.Data;
using ti_final_grafos.Entidade;
using MySql.Data.MySqlClient;

namespace ti_final_grafos.Repositorio
{
    class CursoRepositorio : BancoDeDados
    {
        private BancoDeDados banco = new BancoDeDados();

        public void cadastraCurso(Curso curso)
        {
            //metodo feito para 
            if (curso.Id_curso == null)
            {
                throw new Exception("É necessário informar a id do curso");
            }

            CursoRepositorio.AbreConexaoBanco();

            CursoRepositorio.comando.CommandText = "insert into curso (nome, id_curso, departamento) " +
                "values ('" + curso.Nome + "', '" + curso.Id_curso + "', '" + curso.Departamento + "')";

            CursoRepositorio.executaComandoInsert(CursoRepositorio.comando);

            CursoRepositorio.FechaConexaoBanco();
        }

        public List<Curso> buscaCurso()
        {
            List<Curso> listaCurso = new List<Curso>();

            CursoRepositorio.AbreConexaoBanco();

            CursoRepositorio.comando.CommandText = "select * from curso";

            MySqlDataReader dadosRetornados = CursoRepositorio.executaComandoSelect(CursoRepositorio.comando);

            if (dadosRetornados.HasRows)
            {
                while (dadosRetornados.Read())
                {
                    Curso curso;

                    string id = dadosRetornados["id_curso"].ToString();

                    string nomeCurso = dadosRetornados["nome"].ToString();

                    string departamento = dadosRetornados["departamento"].ToString();

                    curso = new Curso(id, nomeCurso, departamento);

                    listaCurso.Add(curso);

                }
                dadosRetornados.Close();
            }
            return listaCurso;
        }
    }
}
