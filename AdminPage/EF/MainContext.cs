using Microsoft.EntityFrameworkCore;
using AdminPage.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AdminPage.EF
{
	public class MainContext : IdentityDbContext<AppUser, AppRole, Guid>
	{
		public MainContext(DbContextOptions<MainContext> options) : base(options) { }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Seed();
		}
		public DbSet<Entities.Task> Tasks { get; set; }
	}
}
