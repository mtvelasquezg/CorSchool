using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2010, TiposEscuela.PreEscolar, ciudad: "Bogotá");
            Console.WriteLine(escuela);
            Console.WriteLine(escuela.Pais == null);

            escuela.Cursos = new List<Curso> ()
            {
                new Curso {Nombre = "101"},
                new Curso {Nombre = "201"},
                new Curso {Nombre = "301"}
            };

            escuela.Cursos.Add(new Curso {Nombre = "401"});

            var otraColeccion = new List<Curso> ()
            {
                new Curso {Nombre = "102"},
                new Curso {Nombre = "202"},
                new Curso {Nombre = "302"},
                new Curso {Nombre = "402"}
            };

            escuela.Cursos.AddRange(otraColeccion);

            Predicate<Curso>miAlgoritmo = predicado;
            escuela.Cursos.RemoveAll(miAlgoritmo);
            
            ImprimirCursosEscuela(escuela);

            
        }

        private static bool predicado(Curso obj)
        {
            return obj.Nombre == "301";
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            if (escuela?.Cursos != null)
            {
                foreach (var Curso in escuela.Cursos)
                {
                    Console.WriteLine(Curso.Nombre);
                }
            }
        }
    }
}

