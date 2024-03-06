using Microsoft.AspNetCore.Mvc;
using Moq;
using TaskManagement.Api.Controllers;
using TaskManagement.Application.DTOs.User;
using TaskManagement.Application.Interfaces;

namespace TaskManagement.Api.Tests.Project.WhenRequestGetByUserId
{
    public class Return_OK
    {
        private ProjectController _projectController;

        [Fact(DisplayName = "GetByUserId Found")]
        public async Task GetByUserId_Found()
        {
            var serviceProjectMock = new Mock<IProjectService>();
            var serviceUserMock = new Mock<IUserService>();

            serviceUserMock.Setup(m => m.Get(It.IsAny<int>())).Returns(Task.FromResult((UserDtoCreateResponse)null));

            _projectController = new ProjectController(serviceUserMock.Object, serviceProjectMock.Object);

            var result = await _projectController.GetUserWithId(1);
            Assert.True(result is OkObjectResult);

        }
    }
}
