namespace ReadData
{
    public class Precio
    {
        public int PrecioId { get; set; }
        public decimal PrecioActual { get; set; }
        public decimal Promocion { get; set; }
        public int CursoId { get; set; }
        public Curso curso { get; set; } // Ancla para relacionar CursoId con la tabla Cursos
    }
}