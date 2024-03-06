using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Api.Controllers;
using TaskManagement.Application.Interfaces;

namespace TaskManagement.Api.Tests.Project.WhenRequestDelete
{
    public class Return_BadRequest
    {
        private ProjectController _projectController;

        [Fact(DisplayName = "Delete BadRequest ")]
        public async Task DeleteProject_WithInvaleParameters()
        {
            var serviceProjectMock = new Mock<IProjectService>();
            var serviceUserMock = new Mock<IUserService>();

            serviceProjectMock.Setup(m => m.Delete(It.IsAny<int>()))
                       .ReturnsAsync(true);

            _projectController = new ProjectController(serviceUserMock.Object, serviceProjectMock.Object);
            _projectController.ModelState.AddModelError("Id", "Invalid Format!");

            var result = await _projectController.Delete(-1);
            Assert.True(result is BadRequestObjectResult);
        }
    }
}
