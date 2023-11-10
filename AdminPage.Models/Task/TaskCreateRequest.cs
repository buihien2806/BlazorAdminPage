using AdminPage.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace AdminPage.Models.Task
{
	public class TaskCreateRequest
	{
		[MaxLength(100, ErrorMessage = "You cannot fill task name over than 100 characters")]
		[Required(ErrorMessage = "Please enter your task name")]
		public string? Name { get; set; }

		[Required(ErrorMessage = "Please select your task priority")]
		public Priority? Priority { get; set; }
	}
}
