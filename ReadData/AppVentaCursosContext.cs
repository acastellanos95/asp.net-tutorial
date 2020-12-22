using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ReadData
{
	public class AppVentaCursosContext : DbContext
	{
		private const string connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=EntityFWCore-2-5;Integrated Security=True";
		public DbSet<Curso> Curso { get; set; }
		public DbSet<Precio> Precio { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(connectionString);
		}
	}
}