using Microsoft.AspNetCore.Mvc;
using Moq;
using TaskManagement.Api.Controllers;
using TaskManagement.Application.DTOs.Project;
using TaskManagement.Application.Interfaces;

namespace TaskManagement.Api.Tests.Project.WhenRequestUpdate
{
    public class Return_UpdateOK
    {
        private ProjectController _projectController;

        [Fact(DisplayName = "Update OK")]
        public async Task Updated_Ok()
        {
            var serviceProjectMock = new Mock<IProjectService>();
            var serviceUserMock = new Mock<IUserService>();

            serviceProjectMock.Setup(m => m.Put(It.IsAny<ProjectDTOUpdate>())).ReturnsAsync(
              new ProjectDTOUpdateResponse
              {
                  Id = 1,
                  ProjectName = "Project",                  
                  UpdateAt = DateTime.UtcNow
              }
          );

            _projectController = new ProjectController(serviceUserMock.Object, serviceProjectMock.Object);

            var projectUpdate = new ProjectDTOUpdate
            {
                ProjectName = "Update Project"

            };

            var result = await _projectController.Put(projectUpdate);
            Assert.True(result is OkObjectResult);
        }
    }
}
