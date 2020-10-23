using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2010);
            escuela.TipoEscuela = TiposEscuela.PreEscolar;
            Console.WriteLine(escuela);
        }
    }
}
