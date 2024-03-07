using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Moq;
using TaskManagement.Api.Controllers;
using TaskManagement.Application.DTOs.TaskProject;
using TaskManagement.Application.Interfaces;

namespace TaskManagement.Api.Tests.TaskProject.WhenRequestCreate
{
    public class Return_BadRequest
    {
        private TaskProjectController _taskProjectController;

        [Fact(DisplayName = "Create TaskProject BadResquest ")]
        public async Task CreatTask_WithInvalidParameters()
        {

            var serviceTaskProjectMock = new Mock<ITaskProjectService>();
            var serviceCommentMock = new Mock<ICommentService>();

            serviceTaskProjectMock.Setup(s => s.Post(It.IsAny<TaskProjectDTOCreate>())).ReturnsAsync(
                new TaskProjectDTOCreateResponse
                {
                    Id = 1,
                    ProjectId = 9,
                    Title = "Title Task Projectt",
                    Description = "Description",
                    Status = 0,
                    Priority = 1,
                    DueDate = DateTime.Now
                }
                );

            _taskProjectController = new TaskProjectController(serviceTaskProjectMock.Object, serviceCommentMock.Object);
            _taskProjectController.ModelState.AddModelError("NameProject", "Is Required!");

            Mock<IUrlHelper> url = new Mock<IUrlHelper>();
            url.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns("http://localhost:5000");
            _taskProjectController.Url = url.Object;


            var taskProjectDTOCreate = new TaskProjectDTOCreate
            {
                ProjectId = 0,
                Title = "Title Task Project",
                Description = "Description",
                Status = 0,
                Priority = 1,
                DueDate = DateTime.Now
            };

            var result = await _taskProjectController.Post(taskProjectDTOCreate);
            Assert.True(result is BadRequestObjectResult);

        }
    }
}
