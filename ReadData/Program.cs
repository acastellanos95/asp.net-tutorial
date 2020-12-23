using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ReadData
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using(var db = new AppVentaCursosContext())
            {
                var cursos = db.Curso.Include( p => p.Precio).AsNoTracking();
                foreach (var curso in cursos)
                {
                    Console.WriteLine($"{curso.Titulo}: {curso.Descripcion}, con precio de: {curso.Precio.PrecioActual}");
                }

                cursos = db.Curso.Include( c => c.ComentariosList ).AsNoTracking();
                foreach (var curso in cursos)
                {
                    Console.WriteLine($"{curso.Titulo}: ");
                    foreach (var comentario in curso.ComentariosList)
                    {
                        Console.WriteLine($"*****comentario: {comentario.ComentarioTexto}");
                    }
                }
                cursos = db.Curso.Include( c => c.InstructorLink ).ThenInclude( ci => ci.Instructor).AsNoTracking();
                foreach (var curso in cursos)
                {
                    Console.WriteLine($"{curso.Titulo}: ");
                    foreach (var instructorLink in curso.InstructorLink)
                    {
                        Console.WriteLine($"*****instructor: {instructorLink.Instructor.Nombre}");
                    }
                }
                var curso1 = db.Curso.Where(p => p.Titulo.StartsWith("ASP")).First();
                Console.WriteLine(curso1.Titulo);
            }

        }
    }
}
