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

            WriteLine("==========================");
            ImprimirCursosEscuela(escuela);
            
            escuela.Cursos.RemoveAll(delegate (Curso cur){
                                        return cur.Nombre == "301";
                                    });

            WriteLine("==========================");
            ImprimirCursosEscuela(escuela);

            escuela.Cursos.RemoveAll((Curso cur) => cur.Nombre == "402");

            WriteLine("==========================");
            ImprimirCursosEscuela(escuela);
            
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            if (escuela?.Cursos != null)
            {
                foreach (var Curso in escuela.Cursos)
                {
                    WriteLine(Curso.Nombre);
                }
            }
        }
    }
}

