using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2010, TiposEscuela.PreEscolar, ciudad: "Bogotá");

            CargarCursos();
            CargarAsignatura();
            CargarAlumnos();
            CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargarAlumnos()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

        }

        private void CargarAsignatura()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                            new Asignatura{Nombre = "Matematicas"} ,
                            new Asignatura{Nombre = "Castellano"} ,
                            new Asignatura{Nombre = "Ciencias Naturales"}
                };
                curso.Asignaturas.AddRange(listaAsignaturas);
            }
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>()
            {
                new Curso {Nombre = "101"},
                new Curso {Nombre = "201"},
                new Curso {Nombre = "301"}
            };
        }
    }
}