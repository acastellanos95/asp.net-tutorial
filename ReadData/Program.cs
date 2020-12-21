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
                var cursos = db.Curso.AsNoTracking();
                foreach (var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo + ": " + curso.Descripcion);
                }
            }

        }
    }
}
