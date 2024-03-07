using Microsoft.AspNetCore.Mvc;
using Moq;
using TaskManagement.Api.Controllers;
using TaskManagement.Application.DTOs.Project;
using TaskManagement.Application.Interfaces;

namespace TaskManagement.Api.Tests.Project.WhenRequestCreate
{
    public class Return_Created
    {
        private ProjectController _projectController;

        [Fact(DisplayName = "Create Project Created ")]
        public async Task CreatProject_WithValidParameters()
        {
            var serviceProjectMock = new Mock<IProjectService>();
            var serviceUserMock = new Mock<IUserService>();
            serviceProjectMock.Setup(s => s.Post(It.IsAny<ProjectDTOCreate>())).ReturnsAsync(
                new ProjectDTOCreateResponse
                {
                    Id = 9,
                    ProjectName = "Name Project",
                    UserId = 1
                }
                );

            _projectController = new ProjectController(serviceUserMock.Object, serviceProjectMock.Object);           

            Mock<IUrlHelper> url = new Mock<IUrlHelper>();
            url.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns("http://localhost:5000");
            _projectController.Url = url.Object;


            var projectDTOCreate = new ProjectDTOCreate
            {
                ProjectName = "Name Project",
                UserId = 1
            };

            var result = await _projectController.Post(projectDTOCreate);
            Assert.True(result is OkObjectResult);

        }
    }
}
