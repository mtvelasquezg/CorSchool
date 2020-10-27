using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();

            ImprimirCursosEscuela(engine.Escuela);
            
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            if (escuela?.Cursos != null)
            {
                Printer.DibujarTitulo("Imprimiendo cursos");
                foreach (var Curso in escuela.Cursos)
                {
                    WriteLine(Curso.Nombre);
                }
            }
        }
    }
}

