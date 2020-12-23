using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ReadData
{
	public class AppVentaCursosContext : DbContext
	{
		private const string connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=EntityFWCore-2-5;Integrated Security=True";
		public DbSet<Curso> Curso { get; set; }
		public DbSet<Precio> Precio { get; set; }
		public DbSet<Comentario> Comentario { get; set; }
		public DbSet<Instructor> Instructor { get; set; }
		public DbSet<CursoInstructor> CursoInstructor { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(connectionString);
		}
		protected override void OnModelCreating(ModelBuilder modelBuider)
		{
			modelBuider.Entity<CursoInstructor>().HasKey( ci => new {ci.CursoId, ci.InstructorId});
		}
	}
}