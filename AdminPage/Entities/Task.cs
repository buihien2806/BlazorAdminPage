using AdminPage.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPage.Entities
{
	public class Task
	{
		[Key]
		public Guid Id { get; set; }
		public string Name { get; set; }
		public Guid? AssigneeId { get; set; }
		[ForeignKey(nameof(AssigneeId))]
		public AppUser? Assignee { get; set; }
		public DateTime CreatedDate { get; set; }
		public Priority Priority { get; set; }
		public Status Status { get; set; }
	}
}
 