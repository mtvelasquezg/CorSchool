using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2010, TiposEscuela.PreEscolar, ciudad:"Bogotá");
            Console.WriteLine(escuela);
            Console.WriteLine(escuela.Pais == null);
        }
    }
}
