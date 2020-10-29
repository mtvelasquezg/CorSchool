using System;
using System.Collections.Generic;
using System.Linq;
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
        
            //CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {
            
        }

        private List<Alumno> GenerarAlumnos(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos =  from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno { Nombre =$"{n1} {n2} {a1}"};
            
            return listaAlumnos.OrderBy((a1)=> a1.UniqueId ).Take(cantidad).ToList();

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
                curso.Asignaturas = listaAsignaturas;
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

            Random rnd = new Random();

            foreach (var curso in Escuela.Cursos)
            {
                int cant = rnd.Next(5,20);
                curso.Alumnos = GenerarAlumnos(cant);
            }
        }
    }
}