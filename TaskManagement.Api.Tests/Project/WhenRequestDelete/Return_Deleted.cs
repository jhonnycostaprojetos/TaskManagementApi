using Microsoft.AspNetCore.Mvc;
using Moq;
using TaskManagement.Api.Controllers;
using TaskManagement.Application.Interfaces;

namespace TaskManagement.Api.Tests.Project.WhenRequestDelete
{
    public class Return_Deleted
    {

        private ProjectController _projectController;

        [Fact(DisplayName = "Delete Sucess ")]
        public async Task DeleteProject_WithValidParameters()
        {
            var serviceProjectMock = new Mock<IProjectService>();
            var serviceUserMock = new Mock<IUserService>();

            serviceProjectMock.Setup(m => m.Delete(It.IsAny<int>()))
                       .ReturnsAsync(true);

            _projectController = new ProjectController(serviceUserMock.Object, serviceProjectMock.Object);

            var result = await _projectController.Delete(2);
            Assert.True(result is OkObjectResult);
        }
    }
}

