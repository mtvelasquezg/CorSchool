using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {

        public string Nombre { get; set; }
              
        public int AñoDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        public List<Curso> Cursos { get; set; }
        public Escuela(string nombre, int año ) => (Nombre, AñoDeCreacion) = (nombre, año);

        public Escuela(string nombre, int año, TiposEscuela tipos, string pais="", string ciudad=null)
        {
            (Nombre, AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela}, {System.Environment.NewLine} Pais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}