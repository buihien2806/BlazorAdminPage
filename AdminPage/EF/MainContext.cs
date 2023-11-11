using Microsoft.EntityFrameworkCore;
using AdminPage.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace AdminPage.EF
{
	public class MainContext : IdentityDbContext<AppUser, AppRole, Guid>
	{
		public MainContext(DbContextOptions<MainContext> options) : base(options) { }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
			modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
			modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
			modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
			modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

			modelBuilder.Seed();
		}
		public DbSet<Entities.Task> Tasks { get; set; }
	}
}
