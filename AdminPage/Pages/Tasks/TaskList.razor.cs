using AdminPage.Models.Task;
using AdminPage.Repositories.Interfaces;
using Microsoft.AspNetCore.Components;

namespace AdminPage.Pages.Tasks
{
	public partial class TaskList
	{
		[Inject] private ITaskRepository taskRepository { get; set; }

		private List<TaskView> taskView;

		protected override async Task OnInitializedAsync()
		{
			taskView = await taskRepository.GetTaskList();
		}
	}
}
