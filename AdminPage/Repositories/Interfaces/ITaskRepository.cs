using AdminPage.Models.Task;
using Task = AdminPage.Entities.Task;

namespace AdminPage.Repositories.Interfaces
{
	public interface ITaskRepository
	{
		Task<List<TaskView>> GetTaskList();
		Task<Task> Create(Task task);
		Task<Task> Update(Task task);
		Task<Task> Delete(Task task);
		Task<Task> GetById(Guid id);
	}
}
