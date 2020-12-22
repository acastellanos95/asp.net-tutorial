using System;
using Microsoft.EntityFrameworkCore;

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
            }

        }
    }
}
