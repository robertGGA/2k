using TaskTracker.Core.Entities;
using TaskTracker.Core.Interfaces;
using TaskTracker.WebAPI.APIModels;
using TaskTracker.WebAPI.APIModels.ProjectAPIModels;
using TaskTracker.WebAPI.APIModels.TaskItemAPIModels;
using Microsoft.AspNetCore.Mvc;
using TaskTracker.Core.Middlewares;

namespace TaskTracker.WebAPI.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class TaskItemController : ControllerBase
    {
        private readonly IProjectRepository _projectRepository;
        private readonly ITaskItemRepository _taskItemRepository;
        private readonly LoggerMiddleware _loggerMiddleware;

        public TaskItemController(
            IProjectRepository projectRepository,
            ITaskItemRepository taskItemRepository,
            LoggerMiddleware loggerMiddleware)
        {
            _projectRepository = projectRepository;
            _taskItemRepository = taskItemRepository;
            _loggerMiddleware = loggerMiddleware;
        }

        [HttpGet("{projectId:int}/tasks/{taskItemId:int}")]
        public ActionResult<TaskItemAPIModel> GetById(int projectId, int taskItemId)
        {
            try
            {
                var project = _projectRepository.GetById(projectId);
                if (project == null)
                    return NotFound();

                var task = project.TasksItems.FirstOrDefault(t => t.Id == taskItemId);
                if (task == null)
                    return NotFound();
                
                return Ok(TaskItemAPIModel.FromTaskItem(task));
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorAPIModel(ex.Message));
            }
        }

        [HttpGet("{projectId:int}/tasks")]
        public ActionResult<IEnumerable<TaskItemAPIModel>> GetAll(int projectId)
        {
            try
            {
                var project = _projectRepository.GetById(projectId);
                if (project == null)
                    return NotFound();

                var result =
                    project.TasksItems
                        .Select(t => TaskItemAPIModel.FromTaskItem(t))
                        .ToList();
            
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorAPIModel(ex.Message));
            }
        }

        [HttpPost("{projectId:int}/tasks")]
        public ActionResult<CreateTaskItemAPIModel> CreateTaskItem(int projectId, [FromBody] CreateTaskItemAPIModel model)
        {
            try
            {
                var project = _projectRepository.GetById(projectId);
                if (project == null)
                    return BadRequest();

                var task = new TaskItem(model.Name);

                task.Description = model.Description;
                task.SetStartDate(model.StartDate);
                task.SetCompletionDate(model.CompletionDate);
                task.Priority = model.Priority;
                project.AddTask(task);
                _taskItemRepository.Add(task);
                
                _loggerMiddleware.LogFile(task.ToString());

                return CreatedAtAction(nameof(GetById), new { projectId = projectId, taskItemId = task.Id }, model);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorAPIModel(ex.Message));
            }
        }

        [HttpPut("{projectId:int}/tasks/{taskItemId:int}")]
        public ActionResult<ProjectAPIModel> UpdateTaskItem(int projectId, int taskItemId, [FromBody] UpdateTaskItemAPIModel model)
        {
            try
            {
                var project = _projectRepository.GetById(projectId);
                if (project == null)
                    return NotFound();

                var task = project.TasksItems.FirstOrDefault(t => t.Id == taskItemId);
                if (task == null)
                    return NotFound();

                task.Name = model.Name;
                task.Description = model.Description;
                task.SetStartDate(model.StartDate);
                task.SetCompletionDate(model.CompletionDate);
                task.Status = model.Status;
                task.Priority = model.Priority;

                _taskItemRepository.Update(task);
                _loggerMiddleware.LogFile(task.ToString());

                return Ok(TaskItemAPIModel.FromTaskItem(task));
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorAPIModel(ex.Message));
            }
        }

        [HttpDelete("{projectId:int}/tasks/{taskItemId:int}")]
        public IActionResult DeleteProject(int projectId, int taskItemId)
        {
            try
            {
                var project = _projectRepository.GetById(projectId);
                if (project == null)
                    return NotFound();

                var task = project.TasksItems.FirstOrDefault(t => t.Id == taskItemId);
                if (task == null)
                    return NotFound();

                _taskItemRepository.Delete(taskItemId);
                _loggerMiddleware.LogFile(task.ToString());

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorAPIModel(ex.Message));
            }
        }
    }
}
