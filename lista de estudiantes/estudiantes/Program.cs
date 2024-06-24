using System;
using System.Collections.Generic;

namespace GestionEstudiantes
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public double NotaFinal { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            // Agregar estudiantes
            estudiantes.Add(new Estudiante { Nombre = "Juan", NotaFinal = 8.5 });
            estudiantes.Add(new Estudiante { Nombre = "María", NotaFinal = 9.0 });
            // Puedes seguir agregando más estudiantes aquí

            // Mostrar la lista de estudiantes
            Console.WriteLine("Lista de estudiantes:");
            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine($"Nombre: {estudiante.Nombre}, Nota Final: {estudiante.NotaFinal}");
            }

            // Calcular la nota media
            double sumaNotas = 0;
            foreach (var estudiante in estudiantes)
            {
                sumaNotas += estudiante.NotaFinal;
            }
            double notaMedia = sumaNotas / estudiantes.Count;
            Console.WriteLine($"Nota media: {notaMedia}");

            // Buscar un estudiante por nombre
            Console.Write("Ingrese el nombre del estudiante a buscar: ");
            string nombreBuscado = Console.ReadLine();
            var estudianteEncontrado = estudiantes.Find(e => e.Nombre.Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase));
            if (estudianteEncontrado != null)
            {
                Console.WriteLine($"Estudiante encontrado: {estudianteEncontrado.Nombre}, Nota Final: {estudianteEncontrado.NotaFinal}");
            }
            else
            {
                Console.WriteLine("Estudiante no encontrado.");
            }
        }
    }
}
