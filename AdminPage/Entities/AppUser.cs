using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPage.Entities
{
	//[Table("AppUsers")]

	public class AppUser : IdentityUser<Guid>
	{
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime LastLogin { get; set; }
		public bool isActive { get; set; }
		public List<Task>? Tasks { get; set; }
	}
}
