using AdminPage.Models.Enums;

namespace AdminPage.Models.Task
{
	public class TaskDtos
	{
		public Guid Id { get; set; }
		public string? Name { get; set; }
		public Guid? AssigneeId { get; set; }
		public string Assignee { get; set; }
		public DateTime CreatedDate { get; set; }
		public Priority Priority { get; set; }
		public Status Status { get; set; }
	}
}
