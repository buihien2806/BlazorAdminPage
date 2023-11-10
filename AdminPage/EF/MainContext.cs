using Microsoft.EntityFrameworkCore;
using AdminPage.Entities;

namespace AdminPage.EF
{
	public class MainContext : DbContext
	{
		public MainContext(DbContextOptions<MainContext> options) : base(options) { }

		public DbSet<Entities.Task> Tasks { get; set; }
	}
}
