namespace ReadData
{
    public class Comentario
    {
        public int ComentarioId { get; set; }
        public string Alumno { get; set; }
        public string ComentarioTexto { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; } // Ancla para relacionar CursoId con la tabla Cursos
    }
}