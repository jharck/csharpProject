using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new CoreEscuela.Entidades.Escuela("Platzi", 2002);
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogota";
            escuela.TipoEscuela = TiposEscuela.Primaria;

            var curso1 = new Curso() {
                Nombre="101"
            };

            var curso2 = new Curso() {
                Nombre="201"
            };

            var curso3 = new Curso() {
                Nombre="301"
            };

            escuela.Cursos = new List<Curso>(){
                new Curso(){ Nombre = "101"},
                new Curso(){ Nombre = "201"},
                new Curso(){ Nombre = "301"},
            };

            escuela.Cursos.Add( new Curso() { Nombre = "102", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add( new Curso() { Nombre = "202", Jornada = TiposJornada.Tarde });

            escuela.Cursos.RemoveAll((cur) => cur.Nombre == "301");
            escuela.Cursos.RemoveAll((cur) => cur.Nombre == "101" && cur.Jornada == TiposJornada.Tarde);

            Console.WriteLine(escuela);
            
            System.Console.WriteLine(new string('=', 50));
            
            System.Console.WriteLine(curso1.Nombre + ", " + curso1.UniqueId);
            System.Console.WriteLine(curso2.Nombre + ", " + curso2.UniqueId);
            System.Console.WriteLine(curso3);

        }
    }
}
