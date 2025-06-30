using System;
using System.Collections.Generic;
using System.Linq;

namespace EjerciciosConsola
{
    class Curso
    {
        public string Nombre { get; set; }
        public double Nota { get; set; }

        public Curso(string nombre)
        {
            Nombre = nombre;
        }

        public void PedirNota()
        {
            Console.Write($"Ingresa la nota para {Nombre}: ");
            double.TryParse(Console.ReadLine(), out double nota);
            Nota = nota;
        }

        public void MostrarNota()
        {
            Console.WriteLine($"En {Nombre} obtuviste una nota de {Nota}");
        }
    }

    class ProgramaPrincipal
    {
        static List<Curso> cursos = new List<Curso>
        {
            new Curso("Biología"),
            new Curso("Arte"),
            new Curso("Informática"),
            new Curso("Geografía"),
            new Curso("Inglés")
        };

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\n--- MENÚ DE EJERCICIOS ---");
                Console.WriteLine("1. Mostrar lista de cursos");
                Console.WriteLine("2. Mostrar mensaje: Estoy inscrito en...");
                Console.WriteLine("3. Ingresar y mostrar notas");
                Console.WriteLine("4. Números ganadores del bingo (ordenados)");
                Console.WriteLine("5. Mostrar números del 20 al 30 en orden inverso");
                Console.WriteLine("0. Salir");
                Console.Write("Selecciona una opción: ");

                int.TryParse(Console.ReadLine(), out opcion);
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        MostrarCursos();
                        break;
                    case 2:
                        MostrarMensajesCursos();
                        break;
                    case 3:
                        PedirYMostrarNotas();
                        break;
                    case 4:
                        OrdenarBingo();
                        break;
                    case 5:
                        MostrarNumerosInversos();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 0);
        }

        static void MostrarCursos()
        {
            Console.WriteLine("Cursos disponibles:");
            foreach (var curso in cursos)
            {
                Console.WriteLine($"- {curso.Nombre}");
            }
        }

        static void MostrarMensajesCursos()
        {
            foreach (var curso in cursos)
            {
                Console.WriteLine($"Estoy inscrito en {curso.Nombre}");
            }
        }

        static void PedirYMostrarNotas()
        {
            Console.WriteLine("Ingresa tus notas:");
            foreach (var curso in cursos)
            {
                curso.PedirNota();
            }

            Console.WriteLine("\nResultados:");
            foreach (var curso in cursos)
            {
                curso.MostrarNota();
            }
        }

        static void OrdenarBingo()
        {
            Console.Write("Introduce los números ganadores del bingo separados por espacios: ");
            string entrada = Console.ReadLine();
            List<int> numeros = entrada.Split(' ').Select(n => int.Parse(n)).ToList();
            numeros.Sort();

            Console.WriteLine("Números ordenados: " + string.Join(", ", numeros));
        }

        static void MostrarNumerosInversos()
        {
            List<int> numeros = new List<int>();
            for (int i = 20; i <= 30; i++)
            {
                numeros.Add(i);
            }
            numeros.Reverse();
            Console.WriteLine("Números del 20 al 30 en orden inverso: " + string.Join(", ", numeros));
        }
    }
}

