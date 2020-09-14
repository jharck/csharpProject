using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        public string Nombre { get; set; }

        public int AnioDeCreacion { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        public List<Curso> Cursos { get; set; }

        public Escuela(string nombre, int anio)
        {
            Nombre = nombre;
            AnioDeCreacion = anio;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela}, \nPais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}