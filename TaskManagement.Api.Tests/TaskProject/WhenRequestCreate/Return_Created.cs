using Microsoft.AspNetCore.Mvc;
using Moq;
using TaskManagement.Api.Controllers;
using TaskManagement.Application.DTOs.TaskProject;
using TaskManagement.Application.Interfaces;

namespace TaskManagement.Api.Tests.TaskProject.WhenRequestCreate
{

    public class Return_Created
    {
        private TaskProjectController _taskProjectController;

        [Fact(DisplayName = "Create TaskProject ")]
        public async Task CreatProject_WithValidParameters()
        {
            var serviceTaskProjectMock = new Mock<ITaskProjectService>();
            var serviceCommentMock = new Mock<ICommentService>();
            serviceTaskProjectMock.Setup(s => s.Post(It.IsAny<TaskProjectDTOCreate>())).ReturnsAsync(
                new TaskProjectDTOCreateResponse
                {
                    Id = 3,
                    ProjectId = 1,
                    Title = "Title Task Project",
                    Description = "Description",
                    Status = 0,
                    Priority = 1,
                    DueDate = DateTime.Now
                }
                );

            _taskProjectController = new TaskProjectController(serviceTaskProjectMock.Object, serviceCommentMock.Object);

            Mock<IUrlHelper> url = new Mock<IUrlHelper>();
            url.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns("http://localhost:5000");
            _taskProjectController.Url = url.Object;


            var taskProjectDTOCreate = new TaskProjectDTOCreate
            {
                ProjectId = 2,
                Title = "Name Project",
                Description = "Description",
                Status = 0,
                Priority = 1,
                DueDate = DateTime.Now
            };

            var result = await _taskProjectController.Post(taskProjectDTOCreate);
            Assert.True(result is OkObjectResult);

        }
    }
}
