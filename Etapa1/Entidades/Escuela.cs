namespace CoreEscuela.Entidades
{
    class Escuela
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public int AñoDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        public Escuela(string nombre, int año )
        {
            this.nombre = nombre;
            AñoDeCreacion = año;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela}, Pais: {Pais}";
        }

    }
}