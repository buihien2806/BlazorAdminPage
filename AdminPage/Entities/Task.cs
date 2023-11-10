using AdminPage.Enums;
using System.ComponentModel.DataAnnotations;

namespace AdminPage.Entities
{
	public class Task
	{
		[Key]
		public Guid Id { get; set; }
		public string Name { get; set; }
		public Guid? AssigneeId { get; set; }
		//public AppUser? Assignee { get; set; }
		public DateTime CreatedDate { get; set; }
		public Priority Priority { get; set; }
		public Status Status { get; set; }
	}
}
