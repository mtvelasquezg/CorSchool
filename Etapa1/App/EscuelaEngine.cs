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

            Escuela.Cursos = new List<Curso>()
            {
                new Curso {Nombre = "101"},
                new Curso {Nombre = "201"},
                new Curso {Nombre = "301"}
            };
        }
    }
}