using AdminPage.EF;
using AdminPage.Models.Task;
using AdminPage.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using Task = AdminPage.Entities.Task;

namespace AdminPage.Repositories.Services
{
	public class TaskRepository : ITaskRepository
	{
		private readonly MainContext _mainContext;
		public TaskRepository(MainContext context)
		{
			_mainContext = context;
		}
		public async Task<Task> Create(Task task)
		{
			await _mainContext.Tasks.AddAsync(task);
			await _mainContext.SaveChangesAsync();
			return task;
		}

		public async Task<Task> Delete(Task task)
		{
			_mainContext.Tasks.Remove(task);
			await _mainContext.SaveChangesAsync();
			return task;
		}

		public Task<Task> GetById(Guid id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<TaskView>> GetTaskList()
		{
			var query = from t in _mainContext.Tasks
					   select t;
			return await query.Select(x => new TaskView()
			{
				Id= x.Id,
				Name= x.Name,
				CreatedDate= x.CreatedDate
			}).ToListAsync();
		}

		public async Task<Task> Update(Task task)
		{
			_mainContext.Tasks.Update(task);
			await _mainContext.SaveChangesAsync();
			return task;
		}
	}
}
