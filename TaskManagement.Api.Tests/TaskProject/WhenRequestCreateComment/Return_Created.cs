using Microsoft.AspNetCore.Mvc;
using Moq;
using TaskManagement.Api.Controllers;
using TaskManagement.Application.DTOs.Comment;
using TaskManagement.Application.Interfaces;

namespace TaskManagement.Api.Tests.TaskProject.WhenRequestCreateComment
{

    public class Return_Created
    {
        private TaskProjectController _taskProjectController;

        [Fact(DisplayName = "Create CommentTaskProject ")]
        public async Task CreateCommentTaskProject()
        {
            var serviceTaskProjectMock = new Mock<ITaskProjectService>();
            var serviceCommentMock = new Mock<ICommentService>();
            serviceCommentMock.Setup(s => s.Post(It.IsAny<CommentDTOCreate>())).ReturnsAsync(
                new CommentDTOCreateResponse
                {
                    Id = 1,
                    TaskComment = "Novo Comentario",
                    CreateAt = DateTime.Now,
                }
                );

            _taskProjectController = new TaskProjectController(serviceTaskProjectMock.Object, serviceCommentMock.Object);

            Mock<IUrlHelper> url = new Mock<IUrlHelper>();
            url.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns("http://localhost:5000");
            _taskProjectController.Url = url.Object;


            var taskProjectDTOCreate = new CommentDTOCreate
            {
                TaskComment = "Name Project",
                TaskProjectId = 2,
                IdUser = 1,
            };

            var result = await _taskProjectController.PostComment(taskProjectDTOCreate);
            Assert.True(result is OkObjectResult);

        }
    }
}
